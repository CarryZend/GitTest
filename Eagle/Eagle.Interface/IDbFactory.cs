using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eagle.Interface
{
    /// <summary>
    /// 名  称：数据工厂类接口
    /// 说  明：1.工厂类接口文件.
    ///         2.工厂类必须实现本接口文件中的所有方法.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDbFactory<T> where T : IEntity, new()
    {
        IGenericDataAccessLayer<T> CreateDalObject();
    }
}
