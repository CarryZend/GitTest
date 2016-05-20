
    /// <summary>
    /// 说  明：本代码由工具软件生成，数据库设计发生变化后，应重新自动生成。
    /// 日  期：2015年10月09日 23:26:37
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
      /// 数据库表DiscUploadFileUrl所对应的实体类
      /// </summary>
    public partial class DiscUploadFileUrlEntity:IEntity
    {
        #region 主键字段数组，存储主键字段列名。
      private string[] _PrimaryKeys = {"UploadFileUrlId"};
      #endregion

          #region 成员变量:_FiletypeId
          private System.Int32 _FiletypeId;
          private bool _FiletypeIdChanged = false;
          CompareParam _FiletypeIdCompareParam = CompareParam.Equal;
          public string _FiletypeIdDbType = "int";
          #endregion
  
          #region 成员变量:_ImgMain
          private System.String _ImgMain;
          private bool _ImgMainChanged = false;
          CompareParam _ImgMainCompareParam = CompareParam.Equal;
          public string _ImgMainDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_Sequence
          private System.Int32 _Sequence;
          private bool _SequenceChanged = false;
          CompareParam _SequenceCompareParam = CompareParam.Equal;
          public string _SequenceDbType = "int";
          #endregion
  
          #region 成员变量:_UploadFileUrl
          private System.String _UploadFileUrl;
          private bool _UploadFileUrlChanged = false;
          CompareParam _UploadFileUrlCompareParam = CompareParam.Equal;
          public string _UploadFileUrlDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_UploadFileUrlId
          private System.Int32 _UploadFileUrlId;
          private bool _UploadFileUrlIdChanged = false;
          CompareParam _UploadFileUrlIdCompareParam = CompareParam.Equal;
          public string _UploadFileUrlIdDbType = "int";
          #endregion
  
          #region 成员变量:_UploadFileUrlName
          private System.String _UploadFileUrlName;
          private bool _UploadFileUrlNameChanged = false;
          CompareParam _UploadFileUrlNameCompareParam = CompareParam.Equal;
          public string _UploadFileUrlNameDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_UploadGroupId
          private System.Int32 _UploadGroupId;
          private bool _UploadGroupIdChanged = false;
          CompareParam _UploadGroupIdCompareParam = CompareParam.Equal;
          public string _UploadGroupIdDbType = "int";
          #endregion
  
          /// <summary>
          /// 构造函数
          /// </summary>
          public DiscUploadFileUrlEntity()
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
        public System.Int32 FiletypeId
        {
          get { return _FiletypeId; }
          set {
                _FiletypeId = value;
                FiletypeIdChanged=true;
              }
        }

        /// <summary>
        /// 属性: _FiletypeIdChanged
        /// </summary>
        public bool FiletypeIdChanged
        {
          get { return _FiletypeIdChanged;}
          set {
                _FiletypeIdChanged=value;
              }
        }

        /// <summary>
        /// 属性: _FiletypeIdCompareParam
        /// </summary>
        public CompareParam FiletypeIdCompareParam
        {
          get { return _FiletypeIdCompareParam ;}
          set {
                _FiletypeIdCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _FiletypeId的数据库存储类型
        /// </summary>
        public string FiletypeIdDbType
        {
          get { 
                return _FiletypeIdDbType;
              }
        }
  
        /// <summary>
        /// 说明: 主图
        /// </summary>
        public System.String ImgMain
        {
          get { return _ImgMain; }
          set {
                _ImgMain = value;
                ImgMainChanged=true;
              }
        }

        /// <summary>
        /// 属性: _ImgMainChanged
        /// </summary>
        public bool ImgMainChanged
        {
          get { return _ImgMainChanged;}
          set {
                _ImgMainChanged=value;
              }
        }

        /// <summary>
        /// 属性: _ImgMainCompareParam
        /// </summary>
        public CompareParam ImgMainCompareParam
        {
          get { return _ImgMainCompareParam ;}
          set {
                _ImgMainCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _ImgMain的数据库存储类型
        /// </summary>
        public string ImgMainDbType
        {
          get { 
                return _ImgMainDbType;
              }
        }
  
        /// <summary>
        /// 说明: 排序方式
        /// </summary>
        public System.Int32 Sequence
        {
          get { return _Sequence; }
          set {
                _Sequence = value;
                SequenceChanged=true;
              }
        }

        /// <summary>
        /// 属性: _SequenceChanged
        /// </summary>
        public bool SequenceChanged
        {
          get { return _SequenceChanged;}
          set {
                _SequenceChanged=value;
              }
        }

        /// <summary>
        /// 属性: _SequenceCompareParam
        /// </summary>
        public CompareParam SequenceCompareParam
        {
          get { return _SequenceCompareParam ;}
          set {
                _SequenceCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _Sequence的数据库存储类型
        /// </summary>
        public string SequenceDbType
        {
          get { 
                return _SequenceDbType;
              }
        }
  
        /// <summary>
        /// 说明: 图片地址
        /// </summary>
        public System.String UploadFileUrl
        {
          get { return _UploadFileUrl; }
          set {
                _UploadFileUrl = value;
                UploadFileUrlChanged=true;
              }
        }

        /// <summary>
        /// 属性: _UploadFileUrlChanged
        /// </summary>
        public bool UploadFileUrlChanged
        {
          get { return _UploadFileUrlChanged;}
          set {
                _UploadFileUrlChanged=value;
              }
        }

        /// <summary>
        /// 属性: _UploadFileUrlCompareParam
        /// </summary>
        public CompareParam UploadFileUrlCompareParam
        {
          get { return _UploadFileUrlCompareParam ;}
          set {
                _UploadFileUrlCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _UploadFileUrl的数据库存储类型
        /// </summary>
        public string UploadFileUrlDbType
        {
          get { 
                return _UploadFileUrlDbType;
              }
        }
  
        /// <summary>
        /// 说明: 图片路径Id
        /// </summary>
        public System.Int32 UploadFileUrlId
        {
          get { return _UploadFileUrlId; }
          set {
                _UploadFileUrlId = value;
                UploadFileUrlIdChanged=true;
              }
        }

        /// <summary>
        /// 属性: _UploadFileUrlIdChanged
        /// </summary>
        public bool UploadFileUrlIdChanged
        {
          get { return _UploadFileUrlIdChanged;}
          set {
                _UploadFileUrlIdChanged=value;
              }
        }

        /// <summary>
        /// 属性: _UploadFileUrlIdCompareParam
        /// </summary>
        public CompareParam UploadFileUrlIdCompareParam
        {
          get { return _UploadFileUrlIdCompareParam ;}
          set {
                _UploadFileUrlIdCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _UploadFileUrlId的数据库存储类型
        /// </summary>
        public string UploadFileUrlIdDbType
        {
          get { 
                return _UploadFileUrlIdDbType;
              }
        }
  
        /// <summary>
        /// 说明: 图片名称
        /// </summary>
        public System.String UploadFileUrlName
        {
          get { return _UploadFileUrlName; }
          set {
                _UploadFileUrlName = value;
                UploadFileUrlNameChanged=true;
              }
        }

        /// <summary>
        /// 属性: _UploadFileUrlNameChanged
        /// </summary>
        public bool UploadFileUrlNameChanged
        {
          get { return _UploadFileUrlNameChanged;}
          set {
                _UploadFileUrlNameChanged=value;
              }
        }

        /// <summary>
        /// 属性: _UploadFileUrlNameCompareParam
        /// </summary>
        public CompareParam UploadFileUrlNameCompareParam
        {
          get { return _UploadFileUrlNameCompareParam ;}
          set {
                _UploadFileUrlNameCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _UploadFileUrlName的数据库存储类型
        /// </summary>
        public string UploadFileUrlNameDbType
        {
          get { 
                return _UploadFileUrlNameDbType;
              }
        }
  
        /// <summary>
        /// 说明: 分组Id
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
  