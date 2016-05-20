
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
      /// 数据库表DiscOfficeType所对应的实体类
      /// </summary>
    public partial class DiscOfficeTypeEntity:IEntity
    {
        #region 主键字段数组，存储主键字段列名。
      private string[] _PrimaryKeys = {"OfficeTypeId"};
      #endregion

          #region 成员变量:_OfficeTypeId
          private System.Int32 _OfficeTypeId;
          private bool _OfficeTypeIdChanged = false;
          CompareParam _OfficeTypeIdCompareParam = CompareParam.Equal;
          public string _OfficeTypeIdDbType = "int";
          #endregion
  
          #region 成员变量:_OfficeTypeName
          private System.String _OfficeTypeName;
          private bool _OfficeTypeNameChanged = false;
          CompareParam _OfficeTypeNameCompareParam = CompareParam.Equal;
          public string _OfficeTypeNameDbType = "nvarchar";
          #endregion
  
          /// <summary>
          /// 构造函数
          /// </summary>
          public DiscOfficeTypeEntity()
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
        /// 说明: 写字楼类型Id
        /// </summary>
        public System.Int32 OfficeTypeId
        {
          get { return _OfficeTypeId; }
          set {
                _OfficeTypeId = value;
                OfficeTypeIdChanged=true;
              }
        }

        /// <summary>
        /// 属性: _OfficeTypeIdChanged
        /// </summary>
        public bool OfficeTypeIdChanged
        {
          get { return _OfficeTypeIdChanged;}
          set {
                _OfficeTypeIdChanged=value;
              }
        }

        /// <summary>
        /// 属性: _OfficeTypeIdCompareParam
        /// </summary>
        public CompareParam OfficeTypeIdCompareParam
        {
          get { return _OfficeTypeIdCompareParam ;}
          set {
                _OfficeTypeIdCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _OfficeTypeId的数据库存储类型
        /// </summary>
        public string OfficeTypeIdDbType
        {
          get { 
                return _OfficeTypeIdDbType;
              }
        }
  
        /// <summary>
        /// 说明: 写字楼类型名称
        /// </summary>
        public System.String OfficeTypeName
        {
          get { return _OfficeTypeName; }
          set {
                _OfficeTypeName = value;
                OfficeTypeNameChanged=true;
              }
        }

        /// <summary>
        /// 属性: _OfficeTypeNameChanged
        /// </summary>
        public bool OfficeTypeNameChanged
        {
          get { return _OfficeTypeNameChanged;}
          set {
                _OfficeTypeNameChanged=value;
              }
        }

        /// <summary>
        /// 属性: _OfficeTypeNameCompareParam
        /// </summary>
        public CompareParam OfficeTypeNameCompareParam
        {
          get { return _OfficeTypeNameCompareParam ;}
          set {
                _OfficeTypeNameCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _OfficeTypeName的数据库存储类型
        /// </summary>
        public string OfficeTypeNameDbType
        {
          get { 
                return _OfficeTypeNameDbType;
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
  