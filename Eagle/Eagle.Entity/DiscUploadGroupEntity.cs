
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
      /// 数据库表DiscUploadGroup所对应的实体类
      /// </summary>
    public partial class DiscUploadGroupEntity:IEntity
    {
        #region 主键字段数组，存储主键字段列名。
      private string[] _PrimaryKeys = {"UploadGroupId"};
      #endregion

          #region 成员变量:_IsTemplate
          private System.Boolean _IsTemplate;
          private bool _IsTemplateChanged = false;
          CompareParam _IsTemplateCompareParam = CompareParam.Equal;
          public string _IsTemplateDbType = "bit";
          #endregion
  
          #region 成员变量:_UploadGroupId
          private System.Int32 _UploadGroupId;
          private bool _UploadGroupIdChanged = false;
          CompareParam _UploadGroupIdCompareParam = CompareParam.Equal;
          public string _UploadGroupIdDbType = "int";
          #endregion
  
          #region 成员变量:_UploadGroupName
          private System.String _UploadGroupName;
          private bool _UploadGroupNameChanged = false;
          CompareParam _UploadGroupNameCompareParam = CompareParam.Equal;
          public string _UploadGroupNameDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_UploadTypeId
          private System.Int32 _UploadTypeId;
          private bool _UploadTypeIdChanged = false;
          CompareParam _UploadTypeIdCompareParam = CompareParam.Equal;
          public string _UploadTypeIdDbType = "int";
          #endregion
  
          #region 成员变量:_UserId
          private System.Int32 _UserId;
          private bool _UserIdChanged = false;
          CompareParam _UserIdCompareParam = CompareParam.Equal;
          public string _UserIdDbType = "int";
          #endregion
  
          /// <summary>
          /// 构造函数
          /// </summary>
          public DiscUploadGroupEntity()
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
        /// 说明: 
        /// </summary>
        public System.Boolean IsTemplate
        {
          get { return _IsTemplate; }
          set {
                _IsTemplate = value;
                IsTemplateChanged=true;
              }
        }

        /// <summary>
        /// 属性: _IsTemplateChanged
        /// </summary>
        public bool IsTemplateChanged
        {
          get { return _IsTemplateChanged;}
          set {
                _IsTemplateChanged=value;
              }
        }

        /// <summary>
        /// 属性: _IsTemplateCompareParam
        /// </summary>
        public CompareParam IsTemplateCompareParam
        {
          get { return _IsTemplateCompareParam ;}
          set {
                _IsTemplateCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _IsTemplate的数据库存储类型
        /// </summary>
        public string IsTemplateDbType
        {
          get { 
                return _IsTemplateDbType;
              }
        }
  
        /// <summary>
        /// 说明: 上传图片分组Id
        /// </summary>
        public System.Int32 UploadGroupId
        {
          get { return _UploadGroupId; }
          set {
                _UploadGroupId = value;
                UploadGroupIdChanged=true;
              }
        }

        /// <summary>
        /// 属性: _UploadGroupIdChanged
        /// </summary>
        public bool UploadGroupIdChanged
        {
          get { return _UploadGroupIdChanged;}
          set {
                _UploadGroupIdChanged=value;
              }
        }

        /// <summary>
        /// 属性: _UploadGroupIdCompareParam
        /// </summary>
        public CompareParam UploadGroupIdCompareParam
        {
          get { return _UploadGroupIdCompareParam ;}
          set {
                _UploadGroupIdCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _UploadGroupId的数据库存储类型
        /// </summary>
        public string UploadGroupIdDbType
        {
          get { 
                return _UploadGroupIdDbType;
              }
        }
  
        /// <summary>
        /// 说明: 分组名称
        /// </summary>
        public System.String UploadGroupName
        {
          get { return _UploadGroupName; }
          set {
                _UploadGroupName = value;
                UploadGroupNameChanged=true;
              }
        }

        /// <summary>
        /// 属性: _UploadGroupNameChanged
        /// </summary>
        public bool UploadGroupNameChanged
        {
          get { return _UploadGroupNameChanged;}
          set {
                _UploadGroupNameChanged=value;
              }
        }

        /// <summary>
        /// 属性: _UploadGroupNameCompareParam
        /// </summary>
        public CompareParam UploadGroupNameCompareParam
        {
          get { return _UploadGroupNameCompareParam ;}
          set {
                _UploadGroupNameCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _UploadGroupName的数据库存储类型
        /// </summary>
        public string UploadGroupNameDbType
        {
          get { 
                return _UploadGroupNameDbType;
              }
        }
  
        /// <summary>
        /// 说明: 图片类型
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
  