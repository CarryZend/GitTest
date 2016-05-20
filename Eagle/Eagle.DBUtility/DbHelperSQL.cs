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
    /// ���ݷ��ʳ��������
    /// </summary>
    public abstract class DbHelperSQL
    {

        /// <summary>
        /// ���ݿ������ַ���(web.config������)�����Զ�̬����connectionString֧�ֶ����ݿ�.	
        /// </summary>	
        public static string ConnectionString = BaseConfigs.GetDBConnectString;

        /// <summary>
        /// Ĭ�Ϲ��캯��,���������̳У���������ʵ����ʱ����ñ����캯����
        /// ��������κ�����̳б��ࡣ
        /// </summary>
        public DbHelperSQL()
        {

        }

        #region ��������

        /// <summary>
        /// �ж�ĳ���ֶ�(��)�Ƿ������ĳ���С�
        /// </summary>
        /// <param name="tableName">������</param>
        /// <param name="columnName">�ֶ�(��)����</param>
        /// <returns>�Ƿ����</returns>
        public static bool ColumnExists(string tableName, string columnName)
        {
            /*������ѯ��� ͳ�����ܺ�*/
            string sql = string.Format("select count(1) from syscolumns where [id]=object_id('{0}') and [name]='{1}'", tableName, columnName);
            /*ִ�в�ѯ*/
            object res = ExecuteScalar(sql);
            /*���Ϊ�յ����*/
            if (res == null)
            {
                return false;
            }
            /*��Ϊ�գ��жϽ���Ƿ����0*/
            return Convert.ToInt32(res) > 0;
        }

        /// <summary>
        /// ��ȡĳ����ĳ���У��ɼ����㣩�����ֵ�� 1
        /// Select Max(ID) +1 From TableName
        /// </summary>
        /// <param name="FieldName">������</param>
        /// <param name="TableName">������</param>
        /// <returns></returns>
        public static int GetMaxID(string FieldName, string TableName)
        {
            /*�����ѯ���*/
            string sql = string.Format("select max({0})+1 from {1}", FieldName, TableName);
            /*ִ�в�ѯ���*/
            object obj = ExecuteScalar(sql);
            /*���Ϊ�շ���1*/
            if (obj == null)
            {
                return 1;
            }
            /*��Ϊ�գ�����ʵ��ֵ*/
            return int.Parse(obj.ToString());
        }

        /// <summary>
        /// ִ��һ����ѯ��䣬�жϷ��صĵ�һ�е�һ���Ƿ�Ϊ0��
        /// ����sql���������count(*)���ж��Ƿ���������С�
        /// ��0����true,0����false.
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static bool Exists(string sql)
        {
            /*ִ�в�ѯ��䣬���ؽ��*/
            object obj = ExecuteScalar(sql);
            /*��������ʱ����*/
            int cmdresult;
            /*Ϊ�ջ���DBNull�����*/
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
            {
                cmdresult = 0;
            }
            else
            {
                cmdresult = int.Parse(obj.ToString());
            }
            /*0����false,��0�����档*/
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
        /// ִ��һ����ѯ��䣬�жϷ��صĵ�һ�е�һ���Ƿ�Ϊ0��
        /// ����sql���������count(*)���ж��Ƿ���������С�
        /// ��0����true,0����false.
        /// </summary>
        /// <param name="sql">��ѯ���</param>
        /// <param name="cmdParms">����</param>
        /// <returns>�Ƿ����</returns>
        public static bool Exists(string sql, params SqlParameter[] cmdParms)
        {
            /*ִ�в�ѯ��䣬���ؽ��*/
            object obj = ExecuteScalar(sql, cmdParms);
            /*��������ʱ����*/
            int cmdresult;
            /*Ϊ�ջ���DBNull�����*/
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
            {
                cmdresult = 0;
            }
            else
            {
                cmdresult = int.Parse(obj.ToString());
            }
            /*0����false,��0�����档*/
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
        /// ���Ƿ���ڡ��˷������Ż����������ֱ�ӵ���Exists()������
        /// </summary>
        /// <param name="TableName"></param>
        /// <returns></returns>
        public static bool TableExists(string TableName)
        {
            /*�����ѯ��� ����SqlServer��ͬ�汾�����������ܲ�ͬ*/
            string sql = string.Format("select count(*) from sysobjects where id = object_id(N'[{0}]') and OBJECTPROPERTY(id, N'IsUserTable') = 1", TableName);

            /*ִ�в�ѯ���*/
            object obj = ExecuteScalar(sql);
            /*��ѯ�������*/
            int cmdresult;
            /*�ж�Ϊnull����DBNull�����*/
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
            {
                cmdresult = 0;
            }
            else
            {
                cmdresult = int.Parse(obj.ToString());
            }
            /*0����false,��0�����档*/
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

        #region  ִ�м�SQL���

        /// <summary>
        /// ִ��SQL��䣬������Ӱ��ļ�¼��
        /// </summary>
        /// <param name="sql">SQL���</param>
        /// <returns>Ӱ��ļ�¼��</returns>
        public static int ExecuteSql(string sql)
        {
            /*�������Ӷ���*/
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                /*����SqlCommand����*/
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    try
                    {
                        /*������*/
                        connection.Open();
                        /*ִ����䣬������Ӱ�������*/
                        return cmd.ExecuteNonQuery();
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        /*�ر�����*/
                        connection.Close();
                        throw e;
                    }
                }
            }
        }

        /// <summary>
        /// ִ��SQL��䣬������Ӱ��ļ�¼��
        /// </summary>
        /// <param name="sql">SQL���</param>
        /// <param name="timeout">��ʱʱ��</param>
        /// <returns>Ӱ��ļ�¼��</returns>
        public static int ExecuteSql(string sql, int timeout)
        {
            /*�������Ӷ���*/
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                /*����SqlCommand����*/
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    try
                    {
                        /*������*/
                        connection.Open();
                        /*���ó�ʱʱ��*/
                        cmd.CommandTimeout = timeout;
                        /*ִ����䣬������Ӱ�������*/
                        return cmd.ExecuteNonQuery();
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        /*�ر�����*/
                        connection.Close();
                        throw e;
                    }
                }
            }
        }

        /// <summary>
        /// ִ�д�һ���洢���̲����ĵ�SQL��䡣
        /// </summary>
        /// <param name="SQLString">SQL���</param>
        /// <param name="content">��������,����һ���ֶ��Ǹ�ʽ���ӵ����£���������ţ�����ͨ�������ʽ���</param>
        /// <returns>Ӱ��ļ�¼��</returns>
        public static int ExecuteSql(string SQLString, string content)
        {
            /*�������Ӷ���*/
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                /*����SqlCommand����*/
                SqlCommand cmd = new SqlCommand(SQLString, connection);
                /*��������*/
                System.Data.SqlClient.SqlParameter myParameter = new System.Data.SqlClient.SqlParameter("@content", SqlDbType.NText);
                myParameter.Value = content;
                cmd.Parameters.Add(myParameter);
                try
                {
                    /*������*/
                    connection.Open();
                    /*ִ�в�ѯ��������Ӱ�����*/
                    int rows = cmd.ExecuteNonQuery();
                    return rows;
                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    throw e;
                }
                finally
                {
                    /*���ٶ��󣬹ر�����*/
                    cmd.Dispose();
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// ִ�д�һ���洢���̲����ĵ�SQL��䡣
        /// </summary>
        /// <param name="SQLString">SQL���</param>
        /// <param name="content">��������,����һ���ֶ��Ǹ�ʽ���ӵ����£���������ţ�����ͨ�������ʽ���</param>
        /// <returns>Ӱ��ļ�¼��</returns>
        public static object ExecuteSqlGet(string SQLString, string content)
        {
            /*�������Ӷ���*/
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                /*����SqlCommand����*/
                SqlCommand cmd = new SqlCommand(SQLString, connection);
                /*��������*/
                System.Data.SqlClient.SqlParameter myParameter = new System.Data.SqlClient.SqlParameter("@content", SqlDbType.NText);
                myParameter.Value = content;
                cmd.Parameters.Add(myParameter);
                try
                {
                    /*������*/
                    connection.Open();
                    /*ִ�в�ѯ�����ص�һ�е�һ��*/
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
                    /*���ٶ��󣬹ر�����*/
                    cmd.Dispose();
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// ִ�ж���SQL��䣬ʵ�����ݿ�����
        /// </summary>
        /// <param name="SQLStringList">����SQL���</param>		
        public static int ExecuteSqlTran(List<String> SQLStringList)
        {
            /*�������ݿ�����*/
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                /*������*/
                connection.Open();
                /*����SqlCommand����*/
                SqlCommand cmd = new SqlCommand();
                /*��������*/
                cmd.Connection = connection;
                /*��ʼ����*/
                SqlTransaction tx = connection.BeginTransaction();
                cmd.Transaction = tx;
                try
                {
                    /*������*/
                    int count = 0;
                    for (int n = 0; n < SQLStringList.Count; n++)
                    {
                        string strsql = SQLStringList[n];
                        if (strsql.Trim().Length > 1)
                        {
                            cmd.CommandText = strsql;
                            /*ִ�����*/
                            count += cmd.ExecuteNonQuery();
                        }
                    }
                    /*�ύ����*/
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
        /// ִ��Sql��Oracle�λ������
        /// WhenHaveContine:ִ�н������0����
        /// WhenNoHaveContine��ִ�н������0����
        /// SolicitationEvent:ִ�н������0�����¼�
        /// </summary>
        /// <param name="list">SQL�������б�</param>
        /// <param name="oracleCmdSqlList">Oracle�������б�</param>
        /// <returns>ִ�н�� 0-����SQL�������ʧ�� -1 ����Oracle�������ʧ�� 1-��������ִ�гɹ�</returns>
        public static int ExecuteSqlTran(List<CommandInfo> list, List<CommandInfo> oracleCmdSqlList)
        {
            /*�������Ӷ���*/
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                /*������*/
                connection.Open();
                /*����SqlCommand����*/
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                /*����ʼ*/
                SqlTransaction tx = connection.BeginTransaction();
                cmd.Transaction = tx;
                try
                {
                    /*����list��ÿһ������*/
                    foreach (CommandInfo myDE in list)
                    {
                        /*��ȡ���*/
                        string cmdText = myDE.CommandText;
                        /*��ȡ����*/
                        SqlParameter[] cmdParms = (SqlParameter[])myDE.Parameters;
                        /*����cmd����*/
                        PrepareCommand(cmd, connection, tx, cmdText, cmdParms);

                        /*��ִ�н������0ʱ�����¼�*/
                        if (myDE.EffentNextType == EffentNextType.SolicitationEvent)
                        {
                            /*������Ϸ���*/
                            if (myDE.CommandText.ToLower().IndexOf("count(") == -1)
                            {
                                tx.Rollback();
                                throw new Exception("Υ��Ҫ��" + myDE.CommandText + "�������select count(..�ĸ�ʽ");
                            }
                            /*ִ�����*/
                            object obj = cmd.ExecuteScalar();
                            /*�������(�Ƿ��н��)*/
                            bool isHave = false;
                            if (obj == null && obj == DBNull.Value)
                            {
                                isHave = false;
                            }
                            isHave = Convert.ToInt32(obj) > 0;
                            if (isHave)
                            {
                                /*�����¼�*/
                                myDE.OnSolicitationEvent();
                            }
                        }

                        if (myDE.EffentNextType == EffentNextType.WhenHaveContine || myDE.EffentNextType == EffentNextType.WhenNoHaveContine)
                        {
                            /*�������Ƿ�Ϸ�*/
                            if (myDE.CommandText.ToLower().IndexOf("count(") == -1)
                            {
                                /*�ع�����*/
                                tx.Rollback();
                                throw new Exception("SQL:Υ��Ҫ��" + myDE.CommandText + "�������select count(..�ĸ�ʽ");
                            }
                            /*ִ������Ƿ�Ϸ�*/
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
                                throw new Exception("SQL:Υ��Ҫ��" + myDE.CommandText + "����ֵ�������0");
                            }
                            if (myDE.EffentNextType == EffentNextType.WhenNoHaveContine && isHave)
                            {
                                tx.Rollback();
                                throw new Exception("SQL:Υ��Ҫ��" + myDE.CommandText + "����ֵ�������0");
                            }
                            continue;
                        }

                        int val = cmd.ExecuteNonQuery();
                        if (myDE.EffentNextType == EffentNextType.ExcuteEffectRows && val == 0)
                        {
                            tx.Rollback();
                            throw new Exception("SQL:Υ��Ҫ��" + myDE.CommandText + "������Ӱ����");
                        }
                        cmd.Parameters.Clear();
                    }
                    string oraConnectionString = PubConstant.GetConnectionString("ConnectionStringPPC");
                    bool res = OracleHelper.ExecuteSqlTran(oraConnectionString, oracleCmdSqlList);
                    if (!res)
                    {
                        tx.Rollback();
                        throw new Exception("Oracleִ��ʧ��");
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
        /// �����ݿ������ͼ���ʽ���ֶ�(������������Ƶ���һ��ʵ��)
        /// </summary>
        /// <param name="strSQL">SQL���</param>
        /// <param name="fs">ͼ���ֽ�,���ݿ���ֶ�����Ϊimage�����</param>
        /// <returns>Ӱ��ļ�¼��</returns>
        public static int ExecuteSqlInsertImg(string strSQL, byte[] fs)
        {
            /*�������Ӷ���*/
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                /*����SqlCommand����*/
                SqlCommand cmd = new SqlCommand(strSQL, connection);
                /*��������*/
                System.Data.SqlClient.SqlParameter myParameter = new System.Data.SqlClient.SqlParameter("@fs", SqlDbType.Image);
                myParameter.Value = fs;
                cmd.Parameters.Add(myParameter);
                try
                {
                    /*������*/
                    connection.Open();
                    /*ִ����䲢������Ӱ�����*/
                    return cmd.ExecuteNonQuery();
                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    throw e;
                }
                finally
                {
                    /*���ٶ��󣬹ر�����*/
                    cmd.Dispose();
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// ִ��һ�������ѯ��䣬�����ص�һ�е�һ�У�object����
        /// </summary>
        /// <param name="SqlString">��ѯ���</param>
        /// <returns>��ѯ�������(object)</returns>
        public static object ExecuteScalar(string SqlString)
        {
            /*�������Ӷ���*/
            using (SqlConnection Connection = new SqlConnection(ConnectionString))
            {
                /*����SqlCommand����*/
                using (SqlCommand cmd = new SqlCommand(SqlString, Connection))
                {
                    try
                    {
                        /*������*/
                        Connection.Open();
                        /*ִ�в�ѯ*/
                        object obj = cmd.ExecuteScalar();
                        /*������ؽ��Ϊ�ջ���ΪDBNull*/
                        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                        {
                            /*���ؿ�*/
                            return null;
                        }
                        else
                        {
                            /*����ִ�н��*/
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
        /// ִ��һ�������ѯ��䣬�����ص�һ�е�һ�У�object����
        /// </summary>
        /// <param name="SqlString">��ѯ���</param>
        /// <param name="Times">��ʱʱ��</param>
        /// <returns>��ѯ�������(object)</returns>
        public static object ExecuteScalar(string SqlString, int Times)
        {
            /*�������Ӷ���*/
            using (SqlConnection Connection = new SqlConnection(ConnectionString))
            {
                /*����SqlCommand����*/
                using (SqlCommand cmd = new SqlCommand(SqlString, Connection))
                {
                    try
                    {
                        /*������*/
                        Connection.Open();
                        /*���ó�ʱʱ��*/
                        cmd.CommandTimeout = Times;
                        /*ִ�в�ѯ*/
                        object obj = cmd.ExecuteScalar();
                        /*������ؽ��Ϊ�ջ���ΪDBNull*/
                        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                        {
                            /*���ؿ�*/
                            return null;
                        }
                        else
                        {
                            /*����ִ�н��*/
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
        /// ִ��һ�������ѯ�����䣬���ز�ѯ�����object����
        /// </summary>
        /// <param name="sql">��ѯ������</param>
        /// <returns>��ѯ�����object��</returns>
        public static object ExecuteScalar(string sql, params SqlParameter[] cmdParms)
        {
            /*�������Ӷ���*/
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                /*����SqlCommand����*/
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        /*��ʼ��*/
                        PrepareCommand(cmd, connection, null, sql, cmdParms);
                        /*ִ�в�ѯ*/
                        object obj = cmd.ExecuteScalar();
                        /*��ղ���*/
                        cmd.Parameters.Clear();
                        /*���ؽ��*/
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
        /// ִ�в�ѯ��䣬����SqlDataReader ( ע�⣺���ø÷�����һ��Ҫ��SqlDataReader����Close )
        /// </summary>
        /// <param name="strSQL">��ѯ���</param>
        /// <returns>SqlDataReader</returns>
        public static SqlDataReader ExecuteReader(string strSQL)
        {
            /*�������Ӷ���*/
            SqlConnection connection = new SqlConnection(ConnectionString);
            /*����SqlCommand����*/
            SqlCommand cmd = new SqlCommand(strSQL, connection);
            try
            {
                /*������*/
                connection.Open();
                /*ִ��ExecuteReader*/
                SqlDataReader myReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return myReader;
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                throw e;
            }
        }

        /// <summary>
        /// ִ�в�ѯ��䣬����DataSet
        /// </summary>
        /// <param name="sql">��ѯ���</param>
        /// <returns>DataSet</returns>
        public static DataSet Query(string sql)
        {
            /*��������*/
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                /*����ds*/
                DataSet ds = new DataSet();
                try
                {
                    /*������*/
                    connection.Open();
                    /*����������*/
                    SqlDataAdapter command = new SqlDataAdapter(sql, connection);
                    /*���DataSet*/
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
        /// ִ�в�ѯ��䣬����DataSet
        /// </summary>
        /// <param name="sql">��ѯ���</param>
        /// <param name="timeout">��ʱʱ��</param>
        /// <returns>DataSet</returns>
        public static DataSet Query(string sql, int timeout)
        {
            /*��������*/
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                /*����ds*/
                DataSet ds = new DataSet();
                try
                {
                    /*������*/
                    connection.Open();
                    /*����������*/
                    SqlDataAdapter command = new SqlDataAdapter(sql, connection);
                    /*���ó�ʱʱ��*/
                    command.SelectCommand.CommandTimeout = timeout;
                    /*���DataSet*/
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

        #region ִ�д�������SQL���

        /// <summary>
        /// ������SQL��䰴PageInfo��������Select��ҳ��䡣����������Ϣ��PageInfo����
        /// ע��1 SQL������Select��䡣
        ///     2 ������Order By�Ӿ䡣
        /// </summary>
        public static string BuildSelectWithPage(string sql, PageInfo pageinfo, SqlParameter[] cmdParam)
        {
            /*ҳ��С*/
            int PageSize = pageinfo.PageSize;
            /*��ǰҳ��*/
            int PageNum = pageinfo.CurrentPage;
            /*��ȡ�����ֶ�*/
            string OrderBy = sql.Substring(sql.ToLower().IndexOf("order by"));
            /*��ȡselect���*/
            string SelectSql = sql.Substring(0, sql.ToLower().IndexOf("order by"));
            /*�ع����*/
            string sb = "select * from ( select row_number() over ({0}) as rowid,* from ({1}) t )t where t.rowid>={2} and t.rowid<={3}";
            string ret = string.Format(sb.ToString(), OrderBy, SelectSql, PageSize * (PageNum - 1) + 1, PageNum * PageSize);
            /*�����ܼ�¼��*/
            string SelectCountSql = string.Format("select count(*) from ({0}) t", SelectSql);
            pageinfo.TotalRecords = (int)DbHelperSQL.ExecuteSqlScalar(SelectCountSql, cmdParam);
            pageinfo.CalculatePages();
            return ret;
        }

        /// <summary>
        /// ִ��SQL��䣬����Ӱ��ļ�¼��
        /// </summary>
        /// <param name="SQLString">SQL���</param>
        /// <returns>Ӱ��ļ�¼��</returns>
        public static int ExecuteSql(string SQLString, params SqlParameter[] cmdParms)
        {
            /*�������Ӷ���*/
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                /*����SqlCommand����*/
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        /*��ʼ��*/
                        PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                        /*ִ�����,������Ӱ�����*/
                        int rows = cmd.ExecuteNonQuery();
                        /*�������*/
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
        /// ִ�д�������sql��䣬�����ؽ�����ĵ�һ�е�һ�У�������
        /// </summary>
        /// <param name="SQLString"></param>
        /// <param name="cmdParms"></param>
        /// <returns></returns>
        public static int ExecuteSqlScalar(string SQLString, params SqlParameter[] cmdParms)
        {
            /*�������Ӷ���*/
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                /*����SqlCommand����*/
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        /*��ʼ������*/
                        PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                        /*ִ����䣬�����������һ�е�һ��ת��Ϊ������*/
                        int rows = int.Parse(cmd.ExecuteScalar().ToString());
                        /*�������*/
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
        /// ִ�ж���SQL��䣬ʵ�����ݿ�����
        /// </summary>
        /// <param name="SQLStringList">SQL���Ĺ�ϣ��keyΪsql��䣬value�Ǹ�����SqlParameter[]��</param>
        public static void ExecuteSqlTran(Hashtable SQLStringList)
        {
            /*�������Ӷ���*/
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                /*������*/
                connection.Open();
                /*����ʼ*/
                using (SqlTransaction trans = connection.BeginTransaction())
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        try
                        {
                            /*ѭ��*/
                            foreach (DictionaryEntry Entry in SQLStringList)
                            {
                                /*��ȡsql���*/
                                string cmdText = Entry.Key.ToString();
                                /*��ȡ����*/
                                SqlParameter[] cmdParms = (SqlParameter[])Entry.Value;
                                /*��ʼ��*/
                                PrepareCommand(cmd, connection, trans, cmdText, cmdParms);
                                /*ִ����䣬������Ӱ�����*/
                                int val = cmd.ExecuteNonQuery();
                                /*�������*/
                                cmd.Parameters.Clear();
                            }
                            /*�ύ����*/
                            trans.Commit();
                        }
                        catch
                        {
                            /*�ع�����*/
                            trans.Rollback();
                            throw;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// ִ�ж���SQL��䣬ʵ�����ݿ�����
        /// </summary>
        /// <param name="SQLStringList">SQL���Ĺ�ϣ��keyΪsql��䣬value�Ǹ�����SqlParameter[]��</param>
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
                        //ѭ��
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
        /// ִ�ж���SQL��䣬ʵ�����ݿ�����
        /// </summary>
        /// <param name="SQLStringList">SQL���Ĺ�ϣ��keyΪsql��䣬value�Ǹ�����SqlParameter[]��</param>
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
                        //ѭ��
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
        /// ִ�ж���SQL��䣬ʵ�����ݿ�����
        /// </summary>
        /// <param name="SQLStringList">SQL���Ĺ�ϣ��keyΪsql��䣬value�Ǹ�����SqlParameter[]��</param>
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
                        //ѭ��
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
        /// ִ�в�ѯ��䣬����SqlDataReader ( ע�⣺���ø÷�����һ��Ҫ��SqlDataReader����Close )
        /// </summary>
        /// <param name="strSQL">��ѯ���</param>
        /// <returns>SqlDataReader</returns>
        public static SqlDataReader ExecuteReader(string SQLString, params SqlParameter[] cmdParms)
        {
            /*�������Ӷ���*/
            SqlConnection connection = new SqlConnection(ConnectionString);
            /*����SqlCommand����*/
            using (SqlCommand cmd = new SqlCommand())
            {
                try
                {
                    /*��ʼ��*/
                    PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                    /*����SqlDataReader����*/
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
        /// ִ�в�ѯ��䣬����DataSet
        /// </summary>
        /// <param name="SQLString">��ѯ���</param>
        /// <returns>DataSet</returns>
        public static DataSet Query(string SQLString, params SqlParameter[] cmdParms)
        {
            /*�������Ӷ���*/
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                /*����SqlCommand����*/
                using (SqlCommand cmd = new SqlCommand())
                {
                    /*��ʼ��*/
                    PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                    /*����������*/
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        /*����DataSet*/
                        DataSet ds = new DataSet();
                        try
                        {
                            /*���DataSet*/
                            da.Fill(ds, "ds");
                            /*�������*/
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
        /// ��ʼ��cmd����
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

        #region �洢���̲���

        /// <summary>
        /// ִ�д洢���̣�����SqlDataReader ( ע�⣺���ø÷�����һ��Ҫ��SqlDataReader����Close )
        /// </summary>
        /// <param name="storedProcName">�洢������</param>
        /// <param name="parameters">�洢���̲���</param>
        /// <returns>SqlDataReader</returns>
        public static SqlDataReader RunProcedure(string storedProcName, IDataParameter[] parameters)
        {
            /*�������Ӷ���*/
            SqlConnection connection = new SqlConnection(ConnectionString);
            /*������*/
            connection.Open();
            /*����SqlCommand����*/
            SqlCommand command = BuildQueryCommand(connection, storedProcName, parameters);
            command.CommandType = CommandType.StoredProcedure;
            /*ִ��ExecuteReader����*/
            SqlDataReader returnReader = command.ExecuteReader(CommandBehavior.CloseConnection);
            return returnReader;
        }

        /// <summary>
        /// ִ�д洢����
        /// </summary>
        /// <param name="storedProcName">�洢������</param>
        /// <param name="parameters">�洢���̲���</param>
        /// <param name="tableName">DataSet����еı���</param>
        /// <returns>DataSet</returns>
        public static DataSet RunProcedure(string storedProcName, IDataParameter[] parameters, string tableName)
        {
            /*�������Ӷ���*/
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                /*����dataSet*/
                DataSet dataSet = new DataSet();
                /*������*/
                connection.Open();
                /*����������*/
                using (SqlDataAdapter sqladapter = new SqlDataAdapter())
                {
                    sqladapter.SelectCommand = BuildQueryCommand(connection, storedProcName, parameters);
                    /*���*/
                    sqladapter.Fill(dataSet, tableName);
                    return dataSet;
                }
            }
        }

        /// <summary>
        /// ִ�д洢����
        /// </summary>
        /// <param name="storedProcName">�洢������</param>
        /// <param name="parameters">�洢���̲���</param>
        /// <param name="tableName">DataSet����еı���</param>
        /// <param name="timeout">��ʱʱ��</param>
        /// <returns></returns>
        public static DataSet RunProcedure(string storedProcName, IDataParameter[] parameters, string tableName, int timeout)
        {
            /*�������Ӷ���*/
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                /*����dataSet*/
                DataSet dataSet = new DataSet();
                /*������*/
                connection.Open();
                /*����������*/
                using (SqlDataAdapter sqladapter = new SqlDataAdapter())
                {
                    sqladapter.SelectCommand = BuildQueryCommand(connection, storedProcName, parameters);
                    /*���ó�ʱʱ��*/
                    sqladapter.SelectCommand.CommandTimeout = timeout;
                    /*���*/
                    sqladapter.Fill(dataSet, tableName);
                    return dataSet;
                }
            }
        }

        /// <summary>
        /// ִ�д洢���̣�����Ӱ�������		
        /// </summary>
        /// <param name="storedProcName">�洢������</param>
        /// <param name="parameters">�洢���̲���</param>
        /// <param name="rowsAffected">Ӱ�������</param>
        /// <returns></returns>
        public static int RunProcedure(string storedProcName, IDataParameter[] parameters, out int rowsAffected)
        {
            /*�������Ӷ���*/
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                /*������*/
                connection.Open();
                /*����SqlCommand����*/
                using (SqlCommand command = BuildIntCommand(connection, storedProcName, parameters))
                {
                    rowsAffected = command.ExecuteNonQuery();
                    return (int)command.Parameters["ReturnValue"].Value;
                }
            }
        }

        /// <summary>
        /// ���� SqlCommand ����(��������һ���������������һ������ֵ)
        /// </summary>
        /// <param name="connection">���ݿ�����</param>
        /// <param name="storedProcName">�洢������</param>
        /// <param name="parameters">�洢���̲���</param>
        /// <returns>SqlCommand</returns>
        private static SqlCommand BuildQueryCommand(SqlConnection connection, string storedProcName, IDataParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(storedProcName, connection);
            command.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter parameter in parameters)
            {
                if (parameter != null)
                {
                    /* ���δ����ֵ���������,���������DBNull.Value.*/
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
        /// ���� SqlCommand ����ʵ��(��������һ������ֵ)	
        /// </summary>
        /// <param name="storedProcName">�洢������</param>
        /// <param name="parameters">�洢���̲���</param>
        /// <returns>SqlCommand ����ʵ��</returns>
        private static SqlCommand BuildIntCommand(SqlConnection connection, string storedProcName, IDataParameter[] parameters)
        {
            SqlCommand command = BuildQueryCommand(connection, storedProcName, parameters);
            command.Parameters.Add(new SqlParameter("ReturnValue", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, 0, 0, string.Empty, DataRowVersion.Default, null));
            return command;
        }

        #endregion

    }
}
