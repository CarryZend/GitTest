using System;
using System.Collections;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;
using System.Collections.Generic;
using Eagle.Config;

namespace Eagle.DBUtility
{
    /// <summary>
    /// 数据访问抽象基础类
    /// </summary>
    public abstract class DbHelperSQL
    {

        /// <summary>
        /// 数据库连接字符串(web.config来配置)，可以动态更改connectionString支持多数据库.	
        /// </summary>	
        public static string ConnectionString = BaseConfigs.GetDBConnectString;

        /// <summary>
        /// 默认构造函数,如果有子类继承，则在子类实例化时会调用本构造函数。
        /// 本框架无任何子类继承本类。
        /// </summary>
        public DbHelperSQL()
        {

        }

        #region 基础方法

        /// <summary>
        /// 判断某个字段(列)是否存在于某表中。
        /// </summary>
        /// <param name="tableName">表名称</param>
        /// <param name="columnName">字段(列)名称</param>
        /// <returns>是否存在</returns>
        public static bool ColumnExists(string tableName, string columnName)
        {
            /*构建查询语句 统计列总和*/
            string sql = string.Format("select count(1) from syscolumns where [id]=object_id('{0}') and [name]='{1}'", tableName, columnName);
            /*执行查询*/
            object res = ExecuteScalar(sql);
            /*结果为空的情况*/
            if (res == null)
            {
                return false;
            }
            /*不为空，判断结果是否大于0*/
            return Convert.ToInt32(res) > 0;
        }

        /// <summary>
        /// 获取某个表某个列（可加运算）的最大值加 1
        /// Select Max(ID) +1 From TableName
        /// </summary>
        /// <param name="FieldName">列名称</param>
        /// <param name="TableName">表名称</param>
        /// <returns></returns>
        public static int GetMaxID(string FieldName, string TableName)
        {
            /*构造查询语句*/
            string sql = string.Format("select max({0})+1 from {1}", FieldName, TableName);
            /*执行查询语句*/
            object obj = ExecuteScalar(sql);
            /*结果为空返回1*/
            if (obj == null)
            {
                return 1;
            }
            /*不为空，返回实际值*/
            return int.Parse(obj.ToString());
        }

