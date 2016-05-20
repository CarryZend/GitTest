/// <summary>
/// 名    称：配置文件访问类
/// 说    明：1.该接口是数据库表实体对象的接口，生成的实体对象必须实现IEntity接口文件中所有的方法。
///           2.如果实体对象要增加方法，务必将新方法的签名加到IEntity接口文件中,否则可能导致在相应的DAL中，无法调用新增加的方法。
/// 修改时间：2015年09月02日
/// 修改作者：陈卓
/// 邮    箱：838010363@qq.com
/// </summary>

using Eagle.Common.DEncrypt;
using System;
using System.Configuration;
using System.Xml;

namespace Eagle.Config
{
    /// <summary>
    /// 本类主要用于读取,修改配置文件的各个配置参数。
    /// </summary>
    public class Config
    {
        /// <summary>
        /// 读取默认的连接字符串,如果有加密，并解密。
        /// </summary>
        public static string ConnectionString
        {
            get
            {
                /*读取连接字符串*/
                string _connectionString = GetAppSetting("ConnectionString");
                /*读取是否加密节点*/
                string ConStringEncrypt = GetAppSetting("ConStringEncrypt");
                /*如果有加密，则解密*/
                if (ConStringEncrypt != null && ConStringEncrypt == "true")
                {
                    _connectionString = DESEncrypt.Decrypt(_connectionString);
                }
                /*返回明文的连接字符串*/
                return _connectionString;
            }
        }

        /// <summary>
        /// 读取指定的AppSettings节点，并解密。
        /// </summary>
        /// <param name="key">节点名称</param>
        /// <returns>节点内容</returns>
        public static string GetAppSettingDecrypt(string key)
        {
            /*读取指定的节点*/
            string value = GetAppSetting(key);
            /*解密*/
            value = DESEncrypt.Decrypt(value);
            return value;
        }

        /// <summary>
        /// 根据Key取Value值
        /// </summary>
        /// <param name="key">节点名称</param>
        public static string GetAppSetting(string key)
        {
            if (ConfigurationManager.AppSettings[key] != null)
            {
                return ConfigurationManager.AppSettings[key].ToString().Trim();
            }
            else
            {
                return null;
            }
        }


        ///<summary>  
        ///向.config文件的appKey结写入信息AppValue保存设置  
        ///</summary>  
        ///<param name="AppKey">节点名</param>  
        ///<param name="AppValue">值</param>
        public static void SetValue(String AppKey, String AppValue)
        {
            /*创建XmlDocument对象*/
            XmlDocument xDoc = new XmlDocument();
            /*加载配置文件*/
            xDoc.Load(System.Windows.Forms.Application.ExecutablePath + ".config");
            /*定义节点对象*/
            XmlNode xNode;
            XmlElement xElem1;
            XmlElement xElem2;
            xNode = xDoc.SelectSingleNode("//appSettings");
            xElem1 = (XmlElement)xNode.SelectSingleNode("//add[@key='" + AppKey + "']");
            if (xElem1 != null)
            {
                /*存在节点，修改值*/
                xElem1.SetAttribute("value", AppValue);
            }
            else
            {
                /*不存在节点，增加节点*/
                xElem2 = xDoc.CreateElement("add");
                xElem2.SetAttribute("key", AppKey);
                xElem2.SetAttribute("value", AppValue);
                xNode.AppendChild(xElem2);
            }
            /*保存配置文件*/
            xDoc.Save(System.Windows.Forms.Application.ExecutablePath + ".config");
        }
        
        /// <summary>
        /// 根据Key修改Value
        /// </summary>
        /// <param name="key">要修改的Key</param>
        /// <param name="value">要修改为的值</param>
        public static void ChangeAppSetting(string key, string value)
        {
           SetValue(key,value);
        }

        /// <summary>
        /// 根据Key修改Value
        /// </summary>
        /// <param name="key">要修改的Key</param>
        /// <param name="value">要修改为的值(加密后存储)</param>
        public static void ChangeAppSettingEncrypt(string key, string value)
        {
            SetValue(key, DESEncrypt.Encrypt(value));
        }

        /// <summary>
        /// 添加新的Key ，Value键值对
        /// </summary>
        /// <param name="key">Key</param>
        /// <param name="value">Value</param>
        public static void AddAppSetting(string key, string value)
        {
            SetValue(key, value);
        }

        /// <summary>
        /// 添加新的Key ，Value键值对
        /// </summary>
        /// <param name="key">Key</param>
        /// <param name="value">Value</param>
        public static void AddAppSettingEncrypt(string key, string value)
        {
            SetValue(key, DESEncrypt.Encrypt(value));
        }

        /// <summary>
        /// 根据Key删除项
        /// </summary>
        /// <param name="key">Key</param>
        public static void RemoveAppSetting(string key)
        {
            ConfigurationManager.AppSettings.Remove(key);
        }

        /// <summary>
        /// 读取数据库类型,应该增加到配置文件当中。该配置节点应直接填写对应工厂类的名称。
        /// </summary>
        public static string ConnectionDbType
        {
            get
            {
                return "Maticsoft.DBUtility.SqlFactory`1";
            }
        }
    }
}
