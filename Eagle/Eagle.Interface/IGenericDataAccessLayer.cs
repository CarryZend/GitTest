using Eagle.DBUtility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Eagle.Interface
{
    /// <summary>
    /// 名  称：通用数据访问层接口
    /// 说  明：1.该文件是DAL实体类的接口文件，DAL类必须实现本文件中的所有方法。
    ///         2.DAL文件增加方法时，请将新增加方法的签名增加到本文件中，否则可能导致新增加的方法无法访问。
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGenericDataAccessLayer<T>
    {
        int Delete(T Entity);
        int Delete(T[] Entity);
        System.Data.DataTable ExecuteMultiTablesSelectSql(string sql,PageInfo pageinfo, SqlParameter[] cmdParam);
        int Insert(T Entity);
        int Insert(T[] Entity);
        bool IsExsist(T Entity);
        T QueryWithPrimaryKey(T Entity);
        T[] SelectAllEntities();
        System.Data.DataTable SelectAllRows();
        System.Data.DataTable SelectAllRows(PageInfo pageinfo);
        System.Data.DataTable SelectAllRows(string OrderBy);
        T[] SelectEntitiesByEntityCondition(T Entity);
        T[] SelectEntitiesByEntityCondition(T Entity, PageInfo p);
        T[] SelectEntitiesByEntityCondition(T Entity, string OrderBy);
        T[] SelectEntitiesByEntityCondition(T Entity, string OrderBy, PageInfo p);
        System.Data.DataTable SelectRowsByEntityCondition(T Entity);
        System.Data.DataTable SelectRowsByEntityCondition(T Entity, PageInfo p);
        System.Data.DataTable SelectRowsByEntityCondition(T Entity, string OrderBy);
        System.Data.DataTable SelectRowsByEntityCondition(T Entity, string OrderBy, PageInfo p);
        int Update(T Entity);
        int Update(T Entity, T Where);
        int Update(T[] Entity);
    }
}
