using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eagle.DBUtility
{
    /// <summary>
    /// 比较参数枚举
    /// </summary>
    public enum CompareParam : int
    {
        /// <summary>
        /// =
        /// </summary>
        Equal,

        /// <summary>
        /// <>
        /// </summary>
        NotEqual,

        /// <summary>
        /// >
        /// </summary>
        GreaterThan,

        /// <summary>
        /// >=
        /// </summary>
        GreaterOrEqual,

        /// <summary>
        /// <
        /// </summary>
        LessThan,

        /// <summary>
        /// 小于等于
        /// </summary>
        LessOrEqual,

        /// <summary>
        /// between and
        /// </summary>
        BetweenAnd,

        /// <summary>
        /// like
        /// </summary>
        Like,

        /// <summary>
        /// not like
        /// </summary>
        NotLike
    }
}
