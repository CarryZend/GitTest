using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Eagle.DBUtility;
using Eagle.Config;

namespace Eagle.ToolProject
{
    public partial class MainForm : Form
    {
        private string ConnectionStr = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void 打开OToolStripButton_Click(object sender, EventArgs e)
        {
            DbConn Frm = new DbConn();
            Frm.PopulateTables_Handle = new PopulateTables_Delegate(getTables);
            Frm.ShowDialog();
        }

        /// <summary>
        /// 获取所有的表，并生成一棵树控件显示
        /// </summary>
        private void getTables()
        {
            /*构造查询字符串，执行查询*/
            DataSet ds= DbHelperSQL.Query("select [name] from sysobjects where (xtype='U' or xtype='V' )and name<>'dtproperties' order by id");
            /*创建根节点 名称为数据库名*/
            string Database = readDataBaseName();
            TreeNode root = new TreeNode(Database);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                TreeNode tmp = new TreeNode(ds.Tables[0].Rows[i][0].ToString());
                root.Nodes.Add(tmp);
            }
            treeView1.Nodes.Add(root);
            treeView1.ExpandAll();
            /*加载表字段节点*/
            getColumns(root);
        }

        /// <summary>
        /// 从配置
        /// </summary>
        /// <returns></returns>
        private string readDataBaseName()
        {
            /*读取配置文件连接字符串*/
            string ConnectionString = BaseConfigs.GetDBConnectString;
            if (ConnectionString == null)
            {
                return "";
            }
            /*拆分连接字符串，取出数据库名*/
            int StartIndex = ConnectionString.IndexOf("Database=") + 9;
            int Count = ConnectionString.IndexOf(";User") - StartIndex;
            string DataBaseName = ConnectionString.Substring(StartIndex, Count);
            return DataBaseName;
        }


        /// <summary>
        /// 为每一个表节点生成字段节点
        /// </summary>
        /// <param name="root">表根节点</param>
        public void getColumns(TreeNode root)
        {
            for (int i = 0; i < root.Nodes.Count; i++)
            {
                /*构造查询语句*/
                string sql = string.Format("SELECT Column_Name FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME ='{0}'", root.Nodes[i].Text.Trim());
                /*执行查询语句*/
                SqlDataReader rd = DbHelperSQL.ExecuteReader(sql);
                /*创建字段节点*/
                while (rd.Read())
                {
                    TreeNode node = new TreeNode(rd[0].ToString());
                    root.Nodes[i].Nodes.Add(node);
                }
                rd.Close();
            }
        }

