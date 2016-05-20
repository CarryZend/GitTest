using Eagle.DBUtility;
using Eagle.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Eagle.Data
{
    /// <summary>
    /// SqlServer操作类
    /// </summary>
    public class SqlDataAccessLayer<T> : IGenericDataAccessLayer<T> where T : IEntity, new()
    {
        public int Delete(T Entity)
        {
            return GenericDataAccessLayer<T>.Delete(Entity);
        }

        public int Delete(T[] Entity)
        {
            return GenericDataAccessLayer<T>.Delete(Entity);
        }

        public DataTable ExecuteMultiTablesSelectSql(string sql, PageInfo pageinfo, SqlParameter[] cmdParam)
        {
            return GenericDataAccessLayer<T>.ExecuteMultiTablesSelectSql(sql, pageinfo, cmdParam);
        }

        public int Insert(T Entity)
        {
            return GenericDataAccessLayer<T>.Insert(Entity);
        }

        public int Insert(T[] Entity)
        {
            return GenericDataAccessLayer<T>.Insert(Entity);
        }
        public bool IsExsist(T Entity)
        {
            return GenericDataAccessLayer<T>.IsExsist(Entity);
        }

        public T QueryWithPrimaryKey(T Entity)
        {
            return GenericDataAccessLayer<T>.QueryWithPrimaryKey(Entity);
        }
        public T[] SelectAllEntities()
        {
            return GenericDataAccessLayer<T>.SelectAllEntities();
        }
        public System.Data.DataTable SelectAllRows()
        {
            return GenericDataAccessLayer<T>.SelectAllRows();
        }
        public System.Data.DataTable SelectAllRows(PageInfo pageinfo)
        {
            return GenericDataAccessLayer<T>.SelectAllRows(pageinfo);
        }

        public System.Data.DataTable SelectAllRows(string OrderBy)
        {
            return GenericDataAccessLayer<T>.SelectAllRows(OrderBy);
        }
        public T[] SelectEntitiesByEntityCondition(T Entity)
        {
            return GenericDataAccessLayer<T>.SelectEntitiesByEntityCondition(Entity);
        }
        public T[] SelectEntitiesByEntityCondition(T Entity, PageInfo p)
        {
            return GenericDataAccessLayer<T>.SelectEntitiesByEntityCondition(Entity, p);
        }

        public T[] SelectEntitiesByEntityCondition(T Entity, string OrderBy)
        {
            return GenericDataAccessLayer<T>.SelectEntitiesByEntityCondition(Entity, OrderBy);
        }
        public T[] SelectEntitiesByEntityCondition(T Entity, string OrderBy, PageInfo p)
        {
            return GenericDataAccessLayer<T>.SelectEntitiesByEntityCondition(Entity, OrderBy, p);
        }
        public System.Data.DataTable SelectRowsByEntityCondition(T Entity)
        {
            return GenericDataAccessLayer<T>.SelectRowsByEntityCondition(Entity);
        }

        public System.Data.DataTable SelectRowsByEntityCondition(T Entity, PageInfo p)
        {
            return GenericDataAccessLayer<T>.SelectRowsByEntityCondition(Entity, p);
        }

        public System.Data.DataTable SelectRowsByEntityCondition(T Entity, string OrderBy)
        {
            return GenericDataAccessLayer<T>.SelectRowsByEntityCondition(Entity, OrderBy);
        }

        public System.Data.DataTable SelectRowsByEntityCondition(T Entity, string OrderBy, PageInfo p)
        {
            return GenericDataAccessLayer<T>.SelectRowsByEntityCondition(Entity, OrderBy, p);
        }

        public int Update(T Entity)
        {
            return GenericDataAccessLayer<T>.Update(Entity);
        }

        public int Update(T Entity, T Where)
        {
            return GenericDataAccessLayer<T>.Update(Entity, Where);
        }

        public int Update(T[] Entity)
        {
            return GenericDataAccessLayer<T>.Update(Entity);
        }

    }
}
