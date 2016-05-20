using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eagle.Config
{
    /// <summary>
    /// 基本设置描述类, 加[Serializable]标记为可序列化
    /// </summary>
    [Serializable]
    public class BaseConfigInfo : IConfigInfo
    {
        #region 私有字段

        private string m_dbconnectstring = "Data Source=10.11.1.251;User ID=sa;Password=cq.centaline;Initial Catalog=tz_test;Pooling=true";		// 数据库连接串-格式(中文为用户修改的内容)：Data Source=数据库服务器地址;User ID=您的数据库用户名;Password=您的数据库用户密码;Initial Catalog=数据库名称;Pooling=true
        private string m_tableprefix = "dnt_";		// 数据库中表的前缀
        private string m_forumpath = "/";			// 论坛在站点内的路径
        private string m_dbtype = "SqlServer";
        private int m_founderuid = 0;				// 创始人
        private string watermarkAddress;            //水印地址
        private string watermarkPosition;           //水印位置

        #endregion

        #region 属性

        /// <summary>
        /// 数据库连接串
        /// 格式(中文为用户修改的内容)：
        ///    Data Source=数据库服务器地址;
        ///    User ID=您的数据库用户名;
        ///    Password=您的数据库用户密码;
        ///    Initial Catalog=数据库名称;Pooling=true
        /// </summary>
        public string Dbconnectstring
        {
            get { return m_dbconnectstring; }
            set { m_dbconnectstring = value; }
        }

        /// <summary>
        /// 数据库中表的前缀
        /// </summary>
        public string Tableprefix
        {
            get { return m_tableprefix; }
            set { m_tableprefix = value; }
        }

        /// <summary>
        /// 论坛在站点内的路径
        /// </summary>
        public string Forumpath
        {
            get { return m_forumpath; }
            set { m_forumpath = value; }
        }

        /// <summary>
        /// 数据库类型
        /// </summary>
        public string Dbtype
        {
            get { return m_dbtype; }
            set { m_dbtype = value; }
        }

        /// <summary>
        /// 创始人ID
        /// </summary>
        public int Founderuid
        {
            get { return m_founderuid; }
            set { m_founderuid = value; }
        }

        /// <summary>
        /// 水印地址
        /// </summary>
        public string WatermarkAddress
        {
            get { return watermarkAddress; }
            set { watermarkAddress = value; }
        }

        /// <summary>
        /// 水印在图片中的位置[默认右下角] topleft,左上 topright,右上 tailleft,左下 tailright,右下 center,居中 
        /// </summary>
        public string WatermarkPosition
        {
            get { return watermarkPosition; }
            set { watermarkPosition = value; }
        }

        #endregion
    }
}
