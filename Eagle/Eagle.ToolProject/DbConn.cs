using Eagle.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Eagle.ToolProject
{
    public delegate void PopulateTables_Delegate();

    public partial class DbConn : Form
    {
        /*定义事件 绑定树*/
        public PopulateTables_Delegate PopulateTables_Handle;
        
        /*临时连接字符串*/
        public string ConnectionString;

        /// <summary>
        /// 构造函数
        /// </summary>
        public DbConn()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 测试连接到数据库
        /// </summary>
        /// <returns>true:成功 false:失败</returns>
        private bool TryConnection()
        {
            /*创建测试连接对象*/
            SqlConnection conn = new SqlConnection();
            /*数据库地址和端口号*/
            string Server = TxtIp.Text.Trim();
            /*数据库名*/
            string Database = TxtDb.Text.Trim();
            /*数据库用户*/
            string UserID = TxtAccount.Text.Trim();
            /*密码*/
            string Password = TxtPwd.Text.Trim();
            /*重组成连接数据库字符串*/
            ConnectionString= String.Format("Server={0};Database={1};User ID={2};Password={3};Trusted_Connection=False;", Server, Database, UserID, Password);;
            conn.ConnectionString = ConnectionString;
            try
            {
                /*打开*/
                conn.Open();
                /*关闭*/
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        /// <summary>
        ///  事件响应 测试连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (TryConnection())
            {
                /*连接成功，将新的连接串保存到配置文件*/
                if (!string.IsNullOrEmpty(Config.Config.ConnectionString))
                {
                    BaseConfigInfo objBaseConfigInfo=new BaseConfigInfo();
                    objBaseConfigInfo.Dbconnectstring=ConnectionString;
                    objBaseConfigInfo.Dbtype = "";
                    BaseConfigs.SaveConfig(objBaseConfigInfo);
                }
                else
                {
                    BaseConfigInfo objBaseConfigInfo = new BaseConfigInfo();
                    objBaseConfigInfo.Dbconnectstring = ConnectionString;
                    BaseConfigs.SaveConfig(objBaseConfigInfo);
                }
                MessageBox.Show("连接成功");
            }
        }

        /// <summary>
        /// 事件响应 确定按钮
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            /*执行事件 绑定树*/
            PopulateTables_Handle();
            this.Close();
        }
    }
}
