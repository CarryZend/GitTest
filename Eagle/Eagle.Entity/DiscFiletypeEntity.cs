
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
      /// 数据库表DiscFiletype所对应的实体类
      /// </summary>
    public partial class DiscFiletypeEntity:IEntity
    {
        #region 主键字段数组，存储主键字段列名。
      private string[] _PrimaryKeys = {"FileTypeId"};
      #endregion

          #region 成员变量:_FileTypeId
          private System.Int32 _FileTypeId;
          private bool _FileTypeIdChanged = false;
          CompareParam _FileTypeIdCompareParam = CompareParam.Equal;
          public string _FileTypeIdDbType = "int";
          #endregion
  
          #region 成员变量:_FileTypeName
          private System.String _FileTypeName;
          private bool _FileTypeNameChanged = false;
          CompareParam _FileTypeNameCompareParam = CompareParam.Equal;
          public string _FileTypeNameDbType = "nvarchar";
          #endregion
  
          /// <summary>
          /// 构造函数
          /// </summary>
          public DiscFiletypeEntity()
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
        public System.Int32 FileTypeId
        {
          get { return _FileTypeId; }
          set {
                _FileTypeId = value;
                FileTypeIdChanged=true;
              }
        }

        /// <summary>
        /// 属性: _FileTypeIdChanged
        /// </summary>
        public bool FileTypeIdChanged
        {
          get { return _FileTypeIdChanged;}
          set {
                _FileTypeIdChanged=value;
              }
        }

        /// <summary>
        /// 属性: _FileTypeIdCompareParam
        /// </summary>
        public CompareParam FileTypeIdCompareParam
        {
          get { return _FileTypeIdCompareParam ;}
          set {
                _FileTypeIdCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _FileTypeId的数据库存储类型
        /// </summary>
        public string FileTypeIdDbType
        {
          get { 
                return _FileTypeIdDbType;
              }
        }
  
        /// <summary>
        /// 说明: 图片类型名称
        /// </summary>
        public System.String FileTypeName
        {
          get { return _FileTypeName; }
          set {
                _FileTypeName = value;
                FileTypeNameChanged=true;
              }
        }

        /// <summary>
        /// 属性: _FileTypeNameChanged
        /// </summary>
        public bool FileTypeNameChanged
        {
          get { return _FileTypeNameChanged;}
          set {
                _FileTypeNameChanged=value;
              }
        }

        /// <summary>
        /// 属性: _FileTypeNameCompareParam
        /// </summary>
        public CompareParam FileTypeNameCompareParam
        {
          get { return _FileTypeNameCompareParam ;}
          set {
                _FileTypeNameCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _FileTypeName的数据库存储类型
        /// </summary>
        public string FileTypeNameDbType
        {
          get { 
                return _FileTypeNameDbType;
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
  