        /// <summary>
        /// 右键菜单
        /// </summary>
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //界面操作过滤
            if (e.Button != MouseButtons.Right) return;
            if (e.Node == null)
            {
                return;
            }
            treeView1.SelectedNode = e.Node;
            //弹出右键菜单
            contextMenuStrip1.Items.Clear();
            if (e.Node.Level == 0)
            {
                //为根节点生成菜单
                contextMenuStrip1.Items.Add("生成全部实体类(Model)");
                contextMenuStrip1.Items[0].Click += new EventHandler(BuildEntityAll);
                contextMenuStrip1.Items.Add("生成全部数据层类(DAL)");
                contextMenuStrip1.Items[1].Click += new EventHandler(BuildDalAll);
            }
            else if (e.Node.Level == 1)
            {
                //为表节点生成菜单
                contextMenuStrip1.Items.Add("生成表" + e.Node.Text + "实体类");
                contextMenuStrip1.Items[0].Click += new EventHandler(BuildEntity);
                contextMenuStrip1.Items.Add("生成表" + e.Node.Text + "数据层类(DAL)");
                contextMenuStrip1.Items[1].Click += new EventHandler(BuildDal);
                //生成查看菜单
                contextMenuStrip1.Items.Add("查看表" + e.Node.Text + "的实体类");
                contextMenuStrip1.Items[2].Click += new EventHandler(ShowEntity);
                contextMenuStrip1.Items.Add("查看表" + e.Node.Text + "的DAL类");
            }
            treeView1.SelectedNode.ContextMenuStrip = contextMenuStrip1;
            contextMenuStrip1.Show();
        }

        /// <summary>
        /// 查看实体类
        /// </summary>
        private void ShowEntity(object sender, EventArgs arg)
        {
            string TableName = treeView1.SelectedNode.Text;
            string sql = BuildQueryStr(TableName);
            DataTable table = DbHelperSQL.Query(sql).Tables[0];
            string txt = BuildFileContent(TableName, table);
            richTextBox1.Text = txt;
        }

        /// <summary>
        /// 界面响应函数
        /// </summary>
        public void BuildEntity(object sender, EventArgs arg)
        {
            string TableName = treeView1.SelectedNode.Text;
            GenerateFiles(TableName);

        }
      
        /// <summary>
        /// 界面响应函数
        /// </summary>
        public void BuildDal(object sender, EventArgs arg)
        {
            string TableName = treeView1.SelectedNode.Text;
            GenerateDal(TableName);
        }

        /// <summary>
        /// 生成DAL操作类
        /// </summary>
        /// <param name="TableName"></param>
        public void GenerateDal(string TableName)
        {
            //准备工作
            string sql = BuildQueryStr(TableName);
            DataTable table = DbHelperSQL.Query(sql).Tables[0];
            string MainId = table.Rows[0][0].ToString().Trim();

            // 1.读取模版
            string str = ReadModel("model/DalClass.cs");
            // 2.替换类名
            str = str.Replace("TableNameDAL", TableName + "Dal");
            // 3.替换实体名
            str = str.Replace("TableNameEntity", TableName + "Entity");
            // 4.替换表名
            str = str.Replace("TableName", TableName);
            // 5.替换主键列
            str = str.Replace("MainId", MainId);

            string Dir = "GeneratedFiles/Dal/Generated/";
            if (!Directory.Exists(Dir))
            {
                Directory.CreateDirectory(Dir);
            }
            // 检查文件是否存在
            string FileName = Dir + TableName + "Dal.cs";
            if (File.Exists(FileName))
            {
                //删除文件
                File.Delete(FileName);
            }
            FileStream MyFile = new FileStream(FileName, FileMode.Create);
            StreamWriter Writer = new StreamWriter(MyFile, Encoding.UTF8);
            Writer.Write(str);
            Writer.Close();
            MyFile.Close();
            //Copy依赖文件
            if (!File.Exists(Dir + "/SqlHelper.cs"))
            {
                File.Copy("model/SqlHelper.cs", Dir + "/SqlHelper.cs", true);
                File.Copy("model/CommandInfo.cs", Dir + "/CommandInfo.cs", true);
                File.Copy("model/CompareParam.cs", Dir + "/CompareParam.cs", true);
            }
        }

        /// <summary>
        /// 界面响应函数
        /// </summary>
        public void BuildEntityAll(object sender, EventArgs arg)
        {

            for (int i = 0; i < treeView1.Nodes[0].Nodes.Count; i++)
            {
                if (treeView1.Nodes[0].Nodes[i].Level == 0 || treeView1.Nodes[0].Nodes[i].Level == 2)
                {

                    continue;
                }
                GenerateFiles(treeView1.Nodes[0].Nodes[i].Text.Trim());
            }
            System.Diagnostics.Process.Start("Explorer.exe", System.Environment.CurrentDirectory + "\\GeneratedFiles\\");
        }

        /// <summary>
        /// 界面响应函数
        /// </summary>
        public void BuildDalAll(object sender, EventArgs arg)
        {
            for (int i = 0; i < treeView1.Nodes[0].Nodes.Count; i++)
            {
                if (treeView1.Nodes[0].Nodes[i].Level == 0 || treeView1.Nodes[0].Nodes[i].Level == 2)
                {

                    continue;
                }
                GenerateDal(treeView1.Nodes[0].Nodes[i].Text.Trim());
            }
            System.Diagnostics.Process.Start("Explorer.exe", System.Environment.CurrentDirectory + "\\GeneratedFiles\\");
        }

        /// <summary>
        /// 构造查询字段信息的SQL语句
        /// </summary>
        /// <param name="TableName"></param>
        private string BuildQueryStr(string TableName)
        {
            StringBuilder StrBuilder = new StringBuilder();
            StrBuilder.Append(" SELECT distinct ");
            StrBuilder.Append(" ColumnName= convert(varchar(100), a.name),");
            StrBuilder.Append(" TableName= convert(varchar(50), d.name ),");
            StrBuilder.Append(" DataType= CONVERT(varchar(50),b.name),");
            StrBuilder.Append(" ColumnDescipt=convert(varchar(50), isnull(g.[value],''))");
            StrBuilder.Append(" FROM dbo.syscolumns a");
            StrBuilder.Append(" left join dbo.systypes b on a.xusertype=b.xusertype");
            StrBuilder.Append(" inner join dbo.sysobjects d on a.id=d.id and (d.xtype='U' or d.xtype='V' ) and d.name<>'dtproperties'");
            StrBuilder.Append(" left join dbo.syscomments e on a.cdefault=e.id");
            StrBuilder.Append(" left join sys.extended_properties g on a.id=g.major_id and a.colid=g.minor_id");
            StrBuilder.Append(" left join sys.extended_properties f on d.id=f.major_id and f.minor_id=0");
            StrBuilder.Append(" where d.name ='{0}'");
            string ret = string.Format(StrBuilder.ToString(), TableName);
            return ret;
        }

        /// <summary>
        /// 构造查询表主键字段的SQL语句
        /// </summary>
        /// <returns></returns>
        private string BuildQueryPrimaryKeyStr(string tablename)
        {
            StringBuilder StrBuilder = new StringBuilder();
            StrBuilder.Append(" select o.name as tablename,c.name as Columnname,k.colid as ColumnSeq,k.keyno as IndexSeq ");
            StrBuilder.Append(" from sysindexes i");
            StrBuilder.Append(" join sysindexkeys k on i.id = k.id and i.indid = k.indid");
            StrBuilder.Append(" join sysobjects o on i.id = o.id");
            StrBuilder.Append(" join syscolumns c on i.id=c.id and k.colid = c.colid");
            StrBuilder.Append(" where (o.xtype = 'U' or o.xtype = 'V') ");
            StrBuilder.Append(" and exists(select 1 from sysobjects where xtype = 'PK' and name = ");
            StrBuilder.Append(" i.name) and o.name='{0}'");
            StrBuilder.Append(" order by o.name,k.colid");
            string ret = string.Format(StrBuilder.ToString(), tablename);
            return ret;
        }


        /// <summary>
        /// 生成文件入口方法 
        /// </summary>
        /// <param name="TableName">表名</param>
        private void GenerateFiles(string TableName)
        {
            // 1.生成查询语句
            string sql = BuildQueryStr(TableName);
            // 2.取得数据表
            DataTable table = DbHelperSQL.Query(sql).Tables[0];
            // 3.生成文件
            BuildFile(TableName, table);
        }

        /// <summary>
        /// 保存文件
        /// </summary>
        private void BuildFile(string TableName, DataTable table)
        {
            /*0.检查文件夹是否存在*/ 
            string Dir = "GeneratedFiles/Model/Generated/";
            if (!Directory.Exists(Dir))
            {
                Directory.CreateDirectory(Dir);
            }

            /*1.检查文件是否存在*/ 
            string FileName = Dir + TableName + "Entity.cs";
            if (File.Exists(FileName))
            {
                /*删除文件*/
                File.Delete(FileName);
            }
            /*写文件*/
            FileStream MyFile = new FileStream(FileName, FileMode.Create);
            StreamWriter Writer = new StreamWriter(MyFile, Encoding.UTF8);
            /*生成文件内容并写入文件*/
            Writer.Write(BuildFileContent(TableName, table));
            /*关闭*/
            Writer.Close();
            MyFile.Close();
        }

        /// <summary>
        /// 生成Model类实体函数
        /// </summary>
        private string BuildFileContent(string TableName, DataTable table)
        {
            /*文件内容构造变量*/
            StringBuilder StrBuild = new StringBuilder();
            /*模版文件读取器*/
            ModelXmlRead XmlReader = new ModelXmlRead("ModelConfig.xml");

            /*1 生成using及文件说明语句*/
            string str = XmlReader.ReadXmlNode("//EntityHead").Replace("&lt;", "<").Replace("&gt;", ">");
            str = str.Replace("Date", System.DateTime.Now.ToLongDateString()).Replace("Time", System.DateTime.Now.ToLongTimeString());
            StrBuild.Append(str);

            /*2 生成名称空间及类名*/
            str = XmlReader.ReadXmlNode("//EntityBegin").Replace("&lt;", "<").Replace("&gt;", ">");
            str = str.Replace("ClassName", TableName);
            StrBuild.Append(str);

            /*3 生成数据库主键字段名数组*/
            StrBuild.Append(BlankSpace(6) + "#region 主键字段数组，存储主键字段列名。");
            StrBuild.Append(System.Environment.NewLine);
            StrBuild.Append(BlankSpace(6) + "private string[] _PrimaryKeys = {");
            /* 查询主键字段*/
            DataTable PrimaryKeyTb = DbHelperSQL.Query(BuildQueryPrimaryKeyStr(TableName)).Tables[0];
            if (PrimaryKeyTb != null && PrimaryKeyTb.Rows.Count > 0)
            {
                string NameStr = "";
                foreach (DataRow Row in PrimaryKeyTb.Rows)
                {
                    NameStr += "\"" + Row["Columnname"].ToString() + "\",";
                }
                NameStr = NameStr.Substring(0, NameStr.Length - 1);
                StrBuild.Append(NameStr);
            }
            StrBuild.Append("};");
            StrBuild.Append(System.Environment.NewLine);
            StrBuild.Append(BlankSpace(6) + "#endregion");
            StrBuild.Append(System.Environment.NewLine);

            /*4 生成私有成员变量*/
            str = XmlReader.ReadXmlNode("//EntityMember").Replace("&lt;", "<").Replace("&gt;", ">");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string tmp = str;
                tmp = tmp.Replace("FieldName", table.Rows[i]["ColumnName"].ToString());
                tmp = tmp.Replace("FieldType", DBTypeToDotNetDataType(table.Rows[i]["DataType"].ToString().Trim()));
                tmp = tmp.Replace("DbTypeValue", "\"" + table.Rows[i]["DataType"].ToString().Trim() + "\"");
                StrBuild.Append(tmp);
            }

            /*5 生成构造函数*/
            str = XmlReader.ReadXmlNode("//EntityConstructor").Replace("&lt;", "<").Replace("&gt;", ">");
            str = str.Replace("ClassName", TableName);
            StrBuild.Append(str);
            StrBuild.Append(System.Environment.NewLine);

            /*6 返回主键字段名数组(PrimaryKeys方法)*/ 
            StrBuild.Append(BlankSpace(6) + "/// <summary>");
            StrBuild.Append(System.Environment.NewLine);
            StrBuild.Append(BlankSpace(6) + "/// 返回主键字段名数组");
            StrBuild.Append(System.Environment.NewLine);
            StrBuild.Append(BlankSpace(6) + "///</summary>");
            StrBuild.Append(System.Environment.NewLine);
            StrBuild.Append(BlankSpace(6) + "///<returns>返回主键字段名数组</returns>");
            StrBuild.Append(System.Environment.NewLine);
            StrBuild.Append(BlankSpace(6) + "public string[] PrimaryKeys()");
            StrBuild.Append(System.Environment.NewLine);
            StrBuild.Append(BlankSpace(6) + "{");
            StrBuild.Append(System.Environment.NewLine);
            StrBuild.Append(BlankSpace(8) + "return _PrimaryKeys;");
            StrBuild.Append(System.Environment.NewLine);
            StrBuild.Append(BlankSpace(6) + "}");
            StrBuild.Append(System.Environment.NewLine);

            /*7 生成属性*/
            str = XmlReader.ReadXmlNode("//EntityProperty").Replace("&lt;", "<").Replace("&gt;", ">"); ;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string tmp = str;
                tmp = tmp.Replace("FieldName", table.Rows[i]["ColumnName"].ToString().Trim());
                tmp = tmp.Replace("FieldType", DBTypeToDotNetDataType(table.Rows[i]["DataType"].ToString().Trim()));
                tmp = tmp.Replace("Descriptions", table.Rows[i]["ColumnDescipt"].ToString().Trim());
                StrBuild.Append(tmp);
            }

            /*8 生成GetPrimaryKeys方法*/
            str = XmlReader.ReadXmlNode("//EntityPrimaryKey").Replace("&lt;", "<").Replace("&gt;", ">"); ;
            StrBuild.Append(str);

            /*9 生成类结束*/
            str = XmlReader.ReadXmlNode("//EntityEnd").Replace("&lt;", "<").Replace("&gt;", ">"); ;
            StrBuild.Append(str);
            return StrBuild.ToString();
        }

        /// <summary>
        /// 根据传入参数生成相应数量空格
        /// </summary>
        private string BlankSpace(int k)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < k; i++)
            {
                sb.Append(" ");
            }
            return sb.ToString();
        }

        /// <summary>
        /// 读取模版(文本文件模版)
        /// </summary>
        public static string ReadModel(string FileName)
        {
            StringBuilder StrBuild = new StringBuilder();
            StreamReader sr = new StreamReader(FileName, Encoding.Default);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                StrBuild.Append(line.ToString() + System.Environment.NewLine);
            }
            sr.Close();
            return StrBuild.ToString();
        }

        /// <summary>
        /// 读取模版
        /// </summary>
        private string ReadModel(string FileName, int i)
        {
            StringBuilder StrBuild = new StringBuilder();
            StreamReader sr = new StreamReader(FileName, Encoding.Default);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                StrBuild.Append(BlankSpace(i) + line.ToString() + System.Environment.NewLine);
            }
            sr.Close();
            return StrBuild.ToString();
        }


        #region .Net数据类型与SqlServer数据类型转化

        /// <summary>
        /// 根据数据库字段类型，转化为.net的数据类型。
        /// </summary>
        /// <returns></returns>
        public string TypeConvert(string DataType, string tmp)
        {
            switch (DataType)
            {
                #region 数字类,货币类
                case "tinyint":
                    tmp = tmp.Replace("FieldType", "UInt16");
                    tmp = tmp.Replace("initValue", "System.UInt16.MinValue");
                    break;
                case "smallint":
                    tmp = tmp.Replace("FieldType", "Int16");
                    tmp = tmp.Replace("initValue", "System.Int16.MinValue");
                    break;
                case "int":
                    tmp = tmp.Replace("FieldType", "int");
                    tmp = tmp.Replace("initValue", "int.MinValue");
                    break;
                case "bigint":
                    tmp = tmp.Replace("FieldType", "Int64");
                    tmp = tmp.Replace("initValue", "System.Int64.MinValue");
                    break;
                case "decimal":
                    tmp = tmp.Replace("FieldType", "double");
                    tmp = tmp.Replace("initValue", "System.Double.MinValue");
                    break;
                case "float":
                    tmp = tmp.Replace("FieldType", "float");
                    tmp = tmp.Replace("initValue", "System.float.MinValue");
                    break;
                case "numeric":
                    tmp = tmp.Replace("FieldType", "double");
                    tmp = tmp.Replace("initValue", "System.double.MinValue");
                    break;
                case "real":
                    tmp = tmp.Replace("FieldType", "float");
                    tmp = tmp.Replace("initValue", "System.float.MinValue");
                    break;
                case "money":
                    tmp = tmp.Replace("FieldType", "double");
                    tmp = tmp.Replace("initValue", "System.double.MinValue");
                    break;
                case "smallmoney":
                    tmp = tmp.Replace("FieldType", "double");
                    tmp = tmp.Replace("initValue", "System.double.MinValue");
                    break;
                #endregion

                #region 二进制类
                case "bit":
                    tmp = tmp.Replace("FieldType", "bool");
                    tmp = tmp.Replace("initValue", "false");
                    break;
                case "binary":
                    tmp = tmp.Replace("FieldType", "int[]");
                    tmp = tmp.Replace("initValue", "null");
                    break;
                case "varbinary":
                    tmp = tmp.Replace("FieldType", "int[]");
                    tmp = tmp.Replace("initValue", "null");
                    break;
                case "image":
                    tmp = tmp.Replace("FieldType", "int[]");
                    tmp = tmp.Replace("initValue", "null");
                    break;
                #endregion

                #region 时间,日期类
                case "datetime":
                    tmp = tmp.Replace("FieldType", "DateTime");
                    tmp = tmp.Replace("initValue", "System.DateTime.MinValue");
                    break;
                case "date":
                    tmp = tmp.Replace("FieldType", "DateTime");
                    tmp = tmp.Replace("initValue", "System.DateTime.MinValue");
                    break;
                case "smalldatetime":
                    tmp = tmp.Replace("FieldType", "DateTime");
                    tmp = tmp.Replace("initValue", "System.DateTime.MinValue");
                    break;
                case "datetime2":
                    tmp = tmp.Replace("FieldType", "DateTime");
                    tmp = tmp.Replace("initValue", "System.DateTime.MinValue");
                    break;
                case "datetimeoffset":
                    tmp = tmp.Replace("FieldType", "DateTime");
                    tmp = tmp.Replace("initValue", "System.DateTime.MinValue");
                    break;
                case "time7":
                    tmp = tmp.Replace("FieldType", "DateTime");
                    tmp = tmp.Replace("initValue", "System.DateTime.MinValue");
                    break;
                case "timestamp":
                    tmp = tmp.Replace("FieldType", "UInt64");
                    tmp = tmp.Replace("initValue", "System.UInt64.MinValue");
                    break;
                #endregion

                #region 字符，字符串类

                case "char":
                    tmp = tmp.Replace("FieldType", "string");
                    tmp = tmp.Replace("initValue", "System.String.Empty");
                    break;
                case "nchar":
                    tmp = tmp.Replace("FieldType", "string");
                    tmp = tmp.Replace("initValue", "System.String.Empty");
                    break;
                case "ntext":
                    tmp = tmp.Replace("FieldType", "string");
                    tmp = tmp.Replace("initValue", "System.String.Empty");
                    break;
                case "text":
                    tmp = tmp.Replace("FieldType", "string");
                    tmp = tmp.Replace("initValue", "System.String.Empty");
                    break;
                case "nvarchar":
                    tmp = tmp.Replace("FieldType", "string");
                    tmp = tmp.Replace("initValue", "System.String.Empty");
                    break;
                case "varchar":
                    tmp = tmp.Replace("FieldType", "string");
                    tmp = tmp.Replace("initValue", "System.String.Empty");
                    break;

                #endregion

                #region 其它
                case "xml":
                    tmp = tmp.Replace("FieldType", "string");
                    tmp = tmp.Replace("initValue", "System.String.Empty");
                    break;
                case "uniqueidentifier":
                    tmp = tmp.Replace("FieldType", "UInt16");
                    tmp = tmp.Replace("initValue", "System.UInt16.MinValue");
                    break;
                #endregion

                default:
                    tmp = tmp.Replace("FieldType", "string");
                    tmp = tmp.Replace("initValue", "null");
                    break;
            }
            return tmp;
        }

        /// <summary>
        /// SqlServer 数据类型对应.Net 的 DBType数据类型
        /// </summary>
        public string DBTypeToDotNetDataType(string DBType)
        {
            switch (DBType)
            {
                case "bigint":
                    return "System.Int64";
                case "binary":
                    return "System.Byte[]";
                case "bit":
                    return "System.Boolean";
                case "char":
                    return "System.String";
                case "datetime":
                    return "System.DateTime";
                case "datetime2":
                    return "System.DateTime";
                case "date"://DateTime.ToString("yyyy-MM-dd")
                    return "System.DateTime";
                case "decimal":
                    return "System.Decimal";
                case "float":
                    return "System.Double";
                case "image":
                    return "System.Byte[]";
                case "int":
                    return "System.Int32";
                case "money":
                    return " System.Decimal";
                case "nchar":
                    return "System.String";
                case "ntext":
                    return "System.String";
                case "numeric":
                    return "System.Decimal";
                case "nvarchar":
                    return "System.String";
                case "real":
                    return "System.Single";
                case "uniqueidentifier":
                    return "System.Guid";
                case "smalldatetime":
                    return "System.DateTime";
                case "smallint":
                    return "System.Int16";
                case "smallmoney":
                    return "System.Decimal";
                case "text":
                    return "System.String";
                case "timestamp":
                    return "System.Byte[]";
                case "tinyint":
                    return "System.Byte";
                case "varbinary":
                    return "System.Byte[]";
                case "varchar":
                    return "System.String";
                case "sql_variant":
                    return "System.Object";
                case "xml":
                    return "System.String";
                default:
                    return "无对应数据类型:" + DBType;
            }
        }


        /// <summary>
        /// SqlServer 数据类型对应.Net 的 SqlDbType数据类型
        /// </summary>
        public string DBTypeToDotNetDBType(string DBType)
        {
            switch (DBType)
            {
                case "bigint":
                    return "System.Data.SqlDbType.BigInt";
                case "binary":
                    return "System.Data.SqlDbType.Binary";
                case "bit":
                    return "System.Data.SqlDbType.Bit";
                case "char":
                    return "System.Data.SqlDbType.Char";
                case "datetime":
                    return "System.Data.SqlDbType.DateTime";
                case "decimal":
                    return "System.Data.SqlDbType.Decimal";
                case "float":
                    return "System.Data.SqlDbType.Float";
                case "image":
                    return "System.Data.SqlDbType.Image";
                case "int":
                    return "System.Data.SqlDbType.Int";
                case "money":
                    return "System.Data.SqlDbType.Money";
                case "nchar":
                    return "System.Data.SqlDbType.NChar";
                case "ntext":
                    return "System.Data.SqlDbType.NText";
                case "numeric":
                    return "System.Data.SqlDbType.Decimal";
                case "nvarchar":
                    return "System.Data.SqlDbType.NVarChar";
                case "real":
                    return "System.Data.SqlDbType.Real";
                case "uniqueidentifier":
                    return "System.Data.SqlDbType.UniqueIdentifier";
                case "smalldatetime":
                    return "System.Data.SqlDbType.SmallDateTime";
                case "smallint":
                    return "System.Data.SqlDbType.SmallInt";
                case "smallmoney":
                    return "System.Data.SqlDbType.SmallMoney";
                case "text":
                    return "System.Data.SqlDbType.Text";
                case "timestamp":
                    return "System.Data.SqlDbType.Timestamp";
                case "tinyint":
                    return "System.Data.SqlDbType.TinyInt";
                case "varbinary":
                    return "System.Data.SqlDbType.VarBinary";
                case "varchar":
                    return "System.Data.SqlDbType.VarChar";
                case "variant":
                    return "System.Data.SqlDbType.Variant";
                case "udt":
                    return "System.Data.SqlDbType.Udt";
                default:
                    return "无对应数据类型:" + DBType;
            }
        }

        #endregion

    }
}
