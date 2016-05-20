
    /// <summary>
    /// 说  明：本代码由工具软件生成，数据库设计发生变化后，应重新自动生成。
    /// 日  期：2015年10月13日 23:18:03
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
      /// 数据库表View_UserBuilding所对应的实体类
      /// </summary>
    public partial class View_UserBuildingEntity:IEntity
    {
        #region 主键字段数组，存储主键字段列名。
      private string[] _PrimaryKeys = {};
      #endregion

          #region 成员变量:_AmbientSupporting
          private System.String _AmbientSupporting;
          private bool _AmbientSupportingChanged = false;
          CompareParam _AmbientSupportingCompareParam = CompareParam.Equal;
          public string _AmbientSupportingDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_BuildingAddress
          private System.String _BuildingAddress;
          private bool _BuildingAddressChanged = false;
          CompareParam _BuildingAddressCompareParam = CompareParam.Equal;
          public string _BuildingAddressDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_BuildingAge
          private System.String _BuildingAge;
          private bool _BuildingAgeChanged = false;
          CompareParam _BuildingAgeCompareParam = CompareParam.Equal;
          public string _BuildingAgeDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_BuildingFacilities
          private System.String _BuildingFacilities;
          private bool _BuildingFacilitiesChanged = false;
          CompareParam _BuildingFacilitiesCompareParam = CompareParam.Equal;
          public string _BuildingFacilitiesDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_BuildingFeature
          private System.String _BuildingFeature;
          private bool _BuildingFeatureChanged = false;
          CompareParam _BuildingFeatureCompareParam = CompareParam.Equal;
          public string _BuildingFeatureDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_BuildingHeight
          private System.String _BuildingHeight;
          private bool _BuildingHeightChanged = false;
          CompareParam _BuildingHeightCompareParam = CompareParam.Equal;
          public string _BuildingHeightDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_BuildingId
          private System.Int32 _BuildingId;
          private bool _BuildingIdChanged = false;
          CompareParam _BuildingIdCompareParam = CompareParam.Equal;
          public string _BuildingIdDbType = "int";
          #endregion
  
          #region 成员变量:_BuildingName
          private System.String _BuildingName;
          private bool _BuildingNameChanged = false;
          CompareParam _BuildingNameCompareParam = CompareParam.Equal;
          public string _BuildingNameDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_CBDAddress
          private System.String _CBDAddress;
          private bool _CBDAddressChanged = false;
          CompareParam _CBDAddressCompareParam = CompareParam.Equal;
          public string _CBDAddressDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_CBDId
          private System.Int32 _CBDId;
          private bool _CBDIdChanged = false;
          CompareParam _CBDIdCompareParam = CompareParam.Equal;
          public string _CBDIdDbType = "int";
          #endregion
  
          #region 成员变量:_CBDName
          private System.String _CBDName;
          private bool _CBDNameChanged = false;
          CompareParam _CBDNameCompareParam = CompareParam.Equal;
          public string _CBDNameDbType = "nvarchar";
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
  
          #region 成员变量:_DecorationInfo
          private System.String _DecorationInfo;
          private bool _DecorationInfoChanged = false;
          CompareParam _DecorationInfoCompareParam = CompareParam.Equal;
          public string _DecorationInfoDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_Description
          private System.String _Description;
          private bool _DescriptionChanged = false;
          CompareParam _DescriptionCompareParam = CompareParam.Equal;
          public string _DescriptionDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_DeveloperId
          private System.Int32 _DeveloperId;
          private bool _DeveloperIdChanged = false;
          CompareParam _DeveloperIdCompareParam = CompareParam.Equal;
          public string _DeveloperIdDbType = "int";
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
  
          #region 成员变量:_FloorCondition
          private System.String _FloorCondition;
          private bool _FloorConditionChanged = false;
          CompareParam _FloorConditionCompareParam = CompareParam.Equal;
          public string _FloorConditionDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_InputTime
          private System.DateTime _InputTime;
          private bool _InputTimeChanged = false;
          CompareParam _InputTimeCompareParam = CompareParam.Equal;
          public string _InputTimeDbType = "datetime";
          #endregion
  
          #region 成员变量:_InternalSupporting
          private System.String _InternalSupporting;
          private bool _InternalSupportingChanged = false;
          CompareParam _InternalSupportingCompareParam = CompareParam.Equal;
          public string _InternalSupportingDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_LiftsDescri
          private System.String _LiftsDescri;
          private bool _LiftsDescriChanged = false;
          CompareParam _LiftsDescriCompareParam = CompareParam.Equal;
          public string _LiftsDescriDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_LTPoint
          private System.String _LTPoint;
          private bool _LTPointChanged = false;
          CompareParam _LTPointCompareParam = CompareParam.Equal;
          public string _LTPointDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_OverallFloorage
          private System.Decimal _OverallFloorage;
          private bool _OverallFloorageChanged = false;
          CompareParam _OverallFloorageCompareParam = CompareParam.Equal;
          public string _OverallFloorageDbType = "numeric";
          #endregion
  
          #region 成员变量:_ParkingDescri
          private System.Int32 _ParkingDescri;
          private bool _ParkingDescriChanged = false;
          CompareParam _ParkingDescriCompareParam = CompareParam.Equal;
          public string _ParkingDescriDbType = "int";
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
  
          #region 成员变量:_PropertyFees
          private System.Decimal _PropertyFees;
          private bool _PropertyFeesChanged = false;
          CompareParam _PropertyFeesCompareParam = CompareParam.Equal;
          public string _PropertyFeesDbType = "numeric";
          #endregion
  
          #region 成员变量:_PropertyId
          private System.Int32 _PropertyId;
          private bool _PropertyIdChanged = false;
          CompareParam _PropertyIdCompareParam = CompareParam.Equal;
          public string _PropertyIdDbType = "int";
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
  
          #region 成员变量:_RentPrice
          private System.Decimal _RentPrice;
          private bool _RentPriceChanged = false;
          CompareParam _RentPriceCompareParam = CompareParam.Equal;
          public string _RentPriceDbType = "numeric";
          #endregion
  
          #region 成员变量:_SalePrice
          private System.Decimal _SalePrice;
          private bool _SalePriceChanged = false;
          CompareParam _SalePriceCompareParam = CompareParam.Equal;
          public string _SalePriceDbType = "numeric";
          #endregion
  
          #region 成员变量:_StoryHeight
          private System.String _StoryHeight;
          private bool _StoryHeightChanged = false;
          CompareParam _StoryHeightCompareParam = CompareParam.Equal;
          public string _StoryHeightDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_TrafficDescri
          private System.String _TrafficDescri;
          private bool _TrafficDescriChanged = false;
          CompareParam _TrafficDescriCompareParam = CompareParam.Equal;
          public string _TrafficDescriDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_TypicalFloorage
          private System.Decimal _TypicalFloorage;
          private bool _TypicalFloorageChanged = false;
          CompareParam _TypicalFloorageCompareParam = CompareParam.Equal;
          public string _TypicalFloorageDbType = "numeric";
          #endregion
  
          #region 成员变量:_UploadGroupId
          private System.Int32 _UploadGroupId;
          private bool _UploadGroupIdChanged = false;
          CompareParam _UploadGroupIdCompareParam = CompareParam.Equal;
          public string _UploadGroupIdDbType = "int";
          #endregion
  
          #region 成员变量:_UserBuildingId
          private System.Int32 _UserBuildingId;
          private bool _UserBuildingIdChanged = false;
          CompareParam _UserBuildingIdCompareParam = CompareParam.Equal;
          public string _UserBuildingIdDbType = "int";
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
          public View_UserBuildingEntity()
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
        public System.String AmbientSupporting
        {
          get { return _AmbientSupporting; }
          set {
                _AmbientSupporting = value;
                AmbientSupportingChanged=true;
              }
        }

        /// <summary>
        /// 属性: _AmbientSupportingChanged
        /// </summary>
        public bool AmbientSupportingChanged
        {
          get { return _AmbientSupportingChanged;}
          set {
                _AmbientSupportingChanged=value;
              }
        }

        /// <summary>
        /// 属性: _AmbientSupportingCompareParam
        /// </summary>
        public CompareParam AmbientSupportingCompareParam
        {
          get { return _AmbientSupportingCompareParam ;}
          set {
                _AmbientSupportingCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _AmbientSupporting的数据库存储类型
        /// </summary>
        public string AmbientSupportingDbType
        {
          get { 
                return _AmbientSupportingDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.String BuildingAddress
        {
          get { return _BuildingAddress; }
          set {
                _BuildingAddress = value;
                BuildingAddressChanged=true;
              }
        }

        /// <summary>
        /// 属性: _BuildingAddressChanged
        /// </summary>
        public bool BuildingAddressChanged
        {
          get { return _BuildingAddressChanged;}
          set {
                _BuildingAddressChanged=value;
              }
        }

        /// <summary>
        /// 属性: _BuildingAddressCompareParam
        /// </summary>
        public CompareParam BuildingAddressCompareParam
        {
          get { return _BuildingAddressCompareParam ;}
          set {
                _BuildingAddressCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _BuildingAddress的数据库存储类型
        /// </summary>
        public string BuildingAddressDbType
        {
          get { 
                return _BuildingAddressDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.String BuildingAge
        {
          get { return _BuildingAge; }
          set {
                _BuildingAge = value;
                BuildingAgeChanged=true;
              }
        }

        /// <summary>
        /// 属性: _BuildingAgeChanged
        /// </summary>
        public bool BuildingAgeChanged
        {
          get { return _BuildingAgeChanged;}
          set {
                _BuildingAgeChanged=value;
              }
        }

        /// <summary>
        /// 属性: _BuildingAgeCompareParam
        /// </summary>
        public CompareParam BuildingAgeCompareParam
        {
          get { return _BuildingAgeCompareParam ;}
          set {
                _BuildingAgeCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _BuildingAge的数据库存储类型
        /// </summary>
        public string BuildingAgeDbType
        {
          get { 
                return _BuildingAgeDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.String BuildingFacilities
        {
          get { return _BuildingFacilities; }
          set {
                _BuildingFacilities = value;
                BuildingFacilitiesChanged=true;
              }
        }

        /// <summary>
        /// 属性: _BuildingFacilitiesChanged
        /// </summary>
        public bool BuildingFacilitiesChanged
        {
          get { return _BuildingFacilitiesChanged;}
          set {
                _BuildingFacilitiesChanged=value;
              }
        }

        /// <summary>
        /// 属性: _BuildingFacilitiesCompareParam
        /// </summary>
        public CompareParam BuildingFacilitiesCompareParam
        {
          get { return _BuildingFacilitiesCompareParam ;}
          set {
                _BuildingFacilitiesCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _BuildingFacilities的数据库存储类型
        /// </summary>
        public string BuildingFacilitiesDbType
        {
          get { 
                return _BuildingFacilitiesDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.String BuildingFeature
        {
          get { return _BuildingFeature; }
          set {
                _BuildingFeature = value;
                BuildingFeatureChanged=true;
              }
        }

        /// <summary>
        /// 属性: _BuildingFeatureChanged
        /// </summary>
        public bool BuildingFeatureChanged
        {
          get { return _BuildingFeatureChanged;}
          set {
                _BuildingFeatureChanged=value;
              }
        }

        /// <summary>
        /// 属性: _BuildingFeatureCompareParam
        /// </summary>
        public CompareParam BuildingFeatureCompareParam
        {
          get { return _BuildingFeatureCompareParam ;}
          set {
                _BuildingFeatureCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _BuildingFeature的数据库存储类型
        /// </summary>
        public string BuildingFeatureDbType
        {
          get { 
                return _BuildingFeatureDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.String BuildingHeight
        {
          get { return _BuildingHeight; }
          set {
                _BuildingHeight = value;
                BuildingHeightChanged=true;
              }
        }

        /// <summary>
        /// 属性: _BuildingHeightChanged
        /// </summary>
        public bool BuildingHeightChanged
        {
          get { return _BuildingHeightChanged;}
          set {
                _BuildingHeightChanged=value;
              }
        }

        /// <summary>
        /// 属性: _BuildingHeightCompareParam
        /// </summary>
        public CompareParam BuildingHeightCompareParam
        {
          get { return _BuildingHeightCompareParam ;}
          set {
                _BuildingHeightCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _BuildingHeight的数据库存储类型
        /// </summary>
        public string BuildingHeightDbType
        {
          get { 
                return _BuildingHeightDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.Int32 BuildingId
        {
          get { return _BuildingId; }
          set {
                _BuildingId = value;
                BuildingIdChanged=true;
              }
        }

        /// <summary>
        /// 属性: _BuildingIdChanged
        /// </summary>
        public bool BuildingIdChanged
        {
          get { return _BuildingIdChanged;}
          set {
                _BuildingIdChanged=value;
              }
        }

        /// <summary>
        /// 属性: _BuildingIdCompareParam
        /// </summary>
        public CompareParam BuildingIdCompareParam
        {
          get { return _BuildingIdCompareParam ;}
          set {
                _BuildingIdCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _BuildingId的数据库存储类型
        /// </summary>
        public string BuildingIdDbType
        {
          get { 
                return _BuildingIdDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.String BuildingName
        {
          get { return _BuildingName; }
          set {
                _BuildingName = value;
                BuildingNameChanged=true;
              }
        }

        /// <summary>
        /// 属性: _BuildingNameChanged
        /// </summary>
        public bool BuildingNameChanged
        {
          get { return _BuildingNameChanged;}
          set {
                _BuildingNameChanged=value;
              }
        }

        /// <summary>
        /// 属性: _BuildingNameCompareParam
        /// </summary>
        public CompareParam BuildingNameCompareParam
        {
          get { return _BuildingNameCompareParam ;}
          set {
                _BuildingNameCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _BuildingName的数据库存储类型
        /// </summary>
        public string BuildingNameDbType
        {
          get { 
                return _BuildingNameDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.String CBDAddress
        {
          get { return _CBDAddress; }
          set {
                _CBDAddress = value;
                CBDAddressChanged=true;
              }
        }

        /// <summary>
        /// 属性: _CBDAddressChanged
        /// </summary>
        public bool CBDAddressChanged
        {
          get { return _CBDAddressChanged;}
          set {
                _CBDAddressChanged=value;
              }
        }

        /// <summary>
        /// 属性: _CBDAddressCompareParam
        /// </summary>
        public CompareParam CBDAddressCompareParam
        {
          get { return _CBDAddressCompareParam ;}
          set {
                _CBDAddressCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _CBDAddress的数据库存储类型
        /// </summary>
        public string CBDAddressDbType
        {
          get { 
                return _CBDAddressDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.Int32 CBDId
        {
          get { return _CBDId; }
          set {
                _CBDId = value;
                CBDIdChanged=true;
              }
        }

        /// <summary>
        /// 属性: _CBDIdChanged
        /// </summary>
        public bool CBDIdChanged
        {
          get { return _CBDIdChanged;}
          set {
                _CBDIdChanged=value;
              }
        }

        /// <summary>
        /// 属性: _CBDIdCompareParam
        /// </summary>
        public CompareParam CBDIdCompareParam
        {
          get { return _CBDIdCompareParam ;}
          set {
                _CBDIdCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _CBDId的数据库存储类型
        /// </summary>
        public string CBDIdDbType
        {
          get { 
                return _CBDIdDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.String CBDName
        {
          get { return _CBDName; }
          set {
                _CBDName = value;
                CBDNameChanged=true;
              }
        }

        /// <summary>
        /// 属性: _CBDNameChanged
        /// </summary>
        public bool CBDNameChanged
        {
          get { return _CBDNameChanged;}
          set {
                _CBDNameChanged=value;
              }
        }

        /// <summary>
        /// 属性: _CBDNameCompareParam
        /// </summary>
        public CompareParam CBDNameCompareParam
        {
          get { return _CBDNameCompareParam ;}
          set {
                _CBDNameCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _CBDName的数据库存储类型
        /// </summary>
        public string CBDNameDbType
        {
          get { 
                return _CBDNameDbType;
              }
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
        public System.String DecorationInfo
        {
          get { return _DecorationInfo; }
          set {
                _DecorationInfo = value;
                DecorationInfoChanged=true;
              }
        }

        /// <summary>
        /// 属性: _DecorationInfoChanged
        /// </summary>
        public bool DecorationInfoChanged
        {
          get { return _DecorationInfoChanged;}
          set {
                _DecorationInfoChanged=value;
              }
        }

        /// <summary>
        /// 属性: _DecorationInfoCompareParam
        /// </summary>
        public CompareParam DecorationInfoCompareParam
        {
          get { return _DecorationInfoCompareParam ;}
          set {
                _DecorationInfoCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _DecorationInfo的数据库存储类型
        /// </summary>
        public string DecorationInfoDbType
        {
          get { 
                return _DecorationInfoDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.String Description
        {
          get { return _Description; }
          set {
                _Description = value;
                DescriptionChanged=true;
              }
        }

        /// <summary>
        /// 属性: _DescriptionChanged
        /// </summary>
        public bool DescriptionChanged
        {
          get { return _DescriptionChanged;}
          set {
                _DescriptionChanged=value;
              }
        }

        /// <summary>
        /// 属性: _DescriptionCompareParam
        /// </summary>
        public CompareParam DescriptionCompareParam
        {
          get { return _DescriptionCompareParam ;}
          set {
                _DescriptionCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _Description的数据库存储类型
        /// </summary>
        public string DescriptionDbType
        {
          get { 
                return _DescriptionDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.Int32 DeveloperId
        {
          get { return _DeveloperId; }
          set {
                _DeveloperId = value;
                DeveloperIdChanged=true;
              }
        }

        /// <summary>
        /// 属性: _DeveloperIdChanged
        /// </summary>
        public bool DeveloperIdChanged
        {
          get { return _DeveloperIdChanged;}
          set {
                _DeveloperIdChanged=value;
              }
        }

        /// <summary>
        /// 属性: _DeveloperIdCompareParam
        /// </summary>
        public CompareParam DeveloperIdCompareParam
        {
          get { return _DeveloperIdCompareParam ;}
          set {
                _DeveloperIdCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _DeveloperId的数据库存储类型
        /// </summary>
        public string DeveloperIdDbType
        {
          get { 
                return _DeveloperIdDbType;
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
        public System.String FloorCondition
        {
          get { return _FloorCondition; }
          set {
                _FloorCondition = value;
                FloorConditionChanged=true;
              }
        }

        /// <summary>
        /// 属性: _FloorConditionChanged
        /// </summary>
        public bool FloorConditionChanged
        {
          get { return _FloorConditionChanged;}
          set {
                _FloorConditionChanged=value;
              }
        }

        /// <summary>
        /// 属性: _FloorConditionCompareParam
        /// </summary>
        public CompareParam FloorConditionCompareParam
        {
          get { return _FloorConditionCompareParam ;}
          set {
                _FloorConditionCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _FloorCondition的数据库存储类型
        /// </summary>
        public string FloorConditionDbType
        {
          get { 
                return _FloorConditionDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.DateTime InputTime
        {
          get { return _InputTime; }
          set {
                _InputTime = value;
                InputTimeChanged=true;
              }
        }

        /// <summary>
        /// 属性: _InputTimeChanged
        /// </summary>
        public bool InputTimeChanged
        {
          get { return _InputTimeChanged;}
          set {
                _InputTimeChanged=value;
              }
        }

        /// <summary>
        /// 属性: _InputTimeCompareParam
        /// </summary>
        public CompareParam InputTimeCompareParam
        {
          get { return _InputTimeCompareParam ;}
          set {
                _InputTimeCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _InputTime的数据库存储类型
        /// </summary>
        public string InputTimeDbType
        {
          get { 
                return _InputTimeDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.String InternalSupporting
        {
          get { return _InternalSupporting; }
          set {
                _InternalSupporting = value;
                InternalSupportingChanged=true;
              }
        }

        /// <summary>
        /// 属性: _InternalSupportingChanged
        /// </summary>
        public bool InternalSupportingChanged
        {
          get { return _InternalSupportingChanged;}
          set {
                _InternalSupportingChanged=value;
              }
        }

        /// <summary>
        /// 属性: _InternalSupportingCompareParam
        /// </summary>
        public CompareParam InternalSupportingCompareParam
        {
          get { return _InternalSupportingCompareParam ;}
          set {
                _InternalSupportingCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _InternalSupporting的数据库存储类型
        /// </summary>
        public string InternalSupportingDbType
        {
          get { 
                return _InternalSupportingDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.String LiftsDescri
        {
          get { return _LiftsDescri; }
          set {
                _LiftsDescri = value;
                LiftsDescriChanged=true;
              }
        }

        /// <summary>
        /// 属性: _LiftsDescriChanged
        /// </summary>
        public bool LiftsDescriChanged
        {
          get { return _LiftsDescriChanged;}
          set {
                _LiftsDescriChanged=value;
              }
        }

        /// <summary>
        /// 属性: _LiftsDescriCompareParam
        /// </summary>
        public CompareParam LiftsDescriCompareParam
        {
          get { return _LiftsDescriCompareParam ;}
          set {
                _LiftsDescriCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _LiftsDescri的数据库存储类型
        /// </summary>
        public string LiftsDescriDbType
        {
          get { 
                return _LiftsDescriDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.String LTPoint
        {
          get { return _LTPoint; }
          set {
                _LTPoint = value;
                LTPointChanged=true;
              }
        }

        /// <summary>
        /// 属性: _LTPointChanged
        /// </summary>
        public bool LTPointChanged
        {
          get { return _LTPointChanged;}
          set {
                _LTPointChanged=value;
              }
        }

        /// <summary>
        /// 属性: _LTPointCompareParam
        /// </summary>
        public CompareParam LTPointCompareParam
        {
          get { return _LTPointCompareParam ;}
          set {
                _LTPointCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _LTPoint的数据库存储类型
        /// </summary>
        public string LTPointDbType
        {
          get { 
                return _LTPointDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.Decimal OverallFloorage
        {
          get { return _OverallFloorage; }
          set {
                _OverallFloorage = value;
                OverallFloorageChanged=true;
              }
        }

        /// <summary>
        /// 属性: _OverallFloorageChanged
        /// </summary>
        public bool OverallFloorageChanged
        {
          get { return _OverallFloorageChanged;}
          set {
                _OverallFloorageChanged=value;
              }
        }

        /// <summary>
        /// 属性: _OverallFloorageCompareParam
        /// </summary>
        public CompareParam OverallFloorageCompareParam
        {
          get { return _OverallFloorageCompareParam ;}
          set {
                _OverallFloorageCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _OverallFloorage的数据库存储类型
        /// </summary>
        public string OverallFloorageDbType
        {
          get { 
                return _OverallFloorageDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.Int32 ParkingDescri
        {
          get { return _ParkingDescri; }
          set {
                _ParkingDescri = value;
                ParkingDescriChanged=true;
              }
        }

        /// <summary>
        /// 属性: _ParkingDescriChanged
        /// </summary>
        public bool ParkingDescriChanged
        {
          get { return _ParkingDescriChanged;}
          set {
                _ParkingDescriChanged=value;
              }
        }

        /// <summary>
        /// 属性: _ParkingDescriCompareParam
        /// </summary>
        public CompareParam ParkingDescriCompareParam
        {
          get { return _ParkingDescriCompareParam ;}
          set {
                _ParkingDescriCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _ParkingDescri的数据库存储类型
        /// </summary>
        public string ParkingDescriDbType
        {
          get { 
                return _ParkingDescriDbType;
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
        public System.Decimal PropertyFees
        {
          get { return _PropertyFees; }
          set {
                _PropertyFees = value;
                PropertyFeesChanged=true;
              }
        }

        /// <summary>
        /// 属性: _PropertyFeesChanged
        /// </summary>
        public bool PropertyFeesChanged
        {
          get { return _PropertyFeesChanged;}
          set {
                _PropertyFeesChanged=value;
              }
        }

        /// <summary>
        /// 属性: _PropertyFeesCompareParam
        /// </summary>
        public CompareParam PropertyFeesCompareParam
        {
          get { return _PropertyFeesCompareParam ;}
          set {
                _PropertyFeesCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _PropertyFees的数据库存储类型
        /// </summary>
        public string PropertyFeesDbType
        {
          get { 
                return _PropertyFeesDbType;
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
        /// 说明: 
        /// </summary>
        public System.Decimal RentPrice
        {
          get { return _RentPrice; }
          set {
                _RentPrice = value;
                RentPriceChanged=true;
              }
        }

        /// <summary>
        /// 属性: _RentPriceChanged
        /// </summary>
        public bool RentPriceChanged
        {
          get { return _RentPriceChanged;}
          set {
                _RentPriceChanged=value;
              }
        }

        /// <summary>
        /// 属性: _RentPriceCompareParam
        /// </summary>
        public CompareParam RentPriceCompareParam
        {
          get { return _RentPriceCompareParam ;}
          set {
                _RentPriceCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _RentPrice的数据库存储类型
        /// </summary>
        public string RentPriceDbType
        {
          get { 
                return _RentPriceDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.Decimal SalePrice
        {
          get { return _SalePrice; }
          set {
                _SalePrice = value;
                SalePriceChanged=true;
              }
        }

        /// <summary>
        /// 属性: _SalePriceChanged
        /// </summary>
        public bool SalePriceChanged
        {
          get { return _SalePriceChanged;}
          set {
                _SalePriceChanged=value;
              }
        }

        /// <summary>
        /// 属性: _SalePriceCompareParam
        /// </summary>
        public CompareParam SalePriceCompareParam
        {
          get { return _SalePriceCompareParam ;}
          set {
                _SalePriceCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _SalePrice的数据库存储类型
        /// </summary>
        public string SalePriceDbType
        {
          get { 
                return _SalePriceDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.String StoryHeight
        {
          get { return _StoryHeight; }
          set {
                _StoryHeight = value;
                StoryHeightChanged=true;
              }
        }

        /// <summary>
        /// 属性: _StoryHeightChanged
        /// </summary>
        public bool StoryHeightChanged
        {
          get { return _StoryHeightChanged;}
          set {
                _StoryHeightChanged=value;
              }
        }

        /// <summary>
        /// 属性: _StoryHeightCompareParam
        /// </summary>
        public CompareParam StoryHeightCompareParam
        {
          get { return _StoryHeightCompareParam ;}
          set {
                _StoryHeightCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _StoryHeight的数据库存储类型
        /// </summary>
        public string StoryHeightDbType
        {
          get { 
                return _StoryHeightDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.String TrafficDescri
        {
          get { return _TrafficDescri; }
          set {
                _TrafficDescri = value;
                TrafficDescriChanged=true;
              }
        }

        /// <summary>
        /// 属性: _TrafficDescriChanged
        /// </summary>
        public bool TrafficDescriChanged
        {
          get { return _TrafficDescriChanged;}
          set {
                _TrafficDescriChanged=value;
              }
        }

        /// <summary>
        /// 属性: _TrafficDescriCompareParam
        /// </summary>
        public CompareParam TrafficDescriCompareParam
        {
          get { return _TrafficDescriCompareParam ;}
          set {
                _TrafficDescriCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _TrafficDescri的数据库存储类型
        /// </summary>
        public string TrafficDescriDbType
        {
          get { 
                return _TrafficDescriDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.Decimal TypicalFloorage
        {
          get { return _TypicalFloorage; }
          set {
                _TypicalFloorage = value;
                TypicalFloorageChanged=true;
              }
        }

        /// <summary>
        /// 属性: _TypicalFloorageChanged
        /// </summary>
        public bool TypicalFloorageChanged
        {
          get { return _TypicalFloorageChanged;}
          set {
                _TypicalFloorageChanged=value;
              }
        }

        /// <summary>
        /// 属性: _TypicalFloorageCompareParam
        /// </summary>
        public CompareParam TypicalFloorageCompareParam
        {
          get { return _TypicalFloorageCompareParam ;}
          set {
                _TypicalFloorageCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _TypicalFloorage的数据库存储类型
        /// </summary>
        public string TypicalFloorageDbType
        {
          get { 
                return _TypicalFloorageDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
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
        /// 说明: 
        /// </summary>
        public System.Int32 UserBuildingId
        {
          get { return _UserBuildingId; }
          set {
                _UserBuildingId = value;
                UserBuildingIdChanged=true;
              }
        }

        /// <summary>
        /// 属性: _UserBuildingIdChanged
        /// </summary>
        public bool UserBuildingIdChanged
        {
          get { return _UserBuildingIdChanged;}
          set {
                _UserBuildingIdChanged=value;
              }
        }

        /// <summary>
        /// 属性: _UserBuildingIdCompareParam
        /// </summary>
        public CompareParam UserBuildingIdCompareParam
        {
          get { return _UserBuildingIdCompareParam ;}
          set {
                _UserBuildingIdCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _UserBuildingId的数据库存储类型
        /// </summary>
        public string UserBuildingIdDbType
        {
          get { 
                return _UserBuildingIdDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
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
  