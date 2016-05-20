/// <summary>
/// ��    �ƣ������ļ�������
/// ˵    ����1.�ýӿ������ݿ��ʵ�����Ľӿڣ����ɵ�ʵ��������ʵ��IEntity�ӿ��ļ������еķ�����
///           2.���ʵ�����Ҫ���ӷ�������ؽ��·�����ǩ���ӵ�IEntity�ӿ��ļ���,������ܵ�������Ӧ��DAL�У��޷����������ӵķ�����
/// �޸�ʱ�䣺2015��09��02��
/// �޸����ߣ���׿
/// ��    �䣺838010363@qq.com
/// </summary>

using Eagle.Common.DEncrypt;
using System;
using System.Configuration;
using System.Xml;

namespace Eagle.Config
{
    /// <summary>
    /// ������Ҫ���ڶ�ȡ,�޸������ļ��ĸ������ò�����
    /// </summary>
    public class Config
    {
        /// <summary>
        /// ��ȡĬ�ϵ������ַ���,����м��ܣ������ܡ�
        /// </summary>
        public static string ConnectionString
        {
            get
            {
                /*��ȡ�����ַ���*/
                string _connectionString = GetAppSetting("ConnectionString");
                /*��ȡ�Ƿ���ܽڵ�*/
                string ConStringEncrypt = GetAppSetting("ConStringEncrypt");
                /*����м��ܣ������*/
                if (ConStringEncrypt != null && ConStringEncrypt == "true")
                {
                    _connectionString = DESEncrypt.Decrypt(_connectionString);
                }
                /*�������ĵ������ַ���*/
                return _connectionString;
            }
        }

        /// <summary>
        /// ��ȡָ����AppSettings�ڵ㣬�����ܡ�
        /// </summary>
        /// <param name="key">�ڵ�����</param>
        /// <returns>�ڵ�����</returns>
        public static string GetAppSettingDecrypt(string key)
        {
            /*��ȡָ���Ľڵ�*/
            string value = GetAppSetting(key);
            /*����*/
            value = DESEncrypt.Decrypt(value);
            return value;
        }

        /// <summary>
        /// ����KeyȡValueֵ
        /// </summary>
        /// <param name="key">�ڵ�����</param>
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
        ///��.config�ļ���appKey��д����ϢAppValue��������  
        ///</summary>  
        ///<param name="AppKey">�ڵ���</param>  
        ///<param name="AppValue">ֵ</param>
        public static void SetValue(String AppKey, String AppValue)
        {
            /*����XmlDocument����*/
            XmlDocument xDoc = new XmlDocument();
            /*���������ļ�*/
            xDoc.Load(System.Windows.Forms.Application.ExecutablePath + ".config");
            /*����ڵ����*/
            XmlNode xNode;
            XmlElement xElem1;
            XmlElement xElem2;
            xNode = xDoc.SelectSingleNode("//appSettings");
            xElem1 = (XmlElement)xNode.SelectSingleNode("//add[@key='" + AppKey + "']");
            if (xElem1 != null)
            {
                /*���ڽڵ㣬�޸�ֵ*/
                xElem1.SetAttribute("value", AppValue);
            }
            else
            {
                /*�����ڽڵ㣬���ӽڵ�*/
                xElem2 = xDoc.CreateElement("add");
                xElem2.SetAttribute("key", AppKey);
                xElem2.SetAttribute("value", AppValue);
                xNode.AppendChild(xElem2);
            }
            /*���������ļ�*/
            xDoc.Save(System.Windows.Forms.Application.ExecutablePath + ".config");
        }
        
        /// <summary>
        /// ����Key�޸�Value
        /// </summary>
        /// <param name="key">Ҫ�޸ĵ�Key</param>
        /// <param name="value">Ҫ�޸�Ϊ��ֵ</param>
        public static void ChangeAppSetting(string key, string value)
        {
           SetValue(key,value);
        }

        /// <summary>
        /// ����Key�޸�Value
        /// </summary>
        /// <param name="key">Ҫ�޸ĵ�Key</param>
        /// <param name="value">Ҫ�޸�Ϊ��ֵ(���ܺ�洢)</param>
        public static void ChangeAppSettingEncrypt(string key, string value)
        {
            SetValue(key, DESEncrypt.Encrypt(value));
        }

        /// <summary>
        /// ����µ�Key ��Value��ֵ��
        /// </summary>
        /// <param name="key">Key</param>
        /// <param name="value">Value</param>
        public static void AddAppSetting(string key, string value)
        {
            SetValue(key, value);
        }

        /// <summary>
        /// ����µ�Key ��Value��ֵ��
        /// </summary>
        /// <param name="key">Key</param>
        /// <param name="value">Value</param>
        public static void AddAppSettingEncrypt(string key, string value)
        {
            SetValue(key, DESEncrypt.Encrypt(value));
        }

        /// <summary>
        /// ����Keyɾ����
        /// </summary>
        /// <param name="key">Key</param>
        public static void RemoveAppSetting(string key)
        {
            ConfigurationManager.AppSettings.Remove(key);
        }

        /// <summary>
        /// ��ȡ���ݿ�����,Ӧ�����ӵ������ļ����С������ýڵ�Ӧֱ����д��Ӧ����������ơ�
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
