
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
      /// 数据库表DiscProperty所对应的实体类
      /// </summary>
    public partial class DiscPropertyEntity:IEntity
    {
        #region 主键字段数组，存储主键字段列名。
      private string[] _PrimaryKeys = {"PropertyId"};
      #endregion

          #region 成员变量:_DistrictId
          private System.Int32 _DistrictId;
          private bool _DistrictIdChanged = false;
          CompareParam _DistrictIdCompareParam = CompareParam.Equal;
          public string _DistrictIdDbType = "int";
          #endregion
  
          #region 成员变量:_PropertyAddress
          private System.String _PropertyAddress;
          private bool _PropertyAddressChanged = false;
          CompareParam _PropertyAddressCompareParam = CompareParam.Equal;
          public string _PropertyAddressDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_PropertyId
          private System.Int32 _PropertyId;
          private bool _PropertyIdChanged = false;
          CompareParam _PropertyIdCompareParam = CompareParam.Equal;
          public string _PropertyIdDbType = "int";
          #endregion
  
          #region 成员变量:_PropertyName
          private System.String _PropertyName;
          private bool _PropertyNameChanged = false;
          CompareParam _PropertyNameCompareParam = CompareParam.Equal;
          public string _PropertyNameDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_PropertyPhone
          private System.String _PropertyPhone;
          private bool _PropertyPhoneChanged = false;
          CompareParam _PropertyPhoneCompareParam = CompareParam.Equal;
          public string _PropertyPhoneDbType = "nvarchar";
          #endregion
  
          /// <summary>
          /// 构造函数
          /// </summary>
          public DiscPropertyEntity()
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
        /// 说明: 物管公司所在区Id(三)
        /// </summary>
        public System.Int32 DistrictId
        {
          get { return _DistrictId; }
          set {
                _DistrictId = value;
                DistrictIdChanged=true;
              }
        }

        /// <summary>
        /// 属性: _DistrictIdChanged
        /// </summary>
        public bool DistrictIdChanged
        {
          get { return _DistrictIdChanged;}
          set {
                _DistrictIdChanged=value;
              }
        }

        /// <summary>
        /// 属性: _DistrictIdCompareParam
        /// </summary>
        public CompareParam DistrictIdCompareParam
        {
          get { return _DistrictIdCompareParam ;}
          set {
                _DistrictIdCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _DistrictId的数据库存储类型
        /// </summary>
        public string DistrictIdDbType
        {
          get { 
                return _DistrictIdDbType;
              }
        }
  
        /// <summary>
        /// 说明: 物管公司所在详细地址
        /// </summary>
        public System.String PropertyAddress
        {
          get { return _PropertyAddress; }
          set {
                _PropertyAddress = value;
                PropertyAddressChanged=true;
              }
        }

        /// <summary>
        /// 属性: _PropertyAddressChanged
        /// </summary>
        public bool PropertyAddressChanged
        {
          get { return _PropertyAddressChanged;}
          set {
                _PropertyAddressChanged=value;
              }
        }

        /// <summary>
        /// 属性: _PropertyAddressCompareParam
        /// </summary>
        public CompareParam PropertyAddressCompareParam
        {
          get { return _PropertyAddressCompareParam ;}
          set {
                _PropertyAddressCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _PropertyAddress的数据库存储类型
        /// </summary>
        public string PropertyAddressDbType
        {
          get { 
                return _PropertyAddressDbType;
              }
        }
  
        /// <summary>
        /// 说明: 物业公司Id
        /// </summary>
        public System.Int32 PropertyId
        {
          get { return _PropertyId; }
          set {
                _PropertyId = value;
                PropertyIdChanged=true;
              }
        }

        /// <summary>
        /// 属性: _PropertyIdChanged
        /// </summary>
        public bool PropertyIdChanged
        {
          get { return _PropertyIdChanged;}
          set {
                _PropertyIdChanged=value;
              }
        }

        /// <summary>
        /// 属性: _PropertyIdCompareParam
        /// </summary>
        public CompareParam PropertyIdCompareParam
        {
          get { return _PropertyIdCompareParam ;}
          set {
                _PropertyIdCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _PropertyId的数据库存储类型
        /// </summary>
        public string PropertyIdDbType
        {
          get { 
                return _PropertyIdDbType;
              }
        }
  
        /// <summary>
        /// 说明: 物业公司名称
        /// </summary>
        public System.String PropertyName
        {
          get { return _PropertyName; }
          set {
                _PropertyName = value;
                PropertyNameChanged=true;
              }
        }

        /// <summary>
        /// 属性: _PropertyNameChanged
        /// </summary>
        public bool PropertyNameChanged
        {
          get { return _PropertyNameChanged;}
          set {
                _PropertyNameChanged=value;
              }
        }

        /// <summary>
        /// 属性: _PropertyNameCompareParam
        /// </summary>
        public CompareParam PropertyNameCompareParam
        {
          get { return _PropertyNameCompareParam ;}
          set {
                _PropertyNameCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _PropertyName的数据库存储类型
        /// </summary>
        public string PropertyNameDbType
        {
          get { 
                return _PropertyNameDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.String PropertyPhone
        {
          get { return _PropertyPhone; }
          set {
                _PropertyPhone = value;
                PropertyPhoneChanged=true;
              }
        }

        /// <summary>
        /// 属性: _PropertyPhoneChanged
        /// </summary>
        public bool PropertyPhoneChanged
        {
          get { return _PropertyPhoneChanged;}
          set {
                _PropertyPhoneChanged=value;
              }
        }

        /// <summary>
        /// 属性: _PropertyPhoneCompareParam
        /// </summary>
        public CompareParam PropertyPhoneCompareParam
        {
          get { return _PropertyPhoneCompareParam ;}
          set {
                _PropertyPhoneCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _PropertyPhone的数据库存储类型
        /// </summary>
        public string PropertyPhoneDbType
        {
          get { 
                return _PropertyPhoneDbType;
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
  