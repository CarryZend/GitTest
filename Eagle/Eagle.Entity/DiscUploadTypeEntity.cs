
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
      /// 数据库表DiscUploadType所对应的实体类
      /// </summary>
    public partial class DiscUploadTypeEntity:IEntity
    {
        #region 主键字段数组，存储主键字段列名。
      private string[] _PrimaryKeys = {"UploadTypeId"};
      #endregion

          #region 成员变量:_UploadTypeId
          private System.Int32 _UploadTypeId;
          private bool _UploadTypeIdChanged = false;
          CompareParam _UploadTypeIdCompareParam = CompareParam.Equal;
          public string _UploadTypeIdDbType = "int";
          #endregion
  
          #region 成员变量:_UploadtypeName
          private System.String _UploadtypeName;
          private bool _UploadtypeNameChanged = false;
          CompareParam _UploadtypeNameCompareParam = CompareParam.Equal;
          public string _UploadtypeNameDbType = "nvarchar";
          #endregion
  
          /// <summary>
          /// 构造函数
          /// </summary>
          public DiscUploadTypeEntity()
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
        /// 说明: 图片类型Id
        /// </summary>
        public System.Int32 UploadTypeId
        {
          get { return _UploadTypeId; }
          set {
                _UploadTypeId = value;
                UploadTypeIdChanged=true;
              }
        }

        /// <summary>
        /// 属性: _UploadTypeIdChanged
        /// </summary>
        public bool UploadTypeIdChanged
        {
          get { return _UploadTypeIdChanged;}
          set {
                _UploadTypeIdChanged=value;
              }
        }

        /// <summary>
        /// 属性: _UploadTypeIdCompareParam
        /// </summary>
        public CompareParam UploadTypeIdCompareParam
        {
          get { return _UploadTypeIdCompareParam ;}
          set {
                _UploadTypeIdCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _UploadTypeId的数据库存储类型
        /// </summary>
        public string UploadTypeIdDbType
        {
          get { 
                return _UploadTypeIdDbType;
              }
        }
  
        /// <summary>
        /// 说明: 图片类型名称
        /// </summary>
        public System.String UploadtypeName
        {
          get { return _UploadtypeName; }
          set {
                _UploadtypeName = value;
                UploadtypeNameChanged=true;
              }
        }

        /// <summary>
        /// 属性: _UploadtypeNameChanged
        /// </summary>
        public bool UploadtypeNameChanged
        {
          get { return _UploadtypeNameChanged;}
          set {
                _UploadtypeNameChanged=value;
              }
        }

        /// <summary>
        /// 属性: _UploadtypeNameCompareParam
        /// </summary>
        public CompareParam UploadtypeNameCompareParam
        {
          get { return _UploadtypeNameCompareParam ;}
          set {
                _UploadtypeNameCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _UploadtypeName的数据库存储类型
        /// </summary>
        public string UploadtypeNameDbType
        {
          get { 
                return _UploadtypeNameDbType;
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
  