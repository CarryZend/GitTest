using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Eagle.ToolProject
{
    public class ModelXmlRead
    {
        /*Xml文件名（包含地址）*/
        private string XmlFileName;

        /*初始化函数*/
        public ModelXmlRead(string InXmlFileName)
        {
            XmlFileName = InXmlFileName;
        }

        /// <summary>    
        /// 读取xml中的指定节点的值
        /// </summary>    
        public string ReadXmlNode(string Xpath)
        {
            /*创建对象*/
            XmlDocument XmlDoc = new XmlDocument();
            /*XmlDocument对象加载文件*/
            XmlDoc.Load(XmlFileName);
            /*读取指定文件*/
            XmlNode Node = XmlDoc.SelectSingleNode(Xpath);
            /*返回节点文本*/
            if (Node != null)
            {
                return Node.InnerText;
            }
            else
            {
                return "";
            }
        }
    }

}
