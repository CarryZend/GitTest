using Eagle.DBUtility;
using Eagle.Entity;
using Eagle.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Eagle.Data
{
    /// <summary>
    /// 通用数据库操作类，暂时没有事务的支持。
    /// </summary>
    public class GenericDataAccessLayer<T> where T : IEntity, new()
    {
        #region Insert插入（对外公开接口）

        /// <summary>
        /// 将实体对像插入到数据库。
        /// 注：主键不能赋值。
        /// </summary>
        public static int Insert(T Entity)
        {
            return BuildInsertSql(Entity);
        }

        /// <summary>
        /// 将实体对像数组插入到数据库。
        /// 注：主键不能赋值。
        /// </summary>
        public static int Insert(T[] Entity)
        {
            if (Entity == null || Entity.Length == 0)
            {
                return 0;
            }
            for (int i = 0; i < Entity.Length; i++)
            {
                BuildInsertSql(Entity[i]);
            }
            return 1;
        }

        #endregion

        #region Delete删除（对外公开接口）

        /// <summary>
        /// 将实体对象从数据库永久删除。
        /// 注：主键不能为空，实际按主键作为条件删除。
        /// </summary>
        public static int Delete(T Entity)
        {
            return BuildDeleteSql(Entity);
        }

        /// <summary>
        /// 将实体对象数组从数据库永久删除。
        /// 注：主键不能为空，实际按主键作为条件删除。
        ///     后期改进可增加事务功能，防止中途错误
        ///     导致部份成功删除，部份不成功，如果错
        ///     误可全部回滚。
        /// </summary>
        public static int Delete(T[] Entity)
        {
            if (Entity == null || Entity.Length == 0)
            {
                return 0;
            }
            for (int i = 0; i < Entity.Length; i++)
            {
                BuildDeleteSql(Entity[i]);
            }
            return Entity.Length;
        }

        #endregion

        #region  Select查询（对外公开接口）

        #region 字符查询条件或无条件

        /// <summary>
        /// 从数据库查询整张数据表，按主键字段降序排序，返回DataTable对象。
        /// </summary>
        public static DataTable SelectAllRows()
        {

            string sql = "SELECT * FROM [" + typeof(T).Name.Replace("Entity", "") + "] ";
            string OrderBy = GetPrimaryKeyOrderByDesc();
            if (OrderBy.Length > 0)
            {
                sql += "order by " + OrderBy;
            }
            return DbHelperSQL.Query(sql).Tables[0];
        }

        /// <summary>
        /// 从数据库查询分页数据表，按主键字段降序排序，返回DataTable对象。
        /// </summary>
        public static DataTable SelectAllRows(PageInfo pageinfo)
        {
            string sql = "SELECT * FROM [" + typeof(T).Name.Replace("Entity", "") + "] ";
            string OrderBy = GetPrimaryKeyOrderByDesc();
            if (OrderBy.Length > 0)
            {
                sql += "order by " + OrderBy;
            }
            string RetSql = DbHelperSQL.BuildSelectWithPage(sql, pageinfo, null);
            return DbHelperSQL.Query(RetSql, null).Tables[0];
        }

        /// <summary>
        /// 从数据库查询整张数据表,自定义排序，返回DataTable对象。
        /// 注：不输入“order by”关键字。
        /// </summary>
        public static DataTable SelectAllRows(string OrderBy)
        {
            string sql = "SELECT * FROM [" + typeof(T).Name.Replace("Entity", "") + "]  order by ";
            sql += OrderBy;
            return DbHelperSQL.Query(sql).Tables[0];
        }

        #endregion

        #region 返回DataTable

        /// <summary>
        /// 以传入对象为条件从数据库筛选数据，返回一个DataTable对象，默认按主键降序排序。
        /// </summary>
        public static DataTable SelectRowsByEntityCondition(T Entity)
        {
            return ExecuteSelectSql(Entity, null, null);
        }

        /// <summary>
        /// 以传入对象为条件从数据库筛选数据，返回一个DataTable对象，自定义排序。
        /// 注：不输入“order by”关键字。
        /// </summary>
        public static DataTable SelectRowsByEntityCondition(T Entity, string OrderBy)
        {
            return ExecuteSelectSql(Entity, OrderBy, null);
        }

        /// <summary>
        /// 以传入对象为条件从数据库筛选数据，按分页对象要求返回一个DataTable对象，自定义排序。
        /// 注：不输入“order by”关键字。
        /// </summary>
        public static DataTable SelectRowsByEntityCondition(T Entity, string OrderBy, PageInfo p)
        {
            return ExecuteSelectSql(Entity, OrderBy, p);
        }


        /// <summary>
        /// 以传入对象为条件从数据库筛选数据，按分页对象要求返回一个DataTable对象，默认按主键降序排序。
        /// 注：不输入“order by”关键字。
        /// </summary>
        public static DataTable SelectRowsByEntityCondition(T Entity, PageInfo p)
        {
            return ExecuteSelectSql(Entity, null, p);
        }
        #endregion

        #region 返回对象数组(各种组合)

        /// <summary>
        /// 从数据库查询整张数据表，按主键字段降序排序，返回转换后的对象数组。
        /// </summary>
        public static T[] SelectAllEntities()
        {
            DataTable t = SelectAllRows();
            if (t.Rows.Count == 0)
            {
                return null;
            }
            return ConvertToEntity(t);
        }

        /// <summary>
        /// 以传入对象为条件从数据库筛选数据，按主键字段降序排序，返回转换后的对象数组。
        /// </summary>
        public static T[] SelectEntitiesByEntityCondition(T Entity)
        {
            return ConvertToEntity(ExecuteSelectSql(Entity, null, null));
        }

        /// <summary>
        /// 以传入对象为条件从数据库筛选数据，自定义排序，返回转换后的对象数组。
        /// </summary>
        public static T[] SelectEntitiesByEntityCondition(T Entity, string OrderBy)
        {
            return ConvertToEntity(ExecuteSelectSql(Entity, OrderBy, null));
        }

        /// <summary>
        /// 以传入对象为条件从数据库筛选数据，自定义排序，按分页对象要求返回转换后的对象数组。
        /// </summary>
        public static T[] SelectEntitiesByEntityCondition(T Entity, string OrderBy, PageInfo p)
        {
            return ConvertToEntity(ExecuteSelectSql(Entity, OrderBy, p));
        }

        /// <summary>
        /// 以传入对象为条件从数据库筛选数据，默认按主键降序排序，按分页对象要求返回转换后的对象数组。
        /// </summary>
        public static T[] SelectEntitiesByEntityCondition(T Entity, PageInfo p)
        {
            return ConvertToEntity(ExecuteSelectSql(Entity, null, p));
        }

        #endregion

        #endregion

        #region Update更新（对外公开接口）

        /// <summary>
        /// 将传入对象永久持续化到数据库。
        /// 注：主键不能为空，底层实际按主键为条件持续化。
        /// </summary>
        public static int Update(T Entity)
        {
            return BuildUpdateSql(Entity);
        }

        /// <summary>
        ///  以传入对象为条件将Entity更新数据库。
        ///  注：不推荐使用此方法。
        /// </summary>
        public static int Update(T Entity, T Where)
        {
            return BuildUpdateSql(Entity, Where);
        }

        /// <summary>
        /// 将对象数组持续化到数据库。
        /// 注：主键不能为空，底层实际按主键为条件持续化。
        /// </summary>
        public static int Update(T[] Entity)
        {
            if (Entity == null || Entity.Length == 0)
            {
                return 0;
            }
            for (int i = 0; i < Entity.Length; i++)
            {
                BuildUpdateSql(Entity[i]);
            }
            return Entity.Length;
        }

        #endregion

        #region 实体函数(内部实现私有函数)

        /// <summary>
        /// 获取实体对象数据库字段属性P的操作符。
        /// 注：P必需为数据库字段属性。
        /// </summary>
        static private string GetOperator(T Entity, System.Reflection.PropertyInfo p)
        {
            CompareParam cp = (CompareParam)Entity.GetType().GetProperty(p.Name + "CompareParam").GetValue(Entity, null);
            switch (cp)
            {
                case CompareParam.Equal:
                    return "=";
                case CompareParam.GreaterOrEqual:
                    return ">=";
                case CompareParam.GreaterThan:
                    return ">";
                case CompareParam.LessOrEqual:
                    return "<=";
                case CompareParam.LessThan:
                    return "<";
                case CompareParam.NotEqual:
                    return "!=";
                default:
                    return "=";
            }
        }

        /// <summary>
        /// 生成主键降序排序字符串。
        /// </summary>
        static private string GetPrimaryKeyOrderByDesc()
        {
            string OrderBy = string.Empty;
            T TmpEntity = new T();
            IList<PropertyInfo> PrimaryKeys = TmpEntity.GetPrimaryKeys();
            foreach (PropertyInfo p in PrimaryKeys)
            {
                OrderBy += p.Name + " desc,";
            }
            if (OrderBy.IndexOf(',') > -1)
            {
                OrderBy = OrderBy.Substring(0, OrderBy.LastIndexOf(',')).Trim();
            }
            return OrderBy;
        }

        /// <summary>
        /// 判断该属性是否是数据库字段,且该字段的值被初始化过。
        /// True:不是数据库字段或未被初始化。
        /// False:是数据库字段且被初始化。
        /// </summary>
        static private bool CheckQueryEntity(T Entity, System.Reflection.PropertyInfo p)
        {
            //是否是字段属性
            if (p.Name.Contains("Changed") || p.Name.Contains("CompareParam") || p.Name.Contains("DbType"))
            {
                return true;
            }
            //是否初始化过
            System.Reflection.PropertyInfo QueryProperty = Entity.GetType().GetProperty(p.Name + "Changed");
            bool ContinueValue = (bool)QueryProperty.GetValue(Entity, null);
            return !ContinueValue;
        }

        /// <summary>
        /// 判断该字段是否是主键字段。
        /// True：是。
        /// False:不是。
        /// </summary>
        static private bool IsPrimaryKey(T Entity, System.Reflection.PropertyInfo p)
        {
            List<PropertyInfo> ProperList = Entity.GetPrimaryKeys();
            return ProperList.Contains(p);
        }

        /// <summary>
        /// 判断该属性是否是数据库字段。
        /// True：不是。
        /// False:是。
        /// </summary>
        static private bool CheckReturnEntity(T Entity, System.Reflection.PropertyInfo p)
        {
            if (p.Name.Contains("Changed") || p.Name.Contains("CompareParam") || p.Name.Contains("DbType"))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 将Table转化为对应的实体对像数组。
        /// </summary>
        private static T[] ConvertToEntity(DataTable tb)
        {
            T Entity = new T();
            T[] ret = new T[tb.Rows.Count];
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                T tmp = new T();
                foreach (System.Reflection.PropertyInfo p in Entity.GetType().GetProperties())
                {
                    if (CheckReturnEntity(Entity, p))
                    {
                        continue;
                    }
                    if (tb.Rows[i][p.Name.ToLower()].ToString().Trim().Length == 0)
                    {
                        continue;
                    }
                    System.Type tmpType = Entity.GetType().GetProperty(p.Name).PropertyType;
                    switch (tmpType.ToString())
                    {
                        #region 字符串
                        case "System.String":
                            p.SetValue(tmp, tb.Rows[i][p.Name.ToLower()].ToString(), null);
                            break;
                        #endregion

                        #region 整数
                        case "System.Int":
                            p.SetValue(tmp, int.Parse(tb.Rows[i][p.Name.ToLower()].ToString()), null);
                            break;
                        case "System.Int16":
                            p.SetValue(tmp, Int16.Parse(tb.Rows[i][p.Name.ToLower()].ToString()), null);
                            break;
                        case "System.Int32":
                            p.SetValue(tmp, Int32.Parse(tb.Rows[i][p.Name.ToLower()].ToString()), null);
                            break;
                        case "System.Int64":
                            p.SetValue(tmp, Int64.Parse(tb.Rows[i][p.Name.ToLower()].ToString()), null);
                            break;
                        #endregion

                        #region 小数
                        case "System.Single":
                            p.SetValue(tmp, System.Single.Parse(tb.Rows[i][p.Name.ToLower()].ToString()), null);
                            break;
                        case "System.Decimal":
                            p.SetValue(tmp, System.Decimal.Parse(tb.Rows[i][p.Name.ToLower()].ToString()), null);
                            break;
                        case "System.Double":
                            p.SetValue(tmp, System.Double.Parse(tb.Rows[i][p.Name.ToLower()].ToString()), null);
                            break;
                        #endregion

                        #region 字节，字节数组
                        case "System.Byte":
                            p.SetValue(tmp, System.Byte.Parse(tb.Rows[i][p.Name.ToLower()].ToString()), null);
                            break;
                        case "System.Byte[]":
                            break;
                        #endregion

                        #region Boolean
                        case "System.Boolean":
                            p.SetValue(tmp, System.Boolean.Parse(tb.Rows[i][p.Name.ToLower()].ToString()), null);
                            break;
                        #endregion

                        #region 日期
                        case "System.DateTime":
                            p.SetValue(tmp, System.DateTime.Parse(tb.Rows[i][p.Name.ToLower()].ToString()), null);
                            break;
                        #endregion

                        #region Guid
                        case "System.Guid":
                            p.SetValue(tmp, tb.Rows[i][p.Name.ToLower()].ToString(), null);
                            //p.SetValue(tmp, System.Guid.Parse(tb.Rows[i][p.Name.ToLower()].ToString()), null);
                            break;
                        #endregion

                        #region 对象
                        case "System.Object":
                            break;
                        #endregion

                        default:
                            break;
                    }
                }
                ret[i] = tmp;
            }
            return ret;
        }

        /// <summary>
        /// 以传入实体对象为，按自定排序条件，生成参数化的Select的语句。
        /// 注：1 cmdParam为传出参数。
        ///     2 OrderBy字符串省略“order by”关键字。
        /// </summary>
        private static string BuildSelectSql(T Entity, string OrderBy, out SqlParameter[] cmdParam)
        {
            List<SqlParameter> ParamList = new List<SqlParameter>();
            StringBuilder SelectSql = new StringBuilder("Select * From [" + typeof(T).Name.Replace("Entity", "") + "] Where ");
            //构造Select语句Where条件

            foreach (System.Reflection.PropertyInfo p in Entity.GetType().GetProperties())
            {
                //忽略值为默认值的属性字段
                if (CheckQueryEntity(Entity, p))
                {
                    continue;
                }
                //有些字段需要特殊处理
                SelectSql.Append(BuidWhereItemStr(Entity, p, ""));
                SqlParameter SqlParam = new SqlParameter("@" + p.Name, p.GetValue(Entity, null));
                if (SqlParam != null)
                {
                    ParamList.Add(SqlParam);
                }
            }
            SelectSql = new StringBuilder(SelectSql.ToString().Substring(0, SelectSql.ToString().LastIndexOf("and")));
            //参数化
            cmdParam = new SqlParameter[ParamList.Count];
            for (int i = 0; i < ParamList.Count; i++)
            {
                cmdParam[i] = ParamList[i];
            }
            //按主键排序
            if (OrderBy != null && OrderBy.Length > 0)
            {
                //使用参数传入的值
                SelectSql.Append(" order by " + OrderBy);
            }
            else
            {
                //按主键构造
                OrderBy = GetPrimaryKeyOrderByDesc();
                if (OrderBy != null && OrderBy.Length > 0)
                {
                    SelectSql.Append(" order by " + OrderBy);
                }
            }
            //提交语句给数据库执行?
            return SelectSql.ToString();
        }

        /// <summary>
        /// 反选由函数BuildSelectSql产生的语句，返回一个DataTable对象。如果PageInfo不为空，则将BuildSelectSql产生的语句
        /// 再次按PageInfo的条件转化后执行返回结果集。
        /// 注：1 OrderBy字符串省略“order by”关键字。
        ///     2 此函数实际是BuildSelectSql函数的壳。以处理有分页要求的情况。
        /// </summary>
        private static DataTable ExecuteSelectSql(T Entity, string OrderBy, PageInfo pageinfo)
        {
            SqlParameter[] cmdParam;
            string sql = BuildSelectSql(Entity, OrderBy, out cmdParam);
            if (pageinfo == null)
            {
                return DbHelperSQL.Query(sql, cmdParam).Tables[0];
            }
            else
            {
                string RetSql = BuildSelectWithPage(sql, pageinfo, cmdParam);
                return DbHelperSQL.Query(RetSql, cmdParam).Tables[0];
            }
        }

        /// <summary>
        ///  以传入对象为条件，生成更新语句并执行，返回影响的行数。
        ///  注:按传入对象的主键更新。
        /// </summary>
        private static int BuildUpdateSql(T Entity)
        {
            //构造更新字段
            List<SqlParameter> ParamList = new List<SqlParameter>();
            StringBuilder UpdateSql = new StringBuilder("update [" + typeof(T).Name.Replace("Entity", "") + "] set ");
            bool Exit = true;
            foreach (System.Reflection.PropertyInfo p in Entity.GetType().GetProperties())
            {
                string UpdateSetItemStr = BuildUpdateSetItemStr(Entity, p);
                if (UpdateSetItemStr != null && UpdateSetItemStr != string.Empty)
                {
                    UpdateSql.Append(UpdateSetItemStr);
                    SqlParameter SqlParam = new SqlParameter("@" + p.Name, p.GetValue(Entity, null));
                    ParamList.Add(SqlParam);
                    Exit = false;
                }
            }
            if (Exit)
            {
                return -1;
            }
            UpdateSql = new StringBuilder(UpdateSql.ToString().Substring(0, UpdateSql.ToString().LastIndexOf(",")));

            //构造Where条件
            List<PropertyInfo> PrimaryKeys = Entity.GetPrimaryKeys();
            if (PrimaryKeys == null || PrimaryKeys.Count == 0)
            {
                //无主键，禁止更新。
                return -1;
            }

            //构造where
            SqlParameter[] WhereParam = new SqlParameter[PrimaryKeys.Count];
            UpdateSql.Append(BuildWherePrimaryStr(Entity, out WhereParam));
            foreach (SqlParameter Param in WhereParam)
            {
                if (Param != null)
                {
                    ParamList.Add(Param);
                }
            }

            SqlParameter[] cmdParam = new SqlParameter[ParamList.Count];
            for (int i = 0; i < ParamList.Count; i++)
            {
                cmdParam[i] = ParamList[i];
            }
            return DbHelperSQL.ExecuteSql(UpdateSql.ToString(), cmdParam);
        }

        /// <summary>
        /// 将传入对象按Where对象为条件更新到持久化到数据库，返回受影响的行数。
        /// 注：不推荐使用。
        /// </summary>
        private static int BuildUpdateSql(T Entity, T Where)
        {
            //构造更新字段
            List<SqlParameter> ParamList = new List<SqlParameter>();
            StringBuilder UpdateSql = new StringBuilder("update [" + typeof(T).Name.Replace("Entity", "") + "] set ");
            bool Exit = true;
            foreach (System.Reflection.PropertyInfo p in Entity.GetType().GetProperties())
            {
                string UpdateSetItemStr = BuildUpdateSetItemStr(Entity, p);
                if (UpdateSetItemStr != null && UpdateSetItemStr != string.Empty)
                {
                    UpdateSql.Append(UpdateSetItemStr);
                    SqlParameter SqlParam = new SqlParameter("@" + p.Name, p.GetValue(Entity, null));
                    ParamList.Add(SqlParam);
                    Exit = false;
                }
            }
            if (Exit)
            {
                return -3;
            }
            UpdateSql = new StringBuilder(UpdateSql.ToString().Substring(0, UpdateSql.ToString().LastIndexOf(",")));

            //构造Where条件
            UpdateSql.Append(" where ");
            bool ExitSign = true;
            foreach (System.Reflection.PropertyInfo p in Where.GetType().GetProperties())
            {
                if (CheckQueryEntity(Where, p))
                {
                    //只能是字段属性且值被改变过
                    continue;
                }
                //有些字段需要特殊处理
                UpdateSql.Append(BuidWhereItemStr(Where, p, "where"));
                SqlParameter SqlParam = new SqlParameter("@" + "where" + p.Name, p.GetValue(Where, null));
                ParamList.Add(SqlParam);
                ExitSign = false;
            }
            if (ExitSign)
            {
                //where条件为空，禁止更新。
                return -2;
            }
            UpdateSql = new StringBuilder(UpdateSql.ToString().Substring(0, UpdateSql.ToString().LastIndexOf("and")));

            SqlParameter[] cmdParam = new SqlParameter[ParamList.Count];
            for (int i = 0; i < ParamList.Count; i++)
            {
                cmdParam[i] = ParamList[i];
            }
            return DbHelperSQL.ExecuteSql(UpdateSql.ToString(), cmdParam);
        }

        /// <summary>
        /// 将传入对象插入到数据库，返回插入后的主键值。
        /// </summary>
        private static int BuildInsertSql(T Entity)
        {
            List<SqlParameter> ParamList = new List<SqlParameter>();
            string InsertSql = "Insert into  [" + typeof(T).Name.Replace("Entity", "") + "] ( {0} ) values ( {1} )";
            StringBuilder ColumnSql = new StringBuilder();
            StringBuilder VauleSql = new StringBuilder();

            foreach (System.Reflection.PropertyInfo p in Entity.GetType().GetProperties())
            {
                BuidInsertItemStr(Entity, p, ref ColumnSql, ref VauleSql, ref ParamList);
            }
            ColumnSql = new StringBuilder(ColumnSql.ToString().Substring(0, ColumnSql.ToString().LastIndexOf(",")));
            VauleSql = new StringBuilder(VauleSql.ToString().Substring(0, VauleSql.ToString().LastIndexOf(",")));

            InsertSql = string.Format(InsertSql, ColumnSql, VauleSql);
            InsertSql += "; select @@identity;";

            SqlParameter[] cmdParam = new SqlParameter[ParamList.Count];
            for (int i = 0; i < ParamList.Count; i++)
            {
                cmdParam[i] = ParamList[i];
            }
            return DbHelperSQL.ExecuteSqlScalar(InsertSql, cmdParam);
        }

        /// <summary>
        /// 将传入对象从数据库持久删除。返回受影响的行。
        /// 注：主键不能为空，实际以主键为条件删除。
        /// </summary>
        private static int BuildDeleteSql(T Entity)
        {
            StringBuilder DeleteSql = new StringBuilder("Delete From [" + typeof(T).Name.Replace("Entity", "") + "] ");
            List<PropertyInfo> PrimaryKeys = Entity.GetPrimaryKeys();
            if (PrimaryKeys == null)
            {
                return 0;
            }
            SqlParameter[] ParamList;
            DeleteSql.Append(BuildWherePrimaryStr(Entity, out ParamList));
            return DbHelperSQL.ExecuteSql(DeleteSql.ToString(), ParamList);
        }

        /// <summary>
        /// 按传入对象的主键为条件生成Where子句。
        /// </summary>
        private static string BuildWherePrimaryStr(T Entity, out SqlParameter[] ParamList)
        {
            StringBuilder WhereSql = new StringBuilder(" where ");
            List<PropertyInfo> PrimaryKeys = Entity.GetPrimaryKeys();
            if (PrimaryKeys == null)
            {
                ParamList = null;
                return null;
            }
            ParamList = new SqlParameter[PrimaryKeys.Count];
            for (int i = 0; i < PrimaryKeys.Count; i++)
            {
                WhereSql.Append(BuidWhereItemStr(Entity, PrimaryKeys[i], "Where"));
                ParamList[i] = new SqlParameter("@Where" + PrimaryKeys[i].Name, PrimaryKeys[i].GetValue(Entity, null));
            }
            WhereSql = new StringBuilder(WhereSql.ToString().Substring(0, WhereSql.ToString().LastIndexOf("and")));
            return WhereSql.ToString();
        }

        /// <summary>
        /// 按传入对象全部字段为穿件生成Where子句。
        /// </summary>
        private static string BuidWhereItemStr(T Where, PropertyInfo p, string Prefix)
        {
            StringBuilder WhereItemStr = new StringBuilder();
            switch (Where.GetType().GetProperty(p.Name + "DbType").GetValue(Where, null).ToString())
            {
                case "text":
                case "ntext":
                    WhereItemStr.Append("cast([" + p.Name + "] as varchar(1000))" + GetOperator(Where, p) + "@" + Prefix + p.Name + " and ");
                    break;
                case "xml":
                    //暂时不支持XML类型作为查询条件
                    WhereItemStr.Append("cast([" + p.Name + "] as varchar(max))" + GetOperator(Where, p) + "@" + Prefix + p.Name + " and ");
                    break;
                case "image":
                    //暂时不支持image类型作为查询条件
                    WhereItemStr.Append("cast([" + p.Name + "] as binary)" + GetOperator(Where, p) + "@" + Prefix + p.Name + " and ");
                    break;
                default:
                    WhereItemStr.Append(p.Name + GetOperator(Where, p) + "@" + Prefix + p.Name + " and ");
                    break;
            }
            return WhereItemStr.ToString();
        }

        /// <summary>
        /// 参照传入对象生成参数化的Insert语句。
        /// </summary>
        private static void BuidInsertItemStr(T Entity, PropertyInfo p, ref StringBuilder ColumnSql, ref StringBuilder VauleSql, ref  List<SqlParameter> ParamList)
        {
            if (CheckQueryEntity(Entity, p))
            {
                //只能是字段属性且值被改变过
                return;
            }
            switch (Entity.GetType().GetProperty(p.Name + "DbType").GetValue(Entity, null).ToString())
            {
                case "timestamp":
                    //时间戳不允许插入
                    break;
                default:
                    ColumnSql.Append(p.Name + ",");
                    VauleSql.Append("@" + p.Name + ",");
                    ParamList.Add(new SqlParameter("@" + p.Name, p.GetValue(Entity, null)));
                    break;
            }
        }

        /// <summary>
        /// 生成传入对象对应属性的update语句set子项 
        /// </summary>
        private static string BuildUpdateSetItemStr(T Entity, PropertyInfo p)
        {
            string UpdateItemSql = string.Empty;
            if (CheckQueryEntity(Entity, p) || IsPrimaryKey(Entity, p))
            {
                //只能是字段属性且值被改变过,且主键不能更新
                return null;
            }
            switch (Entity.GetType().GetProperty(p.Name + "DbType").GetValue(Entity, null).ToString())
            {
                case "timestamp":
                    //时间戳不允许更新
                    break;
                default:
                    UpdateItemSql = p.Name + "=@" + p.Name + ",";
                    break;
            }
            return UpdateItemSql;
        }

        /// <summary>
        /// 将传入SQL语句按PageInfo对象生成Select分页语句。并填充相关信息到PageInfo对象。
        /// 注：1 SQL必须是Select语句。
        ///     2 必须有Order By子句。
        /// </summary>
        private static string BuildSelectWithPage(string sql, PageInfo pageinfo, SqlParameter[] cmdParam)
        {
            int PageSize = pageinfo.PageSize;
            int PageNum = pageinfo.CurrentPage;

            string OrderBy = sql.Substring(sql.ToLower().IndexOf("order by"));
            string SelectSql = sql.Substring(0, sql.ToLower().IndexOf("order by"));
            string sb = "select * from ( select row_number() over ({0}) as rowid,* from ({1}) t )t where t.rowid>={2} and t.rowid<={3}";
            string ret = string.Format(sb.ToString(), OrderBy, SelectSql, PageSize * (PageNum - 1) + 1, PageNum * PageSize);

            //计算分页信息。
            string SelectCountSql = SelectSql.Replace("*", "count(*)");
            pageinfo.TotalRecords = (int)DbHelperSQL.ExecuteSqlScalar(SelectCountSql, cmdParam);
            pageinfo.CalculatePages();

            return ret;
        }


        /// <summary>
        /// 判断传入对象是否已存在于数据库。
        /// </summary>
        public static bool IsExsist(T Entity)
        {
            List<PropertyInfo> KeyList = Entity.GetPrimaryKeys();
            T QueryParam = new T();
            bool sign = true;
            foreach (PropertyInfo p in KeyList)
            {
                if (!CheckQueryEntity(Entity, p))
                {
                    p.SetValue(QueryParam, p.GetValue(Entity, null), null);
                    sign = false;
                }
            }
            if (sign)
            {
                return false;
            }
            T[] RetList = SelectEntitiesByEntityCondition(QueryParam);
            if (RetList != null && RetList.Length == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 以传入对象的主键作为条件查询数据。
        /// </summary>
        public static T QueryWithPrimaryKey(T Entity)
        {
            List<PropertyInfo> KeyList = Entity.GetPrimaryKeys();
            T QueryParam = new T();
            bool sign = true;
            foreach (PropertyInfo p in KeyList)
            {
                if (!CheckQueryEntity(Entity, p))
                {
                    p.SetValue(QueryParam, p.GetValue(Entity, null), null);
                    sign = false;
                }
            }
            if (sign)
            {
                return default(T);
            }
            T[] RetList = SelectEntitiesByEntityCondition(QueryParam);
            if (RetList != null && RetList.Length == 1)
            {
                return RetList[0];
            }
            else
            {
                return default(T);
            }
        }

        #endregion

        #region 扩展方法
        /// <summary>
        /// 执行sql，返回一个DataTable对象。如果PageInfo不为空，则将BuildSelectWithPage产生的语句
        /// 按PageInfo的条件转化后执行返回结果集。
        /// 注：1 sql语句一定要包含“order by”关键字。
        /// </summary>
        public static DataTable ExecuteMultiTablesSelectSql(string sql, PageInfo pageinfo, SqlParameter[] cmdParam)
        {
            if (pageinfo == null)
            {
                return DbHelperSQL.Query(sql, cmdParam).Tables[0];
            }
            else
            {
                string RetSql = DbHelperSQL.BuildSelectWithPage(sql, pageinfo, cmdParam);
                return DbHelperSQL.Query(RetSql, cmdParam).Tables[0];
            }
        }
        #endregion
    }

}