        /// <summary>
        /// 执行一条查询语句，判断返回的第一行第一列是否为0。
        /// 传入sql语句往往带count(*)来判断是否存在数据行。
        /// 非0返回true,0返回false.
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static bool Exists(string sql)
        {
            /*执行查询语句，返回结果*/
            object obj = ExecuteScalar(sql);
            /*定义结果临时变量*/
            int cmdresult;
            /*为空或者DBNull的情况*/
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
            {
                cmdresult = 0;
            }
            else
            {
                cmdresult = int.Parse(obj.ToString());
            }
            /*0返回false,非0返回真。*/
            if (cmdresult == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 执行一条查询语句，判断返回的第一行第一列是否为0。
        /// 传入sql语句往往带count(*)来判断是否存在数据行。
        /// 非0返回true,0返回false.
        /// </summary>
        /// <param name="sql">查询语句</param>
        /// <param name="cmdParms">参数</param>
        /// <returns>是否存在</returns>
        public static bool Exists(string sql, params SqlParameter[] cmdParms)
        {
            /*执行查询语句，返回结果*/
            object obj = ExecuteScalar(sql, cmdParms);
            /*定义结果临时变量*/
            int cmdresult;
            /*为空或者DBNull的情况*/
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
            {
                cmdresult = 0;
            }
            else
            {
                cmdresult = int.Parse(obj.ToString());
            }
            /*0返回false,非0返回真。*/
            if (cmdresult == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 表是否存在。此方法可优化，方法体可直接调用Exists()方法。
        /// </summary>
        /// <param name="TableName"></param>
        /// <returns></returns>
        public static bool TableExists(string TableName)
        {
            /*构造查询语句 根据SqlServer不同版本，以下语句可能不同*/
            string sql = string.Format("select count(*) from sysobjects where id = object_id(N'[{0}]') and OBJECTPROPERTY(id, N'IsUserTable') = 1", TableName);

            /*执行查询语句*/
            object obj = ExecuteScalar(sql);
            /*查询结果变量*/
            int cmdresult;
            /*判断为null或者DBNull的情况*/
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
            {
                cmdresult = 0;
            }
            else
            {
                cmdresult = int.Parse(obj.ToString());
            }
            /*0返回false,非0返回真。*/
            if (cmdresult == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region  执行简单SQL语句

        /// <summary>
        /// 执行SQL语句，返回受影响的记录数
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns>影响的记录数</returns>
        public static int ExecuteSql(string sql)
        {
            /*创建连接对象*/
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                /*创建SqlCommand对象*/
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    try
                    {
                        /*打开连接*/
                        connection.Open();
                        /*执行语句，返回受影响的行数*/
                        return cmd.ExecuteNonQuery();
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        /*关闭连接*/
                        connection.Close();
                        throw e;
                    }
                }
            }
        }

        /// <summary>
        /// 执行SQL语句，返回受影响的记录数
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="timeout">超时时间</param>
        /// <returns>影响的记录数</returns>
        public static int ExecuteSql(string sql, int timeout)
        {
            /*创建连接对象*/
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                /*创建SqlCommand对象*/
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    try
                    {
                        /*打开连接*/
                        connection.Open();
                        /*设置超时时间*/
                        cmd.CommandTimeout = timeout;
                        /*执行语句，返回受影响的行数*/
                        return cmd.ExecuteNonQuery();
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        /*关闭连接*/
                        connection.Close();
                        throw e;
                    }
                }
            }
        }

        /// <summary>
        /// 执行带一个存储过程参数的的SQL语句。
        /// </summary>
        /// <param name="SQLString">SQL语句</param>
        /// <param name="content">参数内容,比如一个字段是格式复杂的文章，有特殊符号，可以通过这个方式添加</param>
        /// <returns>影响的记录数</returns>
        public static int ExecuteSql(string SQLString, string content)
        {
            /*创建连接对象*/
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                /*创建SqlCommand对象*/
                SqlCommand cmd = new SqlCommand(SQLString, connection);
                /*创建参数*/
                System.Data.SqlClient.SqlParameter myParameter = new System.Data.SqlClient.SqlParameter("@content", SqlDbType.NText);
                myParameter.Value = content;
                cmd.Parameters.Add(myParameter);
                try
                {
                    /*打开连接*/
                    connection.Open();
                    /*执行查询并返回受影响的行*/
                    int rows = cmd.ExecuteNonQuery();
                    return rows;
                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    throw e;
                }
                finally
                {
                    /*销毁对象，关闭连接*/
                    cmd.Dispose();
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// 执行带一个存储过程参数的的SQL语句。
        /// </summary>
        /// <param name="SQLString">SQL语句</param>
        /// <param name="content">参数内容,比如一个字段是格式复杂的文章，有特殊符号，可以通过这个方式添加</param>
        /// <returns>影响的记录数</returns>
        public static object ExecuteSqlGet(string SQLString, string content)
        {
            /*创建连接对象*/
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                /*创建SqlCommand对象*/
                SqlCommand cmd = new SqlCommand(SQLString, connection);
                /*创建参数*/
                System.Data.SqlClient.SqlParameter myParameter = new System.Data.SqlClient.SqlParameter("@content", SqlDbType.NText);
                myParameter.Value = content;
                cmd.Parameters.Add(myParameter);
                try
                {
                    /*打开连接*/
                    connection.Open();
                    /*执行查询并返回第一行第一列*/
                    object obj = cmd.ExecuteScalar();
                    if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                    {
                        return null;
                    }
                    else
                    {
                        return obj;
                    }
                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    throw e;
                }
                finally
                {
                    /*销毁对象，关闭连接*/
                    cmd.Dispose();
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// 执行多条SQL语句，实现数据库事务。
        /// </summary>
        /// <param name="SQLStringList">多条SQL语句</param>		
        public static int ExecuteSqlTran(List<String> SQLStringList)
        {
            /*创建数据库连接*/
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                /*打开连接*/
                connection.Open();
                /*创建SqlCommand对象*/
                SqlCommand cmd = new SqlCommand();
                /*设置连接*/
                cmd.Connection = connection;
                /*开始事务*/
                SqlTransaction tx = connection.BeginTransaction();
                cmd.Transaction = tx;
                try
                {
                    /*计数器*/
                    int count = 0;
                    for (int n = 0; n < SQLStringList.Count; n++)
                    {
                        string strsql = SQLStringList[n];
                        if (strsql.Trim().Length > 1)
                        {
                            cmd.CommandText = strsql;
                            /*执行语句*/
                            count += cmd.ExecuteNonQuery();
                        }
                    }
                    /*提交事务*/
                    tx.Commit();
                    return count;
                }
                catch
                {
                    tx.Rollback();
                    return 0;
                }
            }
        }

        /// <summary>
        /// 执行Sql和Oracle滴混合事务
        /// WhenHaveContine:执行结果大于0继续
        /// WhenNoHaveContine：执行结果等于0继续
        /// SolicitationEvent:执行结果大于0触发事件
        /// </summary>
        /// <param name="list">SQL命令行列表</param>
        /// <param name="oracleCmdSqlList">Oracle命令行列表</param>
        /// <returns>执行结果 0-由于SQL造成事务失败 -1 由于Oracle造成事务失败 1-整体事务执行成功</returns>
        public static int ExecuteSqlTran(List<CommandInfo> list, List<CommandInfo> oracleCmdSqlList)
        {
            /*创建连接对象*/
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                /*打开连接*/
                connection.Open();
                /*创建SqlCommand对象*/
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                /*事务开始*/
                SqlTransaction tx = connection.BeginTransaction();
                cmd.Transaction = tx;
                try
                {
                    /*遍历list中每一个对象*/
                    foreach (CommandInfo myDE in list)
                    {
                        /*获取语句*/
                        string cmdText = myDE.CommandText;
                        /*获取参数*/
                        SqlParameter[] cmdParms = (SqlParameter[])myDE.Parameters;
                        /*设置cmd对象*/
                        PrepareCommand(cmd, connection, tx, cmdText, cmdParms);

                        /*当执行结果大于0时触发事件*/
                        if (myDE.EffentNextType == EffentNextType.SolicitationEvent)
                        {
                            /*检测语句合法性*/
                            if (myDE.CommandText.ToLower().IndexOf("count(") == -1)
                            {
                                tx.Rollback();
                                throw new Exception("违背要求" + myDE.CommandText + "必须符合select count(..的格式");
                            }
                            /*执行语句*/
                            object obj = cmd.ExecuteScalar();
                            /*结果变量(是否有结果)*/
                            bool isHave = false;
                            if (obj == null && obj == DBNull.Value)
                            {
                                isHave = false;
                            }
                            isHave = Convert.ToInt32(obj) > 0;
                            if (isHave)
                            {
                                /*触发事件*/
                                myDE.OnSolicitationEvent();
                            }
                        }

                        if (myDE.EffentNextType == EffentNextType.WhenHaveContine || myDE.EffentNextType == EffentNextType.WhenNoHaveContine)
                        {
                            /*检测语句是否合法*/
                            if (myDE.CommandText.ToLower().IndexOf("count(") == -1)
                            {
                                /*回滚事务*/
                                tx.Rollback();
                                throw new Exception("SQL:违背要求" + myDE.CommandText + "必须符合select count(..的格式");
                            }
                            /*执行语句是否合法*/
                            object obj = cmd.ExecuteScalar();
                            bool isHave = false;
                            if (obj == null && obj == DBNull.Value)
                            {
                                isHave = false;
                            }
                            isHave = Convert.ToInt32(obj) > 0;

                            if (myDE.EffentNextType == EffentNextType.WhenHaveContine && !isHave)
                            {
                                tx.Rollback();
                                throw new Exception("SQL:违背要求" + myDE.CommandText + "返回值必须大于0");
                            }
                            if (myDE.EffentNextType == EffentNextType.WhenNoHaveContine && isHave)
                            {
                                tx.Rollback();
                                throw new Exception("SQL:违背要求" + myDE.CommandText + "返回值必须等于0");
                            }
                            continue;
                        }

                        int val = cmd.ExecuteNonQuery();
                        if (myDE.EffentNextType == EffentNextType.ExcuteEffectRows && val == 0)
                        {
                            tx.Rollback();
                            throw new Exception("SQL:违背要求" + myDE.CommandText + "必须有影响行");
                        }
                        cmd.Parameters.Clear();
                    }
                    string oraConnectionString = PubConstant.GetConnectionString("ConnectionStringPPC");
                    bool res = OracleHelper.ExecuteSqlTran(oraConnectionString, oracleCmdSqlList);
                    if (!res)
                    {
                        tx.Rollback();
                        throw new Exception("Oracle执行失败");
                    }
                    tx.Commit();
                    return 1;
                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    tx.Rollback();
                    throw e;
                }
                catch (Exception e)
                {
                    tx.Rollback();
                    throw e;
                }
            }
        }

        /// <summary>
        /// 向数据库里插入图像格式的字段(和上面情况类似的另一种实例)
        /// </summary>
        /// <param name="strSQL">SQL语句</param>
        /// <param name="fs">图像字节,数据库的字段类型为image的情况</param>
        /// <returns>影响的记录数</returns>
        public static int ExecuteSqlInsertImg(string strSQL, byte[] fs)
        {
            /*创建连接对象*/
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                /*创建SqlCommand对象*/
                SqlCommand cmd = new SqlCommand(strSQL, connection);
                /*创建参数*/
                System.Data.SqlClient.SqlParameter myParameter = new System.Data.SqlClient.SqlParameter("@fs", SqlDbType.Image);
                myParameter.Value = fs;
                cmd.Parameters.Add(myParameter);
                try
                {
                    /*打开连接*/
                    connection.Open();
                    /*执行语句并返回受影响的行*/
                    return cmd.ExecuteNonQuery();
                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    throw e;
                }
                finally
                {
                    /*销毁对象，关闭连接*/
                    cmd.Dispose();
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// 执行一条计算查询语句，并返回第一行第一列（object）。
        /// </summary>
        /// <param name="SqlString">查询语句</param>
        /// <returns>查询结果对象(object)</returns>
        public static object ExecuteScalar(string SqlString)
        {
            /*创建连接对象*/
            using (SqlConnection Connection = new SqlConnection(ConnectionString))
            {
                /*创建SqlCommand对象*/
                using (SqlCommand cmd = new SqlCommand(SqlString, Connection))
                {
                    try
                    {
                        /*打开连接*/
                        Connection.Open();
                        /*执行查询*/
                        object obj = cmd.ExecuteScalar();
                        /*如果返回结果为空或者为DBNull*/
                        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                        {
                            /*返回空*/
                            return null;
                        }
                        else
                        {
                            /*返回执行结果*/
                            return obj;
                        }
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        Connection.Close();
                        throw e;
                    }
                }
            }
        }

        /// <summary>
        /// 执行一条计算查询语句，并返回第一行第一列（object）。
        /// </summary>
        /// <param name="SqlString">查询语句</param>
        /// <param name="Times">超时时间</param>
        /// <returns>查询结果对象(object)</returns>
        public static object ExecuteScalar(string SqlString, int Times)
        {
            /*创建连接对象*/
            using (SqlConnection Connection = new SqlConnection(ConnectionString))
            {
                /*创建SqlCommand对象*/
                using (SqlCommand cmd = new SqlCommand(SqlString, Connection))
                {
                    try
                    {
                        /*打开连接*/
                        Connection.Open();
                        /*设置超时时间*/
                        cmd.CommandTimeout = Times;
                        /*执行查询*/
                        object obj = cmd.ExecuteScalar();
                        /*如果返回结果为空或者为DBNull*/
                        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                        {
                            /*返回空*/
                            return null;
                        }
                        else
                        {
                            /*返回执行结果*/
                            return obj;
                        }
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        Connection.Close();
                        throw e;
                    }
                }
            }
        }

        /// <summary>
        /// 执行一条计算查询结果语句，返回查询结果（object）。
        /// </summary>
        /// <param name="sql">查询结果语句</param>
        /// <returns>查询结果（object）</returns>
        public static object ExecuteScalar(string sql, params SqlParameter[] cmdParms)
        {
            /*创建连接对象*/
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                /*创建SqlCommand对象*/
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        /*初始化*/
                        PrepareCommand(cmd, connection, null, sql, cmdParms);
                        /*执行查询*/
                        object obj = cmd.ExecuteScalar();
                        /*清空参数*/
                        cmd.Parameters.Clear();
                        /*返回结果*/
                        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                        {
                            return null;
                        }
                        else
                        {
                            return obj;
                        }
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        throw e;
                    }
                }
            }
        }

        /// <summary>
        /// 执行查询语句，返回SqlDataReader ( 注意：调用该方法后，一定要对SqlDataReader进行Close )
        /// </summary>
        /// <param name="strSQL">查询语句</param>
        /// <returns>SqlDataReader</returns>
        public static SqlDataReader ExecuteReader(string strSQL)
        {
            /*创建连接对象*/
            SqlConnection connection = new SqlConnection(ConnectionString);
            /*创建SqlCommand对象*/
            SqlCommand cmd = new SqlCommand(strSQL, connection);
            try
            {
                /*打开连接*/
                connection.Open();
                /*执行ExecuteReader*/
                SqlDataReader myReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return myReader;
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 执行查询语句，返回DataSet
        /// </summary>
        /// <param name="sql">查询语句</param>
        /// <returns>DataSet</returns>
        public static DataSet Query(string sql)
        {
            /*创建连接*/
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                /*创建ds*/
                DataSet ds = new DataSet();
                try
                {
                    /*打开连接*/
                    connection.Open();
                    /*创建适配器*/
                    SqlDataAdapter command = new SqlDataAdapter(sql, connection);
                    /*填充DataSet*/
                    command.Fill(ds, "ds");
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                return ds;
            }
        }

        /// <summary>
        /// 执行查询语句，返回DataSet
        /// </summary>
        /// <param name="sql">查询语句</param>
        /// <param name="timeout">超时时间</param>
        /// <returns>DataSet</returns>
        public static DataSet Query(string sql, int timeout)
        {
            /*创建连接*/
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                /*创建ds*/
                DataSet ds = new DataSet();
                try
                {
                    /*打开连接*/
                    connection.Open();
                    /*创建适配器*/
                    SqlDataAdapter command = new SqlDataAdapter(sql, connection);
                    /*设置超时时间*/
                    command.SelectCommand.CommandTimeout = timeout;
                    /*填充DataSet*/
                    command.Fill(ds, "ds");
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                return ds;
            }
        }
        #endregion

        #region 执行带参数的SQL语句

        /// <summary>
        /// 将传入SQL语句按PageInfo对象生成Select分页语句。并填充相关信息到PageInfo对象。
        /// 注：1 SQL必须是Select语句。
        ///     2 必须有Order By子句。
        /// </summary>
        public static string BuildSelectWithPage(string sql, PageInfo pageinfo, SqlParameter[] cmdParam)
        {
            /*页大小*/
            int PageSize = pageinfo.PageSize;
            /*当前页码*/
            int PageNum = pageinfo.CurrentPage;
            /*获取排序字段*/
            string OrderBy = sql.Substring(sql.ToLower().IndexOf("order by"));
            /*获取select语句*/
            string SelectSql = sql.Substring(0, sql.ToLower().IndexOf("order by"));
            /*重构语句*/
            string sb = "select * from ( select row_number() over ({0}) as rowid,* from ({1}) t )t where t.rowid>={2} and t.rowid<={3}";
            string ret = string.Format(sb.ToString(), OrderBy, SelectSql, PageSize * (PageNum - 1) + 1, PageNum * PageSize);
            /*计算总记录数*/
            string SelectCountSql = string.Format("select count(*) from ({0}) t", SelectSql);
            pageinfo.TotalRecords = (int)DbHelperSQL.ExecuteSqlScalar(SelectCountSql, cmdParam);
            pageinfo.CalculatePages();
            return ret;
        }

        /// <summary>
        /// 执行SQL语句，返回影响的记录数
        /// </summary>
        /// <param name="SQLString">SQL语句</param>
        /// <returns>影响的记录数</returns>
        public static int ExecuteSql(string SQLString, params SqlParameter[] cmdParms)
        {
            /*创建连接对象*/
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                /*创建SqlCommand对象*/
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        /*初始化*/
                        PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                        /*执行语句,返回受影响的行*/
                        int rows = cmd.ExecuteNonQuery();
                        /*清除参数*/
                        cmd.Parameters.Clear();
                        return rows;
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        throw e;
                    }
                }
            }
        }

        /// <summary>
        /// 执行带参数的sql语句，并返回结果集的第一行第一列（整数）
        /// </summary>
        /// <param name="SQLString"></param>
        /// <param name="cmdParms"></param>
        /// <returns></returns>
        public static int ExecuteSqlScalar(string SQLString, params SqlParameter[] cmdParms)
        {
            /*创建连接对象*/
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                /*创建SqlCommand对象*/
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        /*初始化参数*/
                        PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                        /*执行语句，并将结果集第一行第一列转化为整返回*/
                        int rows = int.Parse(cmd.ExecuteScalar().ToString());
                        /*清除参数*/
                        cmd.Parameters.Clear();
                        return rows;
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        throw e;
                    }
                }
            }
        }

