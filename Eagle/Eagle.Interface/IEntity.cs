using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Eagle.Interface
{
    /// <summary>
    /// 名  称：实体对象基接口
    /// 说  明：1.该接口是数据库表实体对象的接口，生成的实体对象必须实现IEntity接口文件中所有的方法。
    ///         2.如果实体对象要增加方法，务必将新方法的签名加到IEntity接口文件中,否则可能导致在相应的DAL中，无法调用新增加的方法。
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// 获取主键字段方法
        /// </summary>
        /// <returns></returns>
        List<PropertyInfo> GetPrimaryKeys();
    }
}
