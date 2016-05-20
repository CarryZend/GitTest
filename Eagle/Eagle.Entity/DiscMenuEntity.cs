
    /// <summary>
    /// 说  明：本代码由工具软件生成，数据库设计发生变化后，应重新自动生成。
    /// 日  期：2015年10月09日 23:26:40
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
      /// 数据库表DiscMenu所对应的实体类
      /// </summary>
    public partial class DiscMenuEntity:IEntity
    {
        #region 主键字段数组，存储主键字段列名。
      private string[] _PrimaryKeys = {"MenuId"};
      #endregion

          #region 成员变量:_MenuId
          private System.Int32 _MenuId;
          private bool _MenuIdChanged = false;
          CompareParam _MenuIdCompareParam = CompareParam.Equal;
          public string _MenuIdDbType = "int";
          #endregion
  
          #region 成员变量:_MenuName
          private System.String _MenuName;
          private bool _MenuNameChanged = false;
          CompareParam _MenuNameCompareParam = CompareParam.Equal;
          public string _MenuNameDbType = "nvarchar";
          #endregion
  
          /// <summary>
          /// 构造函数
          /// </summary>
          public DiscMenuEntity()
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
        /// 说明: 菜单名称
        /// </summary>
        public System.String MenuName
        {
          get { return _MenuName; }
          set {
                _MenuName = value;
                MenuNameChanged=true;
              }
        }

        /// <summary>
        /// 属性: _MenuNameChanged
        /// </summary>
        public bool MenuNameChanged
        {
          get { return _MenuNameChanged;}
          set {
                _MenuNameChanged=value;
              }
        }

        /// <summary>
        /// 属性: _MenuNameCompareParam
        /// </summary>
        public CompareParam MenuNameCompareParam
        {
          get { return _MenuNameCompareParam ;}
          set {
                _MenuNameCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _MenuName的数据库存储类型
        /// </summary>
        public string MenuNameDbType
        {
          get { 
                return _MenuNameDbType;
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
  