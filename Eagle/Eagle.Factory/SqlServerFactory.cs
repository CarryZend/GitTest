using Eagle.Data;
using Eagle.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eagle.Factory
{
    /// <summary>
    /// 名  称：SqlServer工厂类
    /// 说  明：1.工厂类(创建访问SqlServer数据库的DAL),实现所有的创建逻辑。
    ///         2.本文件必须实现IDbFactory<T>接口中的所有方法
    /// </summary>
    public class SqlServerFactory<T> : IDbFactory<T> where T : IEntity, new()
    {
        public IGenericDataAccessLayer<T> CreateDalObject()
        {
            return new SqlDataAccessLayer<T>();
        }
    }
}
