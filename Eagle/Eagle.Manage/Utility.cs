using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Eagle.Manage
{
    public class Utility
    {
        /// <summary>
        /// 编码
        /// </summary>
        public static string Encode(string strValue)
        {
            return HttpUtility.UrlEncode(strValue, Encoding.GetEncoding("UTF-8"));
        }

        /// <summary>
        /// 解码
        /// </summary>
        public static string Decode(string strValue)
        {
            return HttpUtility.UrlDecode(strValue, Encoding.GetEncoding("UTF-8"));

        }
    }
}