        /// <summary>
        /// 执行多条SQL语句，实现数据库事务。
        /// </summary>
        /// <param name="SQLStringList">SQL语句的哈希表（key为sql语句，value是该语句的SqlParameter[]）</param>
        public static void ExecuteSqlTran(Hashtable SQLStringList)
        {
            /*创建连接对象*/
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                /*打开连接*/
                connection.Open();
                /*事务开始*/
                using (SqlTransaction trans = connection.BeginTransaction())
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        try
                        {
                            /*循环*/
                            foreach (DictionaryEntry Entry in SQLStringList)
                            {
                                /*获取sql语句*/
                                string cmdText = Entry.Key.ToString();
                                /*获取参数*/
                                SqlParameter[] cmdParms = (SqlParameter[])Entry.Value;
                                /*初始化*/
                                PrepareCommand(cmd, connection, trans, cmdText, cmdParms);
                                /*执行语句，返回受影响的行*/
                                int val = cmd.ExecuteNonQuery();
                                /*清除参数*/
                                cmd.Parameters.Clear();
                            }
                            /*提交事务*/
                            trans.Commit();
                        }
                        catch
                        {
                            /*回滚事务*/
                            trans.Rollback();
                            throw;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 执行多条SQL语句，实现数据库事务。
        /// </summary>
        /// <param name="SQLStringList">SQL语句的哈希表（key为sql语句，value是该语句的SqlParameter[]）</param>
        public static int ExecuteSqlTran(System.Collections.Generic.List<CommandInfo> cmdList)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    SqlCommand cmd = new SqlCommand();
                    try
                    {
                        int count = 0;
                        //循环
                        foreach (CommandInfo myDE in cmdList)
                        {
                            string cmdText = myDE.CommandText;
                            SqlParameter[] cmdParms = (SqlParameter[])myDE.Parameters;
                            PrepareCommand(cmd, conn, trans, cmdText, cmdParms);

                            if (myDE.EffentNextType == EffentNextType.WhenHaveContine || myDE.EffentNextType == EffentNextType.WhenNoHaveContine)
                            {
                                if (myDE.CommandText.ToLower().IndexOf("count(") == -1)
                                {
                                    trans.Rollback();
                                    return 0;
                                }

                                object obj = cmd.ExecuteScalar();
                                bool isHave = false;
                                if (obj == null && obj == DBNull.Value)
                                {
                                    isHave = false;
                                }
                                isHave = Convert.ToInt32(obj) > 0;

                                if (myDE.EffentNextType == EffentNextType.WhenHaveContine && !isHave)
                                {
                                    trans.Rollback();
                                    return 0;
                                }
                                if (myDE.EffentNextType == EffentNextType.WhenNoHaveContine && isHave)
                                {
                                    trans.Rollback();
                                    return 0;
                                }
                                continue;
                            }
                            int val = cmd.ExecuteNonQuery();
                            count += val;
                            if (myDE.EffentNextType == EffentNextType.ExcuteEffectRows && val == 0)
                            {
                                trans.Rollback();
                                return 0;
                            }
                            cmd.Parameters.Clear();
                        }
                        trans.Commit();
                        return count;
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }

        /// <summary>
        /// 执行多条SQL语句，实现数据库事务。
        /// </summary>
        /// <param name="SQLStringList">SQL语句的哈希表（key为sql语句，value是该语句的SqlParameter[]）</param>
        public static void ExecuteSqlTranWithIndentity(System.Collections.Generic.List<CommandInfo> SQLStringList)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    SqlCommand cmd = new SqlCommand();
                    try
                    {
                        int indentity = 0;
                        //循环
                        foreach (CommandInfo myDE in SQLStringList)
                        {
                            string cmdText = myDE.CommandText;
                            SqlParameter[] cmdParms = (SqlParameter[])myDE.Parameters;
                            foreach (SqlParameter q in cmdParms)
                            {
                                if (q.Direction == ParameterDirection.InputOutput)
                                {
                                    q.Value = indentity;
                                }
                            }
                            PrepareCommand(cmd, conn, trans, cmdText, cmdParms);
                            int val = cmd.ExecuteNonQuery();
                            foreach (SqlParameter q in cmdParms)
                            {
                                if (q.Direction == ParameterDirection.Output)
                                {
                                    indentity = Convert.ToInt32(q.Value);
                                }
                            }
                            cmd.Parameters.Clear();
                        }
                        trans.Commit();
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }

        /// <summary>
        /// 执行多条SQL语句，实现数据库事务。
        /// </summary>
        /// <param name="SQLStringList">SQL语句的哈希表（key为sql语句，value是该语句的SqlParameter[]）</param>
        public static void ExecuteSqlTranWithIndentity(Hashtable SQLStringList)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    SqlCommand cmd = new SqlCommand();
                    try
                    {
                        int indentity = 0;
                        //循环
                        foreach (DictionaryEntry myDE in SQLStringList)
                        {
                            string cmdText = myDE.Key.ToString();
                            SqlParameter[] cmdParms = (SqlParameter[])myDE.Value;
                            foreach (SqlParameter q in cmdParms)
                            {
                                if (q.Direction == ParameterDirection.InputOutput)
                                {
                                    q.Value = indentity;
                                }
                            }
                            PrepareCommand(cmd, conn, trans, cmdText, cmdParms);
                            int val = cmd.ExecuteNonQuery();
                            foreach (SqlParameter q in cmdParms)
                            {
                                if (q.Direction == ParameterDirection.Output)
                                {
                                    indentity = Convert.ToInt32(q.Value);
                                }
                            }
                            cmd.Parameters.Clear();
                        }
                        trans.Commit();
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }

        /// <summary>
        /// 执行查询语句，返回SqlDataReader ( 注意：调用该方法后，一定要对SqlDataReader进行Close )
        /// </summary>
        /// <param name="strSQL">查询语句</param>
        /// <returns>SqlDataReader</returns>
        public static SqlDataReader ExecuteReader(string SQLString, params SqlParameter[] cmdParms)
        {
            /*创建连接对象*/
            SqlConnection connection = new SqlConnection(ConnectionString);
            /*创建SqlCommand对象*/
            using (SqlCommand cmd = new SqlCommand())
            {
                try
                {
                    /*初始化*/
                    PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                    /*创建SqlDataReader对象*/
                    SqlDataReader myReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    cmd.Parameters.Clear();
                    return myReader;
                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    throw e;
                }
            }
        }

        /// <summary>
        /// 执行查询语句，返回DataSet
        /// </summary>
        /// <param name="SQLString">查询语句</param>
        /// <returns>DataSet</returns>
        public static DataSet Query(string SQLString, params SqlParameter[] cmdParms)
        {
            /*创建连接对象*/
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                /*创建SqlCommand对象*/
                using (SqlCommand cmd = new SqlCommand())
                {
                    /*初始化*/
                    PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                    /*创建适配器*/
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        /*创建DataSet*/
                        DataSet ds = new DataSet();
                        try
                        {
                            /*填充DataSet*/
                            da.Fill(ds, "ds");
                            /*清除参数*/
                            cmd.Parameters.Clear();
                        }
                        catch (System.Data.SqlClient.SqlException ex)
                        {
                            throw new Exception(ex.Message);
                        }
                        return ds;
                    }
                }
            }
        }

