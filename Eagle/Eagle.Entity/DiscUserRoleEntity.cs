
    /// <summary>
    /// 说  明：本代码由工具软件生成，数据库设计发生变化后，应重新自动生成。
    /// 日  期：2015年10月09日 23:26:35
    /// 作  者：陈卓
    /// 邮  箱：838010363@qq.com
    /// </summary>
    using Eagle.DBUtility;
    using Eagle.Interface;
    using System.Collections.Generic;
    using System.Reflection;
  
    namespace Eagle.Entity
    {
      /// <summary>
      /// 数据库表DiscUserRole所对应的实体类
      /// </summary>
    public partial class DiscUserRoleEntity:IEntity
    {
        #region 主键字段数组，存储主键字段列名。
      private string[] _PrimaryKeys = {"UserRoleId"};
      #endregion

          #region 成员变量:_RoleId
          private System.Int32 _RoleId;
          private bool _RoleIdChanged = false;
          CompareParam _RoleIdCompareParam = CompareParam.Equal;
          public string _RoleIdDbType = "int";
          #endregion
  
          #region 成员变量:_UserId
          private System.Int32 _UserId;
          private bool _UserIdChanged = false;
          CompareParam _UserIdCompareParam = CompareParam.Equal;
          public string _UserIdDbType = "int";
          #endregion
  
          #region 成员变量:_UserRoleId
          private System.Int32 _UserRoleId;
          private bool _UserRoleIdChanged = false;
          CompareParam _UserRoleIdCompareParam = CompareParam.Equal;
          public string _UserRoleIdDbType = "int";
          #endregion
  
          /// <summary>
          /// 构造函数
          /// </summary>
          public DiscUserRoleEntity()
          {

          }
  
      /// <summary>
      /// 返回主键字段名数组
      ///</summary>
      ///<returns>返回主键字段名数组</returns>
      public string[] PrimaryKeys()
      {
        return _PrimaryKeys;
      }

        /// <summary>
        /// 说明: 角色Id
        /// </summary>
        public System.Int32 RoleId
        {
          get { return _RoleId; }
          set {
                _RoleId = value;
                RoleIdChanged=true;
              }
        }

        /// <summary>
        /// 属性: _RoleIdChanged
        /// </summary>
        public bool RoleIdChanged
        {
          get { return _RoleIdChanged;}
          set {
                _RoleIdChanged=value;
              }
        }

        /// <summary>
        /// 属性: _RoleIdCompareParam
        /// </summary>
        public CompareParam RoleIdCompareParam
        {
          get { return _RoleIdCompareParam ;}
          set {
                _RoleIdCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _RoleId的数据库存储类型
        /// </summary>
        public string RoleIdDbType
        {
          get { 
                return _RoleIdDbType;
              }
        }
  
        /// <summary>
        /// 说明: 用户Id
        /// </summary>
        public System.Int32 UserId
        {
          get { return _UserId; }
          set {
                _UserId = value;
                UserIdChanged=true;
              }
        }

        /// <summary>
        /// 属性: _UserIdChanged
        /// </summary>
        public bool UserIdChanged
        {
          get { return _UserIdChanged;}
          set {
                _UserIdChanged=value;
              }
        }

        /// <summary>
        /// 属性: _UserIdCompareParam
        /// </summary>
        public CompareParam UserIdCompareParam
        {
          get { return _UserIdCompareParam ;}
          set {
                _UserIdCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _UserId的数据库存储类型
        /// </summary>
        public string UserIdDbType
        {
          get { 
                return _UserIdDbType;
              }
        }
  
        /// <summary>
        /// 说明: 用户角色Id
        /// </summary>
        public System.Int32 UserRoleId
        {
          get { return _UserRoleId; }
          set {
                _UserRoleId = value;
                UserRoleIdChanged=true;
              }
        }

        /// <summary>
        /// 属性: _UserRoleIdChanged
        /// </summary>
        public bool UserRoleIdChanged
        {
          get { return _UserRoleIdChanged;}
          set {
                _UserRoleIdChanged=value;
              }
        }

        /// <summary>
        /// 属性: _UserRoleIdCompareParam
        /// </summary>
        public CompareParam UserRoleIdCompareParam
        {
          get { return _UserRoleIdCompareParam ;}
          set {
                _UserRoleIdCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _UserRoleId的数据库存储类型
        /// </summary>
        public string UserRoleIdDbType
        {
          get { 
                return _UserRoleIdDbType;
              }
        }
  
        /// <summary>
        /// 返回主键字段PropertyInfo集合
        /// </summary>
        /// PropertyInfo集合
        public List<PropertyInfo> GetPrimaryKeys()
        {
              List<PropertyInfo> RetList = new List<PropertyInfo>();
              if(_PrimaryKeys==null||_PrimaryKeys.Length==0)
              {
              return RetList;
              }
              foreach(string key in _PrimaryKeys)
              {
                  RetList.Add(this.GetType().GetProperty(key));
              }
              return RetList;
         }
  
  }
     }
  