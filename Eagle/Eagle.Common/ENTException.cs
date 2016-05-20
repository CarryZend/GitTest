using System;
using System.Collections.Generic;
using System.Text;

namespace Eagle.Common
{
    /// <summary>
    /// DNT自定义异常类。
    /// </summary>
    public class ENTException : Exception
    {
        public ENTException()
        {
            //
        }


        public ENTException(string msg)
            : base(msg)
        {
            //
        }
    }
}
