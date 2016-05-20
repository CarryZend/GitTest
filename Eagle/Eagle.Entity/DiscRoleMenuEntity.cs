
    /// <summary>
    /// 说  明：本代码由工具软件生成，数据库设计发生变化后，应重新自动生成。
    /// 日  期：2015年10月09日 23:26:36
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
      /// 数据库表DiscRoleMenu所对应的实体类
      /// </summary>
    public partial class DiscRoleMenuEntity:IEntity
    {
        #region 主键字段数组，存储主键字段列名。
      private string[] _PrimaryKeys = {"RoleMenuId"};
      #endregion

          #region 成员变量:_MenuId
          private System.Int32 _MenuId;
          private bool _MenuIdChanged = false;
          CompareParam _MenuIdCompareParam = CompareParam.Equal;
          public string _MenuIdDbType = "int";
          #endregion
  
          #region 成员变量:_RoleId
          private System.Int32 _RoleId;
          private bool _RoleIdChanged = false;
          CompareParam _RoleIdCompareParam = CompareParam.Equal;
          public string _RoleIdDbType = "int";
          #endregion
  
          #region 成员变量:_RoleMenuId
          private System.Int32 _RoleMenuId;
          private bool _RoleMenuIdChanged = false;
          CompareParam _RoleMenuIdCompareParam = CompareParam.Equal;
          public string _RoleMenuIdDbType = "int";
          #endregion
  
          /// <summary>
          /// 构造函数
          /// </summary>
          public DiscRoleMenuEntity()
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
        /// 说明: 菜单Id
        /// </summary>
        public System.Int32 MenuId
        {
          get { return _MenuId; }
          set {
                _MenuId = value;
                MenuIdChanged=true;
              }
        }

        /// <summary>
        /// 属性: _MenuIdChanged
        /// </summary>
        public bool MenuIdChanged
        {
          get { return _MenuIdChanged;}
          set {
                _MenuIdChanged=value;
              }
        }

        /// <summary>
        /// 属性: _MenuIdCompareParam
        /// </summary>
        public CompareParam MenuIdCompareParam
        {
          get { return _MenuIdCompareParam ;}
          set {
                _MenuIdCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _MenuId的数据库存储类型
        /// </summary>
        public string MenuIdDbType
        {
          get { 
                return _MenuIdDbType;
              }
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
        /// 说明: 角色菜单Id
        /// </summary>
        public System.Int32 RoleMenuId
        {
          get { return _RoleMenuId; }
          set {
                _RoleMenuId = value;
                RoleMenuIdChanged=true;
              }
        }

        /// <summary>
        /// 属性: _RoleMenuIdChanged
        /// </summary>
        public bool RoleMenuIdChanged
        {
          get { return _RoleMenuIdChanged;}
          set {
                _RoleMenuIdChanged=value;
              }
        }

        /// <summary>
        /// 属性: _RoleMenuIdCompareParam
        /// </summary>
        public CompareParam RoleMenuIdCompareParam
        {
          get { return _RoleMenuIdCompareParam ;}
          set {
                _RoleMenuIdCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _RoleMenuId的数据库存储类型
        /// </summary>
        public string RoleMenuIdDbType
        {
          get { 
                return _RoleMenuIdDbType;
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
  