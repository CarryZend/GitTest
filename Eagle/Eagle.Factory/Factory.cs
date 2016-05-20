using Eagle.Config;
using Eagle.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eagle.Factory
{
    /// <summary>
    /// 工厂类
    /// </summary>
    public class Factory
    {
        /// <summary>
        /// 重要说明：
        ///   第一种： Type ObjectType = Type.GetType("Maticsoft.DBUtility.SqlFactory`1", true, true);未经过验证。
        ///   第二种： Type ObjectType = typeof(SqlFactory<>);经过验证,安全。
        ///   第一种传入格式字符串格式如：Maticsoft.DBUtility.SqlFactory`1
        ///   如倮第一种方法报错，请选用第二种。
        /// </summary>
        public static IGenericDataAccessLayer<T> CreateInstance<T>() where T : IEntity, new()
        {
            /* 1.读取数据库配置文件，查看当前连接的数据库类型 */
            string DbType = BaseConfigs.GetDbType;// Config.ConnectionDbType;
            /* 2.利用反射机制，创建泛型工厂类的类型*/
            Type ObjectType = Type.GetType("Eagle.Factory." + DbType + "Factory`1", true, true);
            /* 3.传入泛型类型*/
            ObjectType = ObjectType.MakeGenericType(typeof(T));
            /* 4.创建实现工厂类接口的具体工厂实例*/
            IDbFactory<T> FactoryInstance = (IDbFactory<T>)Activator.CreateInstance(ObjectType);
            /* 5.调用工厂创建方法，返回工厂创建的实例 */
            return FactoryInstance.CreateDalObject();
        }
    }
}
