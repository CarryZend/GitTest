
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
      /// 数据库表DiscRole所对应的实体类
      /// </summary>
    public partial class DiscRoleEntity:IEntity
    {
        #region 主键字段数组，存储主键字段列名。
      private string[] _PrimaryKeys = {"RoleId"};
      #endregion

          #region 成员变量:_RoleId
          private System.Int32 _RoleId;
          private bool _RoleIdChanged = false;
          CompareParam _RoleIdCompareParam = CompareParam.Equal;
          public string _RoleIdDbType = "int";
          #endregion
  
          #region 成员变量:_RoleName
          private System.String _RoleName;
          private bool _RoleNameChanged = false;
          CompareParam _RoleNameCompareParam = CompareParam.Equal;
          public string _RoleNameDbType = "nvarchar";
          #endregion
  
          /// <summary>
          /// 构造函数
          /// </summary>
          public DiscRoleEntity()
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
        /// 说明: 角色名称
        /// </summary>
        public System.String RoleName
        {
          get { return _RoleName; }
          set {
                _RoleName = value;
                RoleNameChanged=true;
              }
        }

        /// <summary>
        /// 属性: _RoleNameChanged
        /// </summary>
        public bool RoleNameChanged
        {
          get { return _RoleNameChanged;}
          set {
                _RoleNameChanged=value;
              }
        }

        /// <summary>
        /// 属性: _RoleNameCompareParam
        /// </summary>
        public CompareParam RoleNameCompareParam
        {
          get { return _RoleNameCompareParam ;}
          set {
                _RoleNameCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _RoleName的数据库存储类型
        /// </summary>
        public string RoleNameDbType
        {
          get { 
                return _RoleNameDbType;
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
  