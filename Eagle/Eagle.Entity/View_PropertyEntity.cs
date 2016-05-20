
    /// <summary>
    /// 说  明：本代码由工具软件生成，数据库设计发生变化后，应重新自动生成。
    /// 日  期：2015年10月09日 23:26:38
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
      /// 数据库表View_Property所对应的实体类
      /// </summary>
    public partial class View_PropertyEntity:IEntity
    {
        #region 主键字段数组，存储主键字段列名。
      private string[] _PrimaryKeys = {};
      #endregion

          #region 成员变量:_CityId
          private System.Int32 _CityId;
          private bool _CityIdChanged = false;
          CompareParam _CityIdCompareParam = CompareParam.Equal;
          public string _CityIdDbType = "int";
          #endregion
  
          #region 成员变量:_CityName
          private System.String _CityName;
          private bool _CityNameChanged = false;
          CompareParam _CityNameCompareParam = CompareParam.Equal;
          public string _CityNameDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_CitySort
          private System.Int32 _CitySort;
          private bool _CitySortChanged = false;
          CompareParam _CitySortCompareParam = CompareParam.Equal;
          public string _CitySortDbType = "int";
          #endregion
  
          #region 成员变量:_DisName
          private System.String _DisName;
          private bool _DisNameChanged = false;
          CompareParam _DisNameCompareParam = CompareParam.Equal;
          public string _DisNameDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_DisSort
          private System.Int32 _DisSort;
          private bool _DisSortChanged = false;
          CompareParam _DisSortCompareParam = CompareParam.Equal;
          public string _DisSortDbType = "int";
          #endregion
  
          #region 成员变量:_DistrictId
          private System.Int32 _DistrictId;
          private bool _DistrictIdChanged = false;
          CompareParam _DistrictIdCompareParam = CompareParam.Equal;
          public string _DistrictIdDbType = "int";
          #endregion
  
          #region 成员变量:_ProId
          private System.Int32 _ProId;
          private bool _ProIdChanged = false;
          CompareParam _ProIdCompareParam = CompareParam.Equal;
          public string _ProIdDbType = "int";
          #endregion
  
          #region 成员变量:_ProName
          private System.String _ProName;
          private bool _ProNameChanged = false;
          CompareParam _ProNameCompareParam = CompareParam.Equal;
          public string _ProNameDbType = "nvarchar";
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
  
          #region 成员变量:_ProRemark
          private System.String _ProRemark;
          private bool _ProRemarkChanged = false;
          CompareParam _ProRemarkCompareParam = CompareParam.Equal;
          public string _ProRemarkDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_ProSort
          private System.Int32 _ProSort;
          private bool _ProSortChanged = false;
          CompareParam _ProSortCompareParam = CompareParam.Equal;
          public string _ProSortDbType = "int";
          #endregion
  
          /// <summary>
          /// 构造函数
          /// </summary>
          public View_PropertyEntity()
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
        public System.Int32 CityId
        {
          get { return _CityId; }
          set {
                _CityId = value;
                CityIdChanged=true;
              }
        }

        /// <summary>
        /// 属性: _CityIdChanged
        /// </summary>
        public bool CityIdChanged
        {
          get { return _CityIdChanged;}
          set {
                _CityIdChanged=value;
              }
        }

        /// <summary>
        /// 属性: _CityIdCompareParam
        /// </summary>
        public CompareParam CityIdCompareParam
        {
          get { return _CityIdCompareParam ;}
          set {
                _CityIdCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _CityId的数据库存储类型
        /// </summary>
        public string CityIdDbType
        {
          get { 
                return _CityIdDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.String CityName
        {
          get { return _CityName; }
          set {
                _CityName = value;
                CityNameChanged=true;
              }
        }

        /// <summary>
        /// 属性: _CityNameChanged
        /// </summary>
        public bool CityNameChanged
        {
          get { return _CityNameChanged;}
          set {
                _CityNameChanged=value;
              }
        }

        /// <summary>
        /// 属性: _CityNameCompareParam
        /// </summary>
        public CompareParam CityNameCompareParam
        {
          get { return _CityNameCompareParam ;}
          set {
                _CityNameCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _CityName的数据库存储类型
        /// </summary>
        public string CityNameDbType
        {
          get { 
                return _CityNameDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.Int32 CitySort
        {
          get { return _CitySort; }
          set {
                _CitySort = value;
                CitySortChanged=true;
              }
        }

        /// <summary>
        /// 属性: _CitySortChanged
        /// </summary>
        public bool CitySortChanged
        {
          get { return _CitySortChanged;}
          set {
                _CitySortChanged=value;
              }
        }

        /// <summary>
        /// 属性: _CitySortCompareParam
        /// </summary>
        public CompareParam CitySortCompareParam
        {
          get { return _CitySortCompareParam ;}
          set {
                _CitySortCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _CitySort的数据库存储类型
        /// </summary>
        public string CitySortDbType
        {
          get { 
                return _CitySortDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.String DisName
        {
          get { return _DisName; }
          set {
                _DisName = value;
                DisNameChanged=true;
              }
        }

        /// <summary>
        /// 属性: _DisNameChanged
        /// </summary>
        public bool DisNameChanged
        {
          get { return _DisNameChanged;}
          set {
                _DisNameChanged=value;
              }
        }

        /// <summary>
        /// 属性: _DisNameCompareParam
        /// </summary>
        public CompareParam DisNameCompareParam
        {
          get { return _DisNameCompareParam ;}
          set {
                _DisNameCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _DisName的数据库存储类型
        /// </summary>
        public string DisNameDbType
        {
          get { 
                return _DisNameDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.Int32 DisSort
        {
          get { return _DisSort; }
          set {
                _DisSort = value;
                DisSortChanged=true;
              }
        }

        /// <summary>
        /// 属性: _DisSortChanged
        /// </summary>
        public bool DisSortChanged
        {
          get { return _DisSortChanged;}
          set {
                _DisSortChanged=value;
              }
        }

        /// <summary>
        /// 属性: _DisSortCompareParam
        /// </summary>
        public CompareParam DisSortCompareParam
        {
          get { return _DisSortCompareParam ;}
          set {
                _DisSortCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _DisSort的数据库存储类型
        /// </summary>
        public string DisSortDbType
        {
          get { 
                return _DisSortDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
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
        /// 说明: 
        /// </summary>
        public System.Int32 ProId
        {
          get { return _ProId; }
          set {
                _ProId = value;
                ProIdChanged=true;
              }
        }

        /// <summary>
        /// 属性: _ProIdChanged
        /// </summary>
        public bool ProIdChanged
        {
          get { return _ProIdChanged;}
          set {
                _ProIdChanged=value;
              }
        }

        /// <summary>
        /// 属性: _ProIdCompareParam
        /// </summary>
        public CompareParam ProIdCompareParam
        {
          get { return _ProIdCompareParam ;}
          set {
                _ProIdCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _ProId的数据库存储类型
        /// </summary>
        public string ProIdDbType
        {
          get { 
                return _ProIdDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.String ProName
        {
          get { return _ProName; }
          set {
                _ProName = value;
                ProNameChanged=true;
              }
        }

        /// <summary>
        /// 属性: _ProNameChanged
        /// </summary>
        public bool ProNameChanged
        {
          get { return _ProNameChanged;}
          set {
                _ProNameChanged=value;
              }
        }

        /// <summary>
        /// 属性: _ProNameCompareParam
        /// </summary>
        public CompareParam ProNameCompareParam
        {
          get { return _ProNameCompareParam ;}
          set {
                _ProNameCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _ProName的数据库存储类型
        /// </summary>
        public string ProNameDbType
        {
          get { 
                return _ProNameDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
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
        /// 说明: 
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
        /// 说明: 
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
        /// 说明: 
        /// </summary>
        public System.String ProRemark
        {
          get { return _ProRemark; }
          set {
                _ProRemark = value;
                ProRemarkChanged=true;
              }
        }

        /// <summary>
        /// 属性: _ProRemarkChanged
        /// </summary>
        public bool ProRemarkChanged
        {
          get { return _ProRemarkChanged;}
          set {
                _ProRemarkChanged=value;
              }
        }

        /// <summary>
        /// 属性: _ProRemarkCompareParam
        /// </summary>
        public CompareParam ProRemarkCompareParam
        {
          get { return _ProRemarkCompareParam ;}
          set {
                _ProRemarkCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _ProRemark的数据库存储类型
        /// </summary>
        public string ProRemarkDbType
        {
          get { 
                return _ProRemarkDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.Int32 ProSort
        {
          get { return _ProSort; }
          set {
                _ProSort = value;
                ProSortChanged=true;
              }
        }

        /// <summary>
        /// 属性: _ProSortChanged
        /// </summary>
        public bool ProSortChanged
        {
          get { return _ProSortChanged;}
          set {
                _ProSortChanged=value;
              }
        }

        /// <summary>
        /// 属性: _ProSortCompareParam
        /// </summary>
        public CompareParam ProSortCompareParam
        {
          get { return _ProSortCompareParam ;}
          set {
                _ProSortCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _ProSort的数据库存储类型
        /// </summary>
        public string ProSortDbType
        {
          get { 
                return _ProSortDbType;
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
  