        /// <summary>
        /// 初始化cmd对象
        /// </summary>
        /// <param name="cmd">SqlCommand</param>
        /// <param name="conn">SqlConnection</param>
        /// <param name="trans">trans</param>
        /// <param name="cmdText">cmdText</param>
        /// <param name="cmdParms">SqlParameter[]</param>
        private static void PrepareCommand(SqlCommand cmd, SqlConnection conn, SqlTransaction trans, string cmdText, SqlParameter[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            if (trans != null)
                cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;
            if (cmdParms != null)
            {
                foreach (SqlParameter parameter in cmdParms)
                {
                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) && (parameter.Value == null))
                    {
                        parameter.Value = DBNull.Value;
                    }
                    cmd.Parameters.Add(parameter);
                }
            }
        }

        #endregion

        #region 存储过程操作

        /// <summary>
        /// 执行存储过程，返回SqlDataReader ( 注意：调用该方法后，一定要对SqlDataReader进行Close )
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <returns>SqlDataReader</returns>
        public static SqlDataReader RunProcedure(string storedProcName, IDataParameter[] parameters)
        {
            /*创建连接对象*/
            SqlConnection connection = new SqlConnection(ConnectionString);
            /*打开连接*/
            connection.Open();
            /*创建SqlCommand对象*/
            SqlCommand command = BuildQueryCommand(connection, storedProcName, parameters);
            command.CommandType = CommandType.StoredProcedure;
            /*执行ExecuteReader方法*/
            SqlDataReader returnReader = command.ExecuteReader(CommandBehavior.CloseConnection);
            return returnReader;
        }

        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <param name="tableName">DataSet结果中的表名</param>
        /// <returns>DataSet</returns>
        public static DataSet RunProcedure(string storedProcName, IDataParameter[] parameters, string tableName)
        {
            /*创建连接对象*/
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                /*创建dataSet*/
                DataSet dataSet = new DataSet();
                /*打开连接*/
                connection.Open();
                /*创建适配器*/
                using (SqlDataAdapter sqladapter = new SqlDataAdapter())
                {
                    sqladapter.SelectCommand = BuildQueryCommand(connection, storedProcName, parameters);
                    /*填充*/
                    sqladapter.Fill(dataSet, tableName);
                    return dataSet;
                }
            }
        }

        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <param name="tableName">DataSet结果中的表名</param>
        /// <param name="timeout">超时时间</param>
        /// <returns></returns>
        public static DataSet RunProcedure(string storedProcName, IDataParameter[] parameters, string tableName, int timeout)
        {
            /*创建连接对象*/
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                /*创建dataSet*/
                DataSet dataSet = new DataSet();
                /*打开连接*/
                connection.Open();
                /*创建适配器*/
                using (SqlDataAdapter sqladapter = new SqlDataAdapter())
                {
                    sqladapter.SelectCommand = BuildQueryCommand(connection, storedProcName, parameters);
                    /*设置超时时间*/
                    sqladapter.SelectCommand.CommandTimeout = timeout;
                    /*填充*/
                    sqladapter.Fill(dataSet, tableName);
                    return dataSet;
                }
            }
        }

        /// <summary>
        /// 执行存储过程，返回影响的行数		
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <param name="rowsAffected">影响的行数</param>
        /// <returns></returns>
        public static int RunProcedure(string storedProcName, IDataParameter[] parameters, out int rowsAffected)
        {
            /*创建连接对象*/
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                /*打开连接*/
                connection.Open();
                /*创建SqlCommand对象*/
                using (SqlCommand command = BuildIntCommand(connection, storedProcName, parameters))
                {
                    rowsAffected = command.ExecuteNonQuery();
                    return (int)command.Parameters["ReturnValue"].Value;
                }
            }
        }

        /// <summary>
        /// 构建 SqlCommand 对象(用来返回一个结果集，而不是一个整数值)
        /// </summary>
        /// <param name="connection">数据库连接</param>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <returns>SqlCommand</returns>
        private static SqlCommand BuildQueryCommand(SqlConnection connection, string storedProcName, IDataParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(storedProcName, connection);
            command.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter parameter in parameters)
            {
                if (parameter != null)
                {
                    /* 检查未分配值的输出参数,将其分配以DBNull.Value.*/
                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) && (parameter.Value == null))
                    {
                        parameter.Value = DBNull.Value;
                    }
                    command.Parameters.Add(parameter);
                }
            }
            return command;
        }

        /// <summary>
        /// 创建 SqlCommand 对象实例(用来返回一个整数值)	
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <returns>SqlCommand 对象实例</returns>
        private static SqlCommand BuildIntCommand(SqlConnection connection, string storedProcName, IDataParameter[] parameters)
        {
            SqlCommand command = BuildQueryCommand(connection, storedProcName, parameters);
            command.Parameters.Add(new SqlParameter("ReturnValue", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, 0, 0, string.Empty, DataRowVersion.Default, null));
            return command;
        }

        #endregion

    }
}
