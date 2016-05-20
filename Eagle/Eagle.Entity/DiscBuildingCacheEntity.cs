
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
      /// 数据库表DiscBuildingCache所对应的实体类
      /// </summary>
    public partial class DiscBuildingCacheEntity:IEntity
    {
        #region 主键字段数组，存储主键字段列名。
      private string[] _PrimaryKeys = {"Id"};
      #endregion

          #region 成员变量:_AmbientSupporting
          private System.String _AmbientSupporting;
          private bool _AmbientSupportingChanged = false;
          CompareParam _AmbientSupportingCompareParam = CompareParam.Equal;
          public string _AmbientSupportingDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_BuildingAge
          private System.String _BuildingAge;
          private bool _BuildingAgeChanged = false;
          CompareParam _BuildingAgeCompareParam = CompareParam.Equal;
          public string _BuildingAgeDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_BuildingCode
          private System.String _BuildingCode;
          private bool _BuildingCodeChanged = false;
          CompareParam _BuildingCodeCompareParam = CompareParam.Equal;
          public string _BuildingCodeDbType = "nchar";
          #endregion
  
          #region 成员变量:_BuildingDeveloper
          private System.String _BuildingDeveloper;
          private bool _BuildingDeveloperChanged = false;
          CompareParam _BuildingDeveloperCompareParam = CompareParam.Equal;
          public string _BuildingDeveloperDbType = "nvarchar";
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
          private System.Decimal _BuildingHeight;
          private bool _BuildingHeightChanged = false;
          CompareParam _BuildingHeightCompareParam = CompareParam.Equal;
          public string _BuildingHeightDbType = "numeric";
          #endregion
  
          #region 成员变量:_BuildingImg
          private System.String _BuildingImg;
          private bool _BuildingImgChanged = false;
          CompareParam _BuildingImgCompareParam = CompareParam.Equal;
          public string _BuildingImgDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_BuildingInvestor
          private System.String _BuildingInvestor;
          private bool _BuildingInvestorChanged = false;
          CompareParam _BuildingInvestorCompareParam = CompareParam.Equal;
          public string _BuildingInvestorDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_BuildingLevel
          private System.Int32 _BuildingLevel;
          private bool _BuildingLevelChanged = false;
          CompareParam _BuildingLevelCompareParam = CompareParam.Equal;
          public string _BuildingLevelDbType = "int";
          #endregion
  
          #region 成员变量:_BuildingLocation
          private System.String _BuildingLocation;
          private bool _BuildingLocationChanged = false;
          CompareParam _BuildingLocationCompareParam = CompareParam.Equal;
          public string _BuildingLocationDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_BuildingName
          private System.String _BuildingName;
          private bool _BuildingNameChanged = false;
          CompareParam _BuildingNameCompareParam = CompareParam.Equal;
          public string _BuildingNameDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_BuildingProperty
          private System.Int32 _BuildingProperty;
          private bool _BuildingPropertyChanged = false;
          CompareParam _BuildingPropertyCompareParam = CompareParam.Equal;
          public string _BuildingPropertyDbType = "int";
          #endregion
  
          #region 成员变量:_BusinessDistrictCode
          private System.String _BusinessDistrictCode;
          private bool _BusinessDistrictCodeChanged = false;
          CompareParam _BusinessDistrictCodeCompareParam = CompareParam.Equal;
          public string _BusinessDistrictCodeDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_BusinessRegionCode
          private System.String _BusinessRegionCode;
          private bool _BusinessRegionCodeChanged = false;
          CompareParam _BusinessRegionCodeCompareParam = CompareParam.Equal;
          public string _BusinessRegionCodeDbType = "nvarchar";
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
  
          #region 成员变量:_FloorCondition
          private System.String _FloorCondition;
          private bool _FloorConditionChanged = false;
          CompareParam _FloorConditionCompareParam = CompareParam.Equal;
          public string _FloorConditionDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_Id
          private System.Int32 _Id;
          private bool _IdChanged = false;
          CompareParam _IdCompareParam = CompareParam.Equal;
          public string _IdDbType = "int";
          #endregion
  
          #region 成员变量:_InternalSupporting
          private System.String _InternalSupporting;
          private bool _InternalSupportingChanged = false;
          CompareParam _InternalSupportingCompareParam = CompareParam.Equal;
          public string _InternalSupportingDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_IsNew
          private System.String _IsNew;
          private bool _IsNewChanged = false;
          CompareParam _IsNewCompareParam = CompareParam.Equal;
          public string _IsNewDbType = "varchar";
          #endregion
  
          #region 成员变量:_IsShow
          private System.Boolean _IsShow;
          private bool _IsShowChanged = false;
          CompareParam _IsShowCompareParam = CompareParam.Equal;
          public string _IsShowDbType = "bit";
          #endregion
  
          #region 成员变量:_isUp
          private System.Boolean _isUp;
          private bool _isUpChanged = false;
          CompareParam _isUpCompareParam = CompareParam.Equal;
          public string _isUpDbType = "bit";
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
  
          #region 成员变量:_NickName
          private System.String _NickName;
          private bool _NickNameChanged = false;
          CompareParam _NickNameCompareParam = CompareParam.Equal;
          public string _NickNameDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_OverallFloorage
          private System.Decimal _OverallFloorage;
          private bool _OverallFloorageChanged = false;
          CompareParam _OverallFloorageCompareParam = CompareParam.Equal;
          public string _OverallFloorageDbType = "numeric";
          #endregion
  
          #region 成员变量:_ParkingDescri
          private System.String _ParkingDescri;
          private bool _ParkingDescriChanged = false;
          CompareParam _ParkingDescriCompareParam = CompareParam.Equal;
          public string _ParkingDescriDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_PropertyFees
          private System.Decimal _PropertyFees;
          private bool _PropertyFeesChanged = false;
          CompareParam _PropertyFeesCompareParam = CompareParam.Equal;
          public string _PropertyFeesDbType = "numeric";
          #endregion
  
          #region 成员变量:_PropertyManager
          private System.String _PropertyManager;
          private bool _PropertyManagerChanged = false;
          CompareParam _PropertyManagerCompareParam = CompareParam.Equal;
          public string _PropertyManagerDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_RentPrice
          private System.String _RentPrice;
          private bool _RentPriceChanged = false;
          CompareParam _RentPriceCompareParam = CompareParam.Equal;
          public string _RentPriceDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_SalePrice
          private System.String _SalePrice;
          private bool _SalePriceChanged = false;
          CompareParam _SalePriceCompareParam = CompareParam.Equal;
          public string _SalePriceDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_SaleXinPan
          private System.DateTime _SaleXinPan;
          private bool _SaleXinPanChanged = false;
          CompareParam _SaleXinPanCompareParam = CompareParam.Equal;
          public string _SaleXinPanDbType = "datetime";
          #endregion
  
          #region 成员变量:_StoryHeight
          private System.Decimal _StoryHeight;
          private bool _StoryHeightChanged = false;
          CompareParam _StoryHeightCompareParam = CompareParam.Equal;
          public string _StoryHeightDbType = "numeric";
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
  
          #region 成员变量:_UpdateTime
          private System.DateTime _UpdateTime;
          private bool _UpdateTimeChanged = false;
          CompareParam _UpdateTimeCompareParam = CompareParam.Equal;
          public string _UpdateTimeDbType = "datetime";
          #endregion
  
          /// <summary>
          /// 构造函数
          /// </summary>
          public DiscBuildingCacheEntity()
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
        /// 说明: 外部支持
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
        /// 说明: 建筑年限
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
        public System.String BuildingCode
        {
          get { return _BuildingCode; }
          set {
                _BuildingCode = value;
                BuildingCodeChanged=true;
              }
        }

        /// <summary>
        /// 属性: _BuildingCodeChanged
        /// </summary>
        public bool BuildingCodeChanged
        {
          get { return _BuildingCodeChanged;}
          set {
                _BuildingCodeChanged=value;
              }
        }

        /// <summary>
        /// 属性: _BuildingCodeCompareParam
        /// </summary>
        public CompareParam BuildingCodeCompareParam
        {
          get { return _BuildingCodeCompareParam ;}
          set {
                _BuildingCodeCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _BuildingCode的数据库存储类型
        /// </summary>
        public string BuildingCodeDbType
        {
          get { 
                return _BuildingCodeDbType;
              }
        }
  
        /// <summary>
        /// 说明: 建筑开发商
        /// </summary>
        public System.String BuildingDeveloper
        {
          get { return _BuildingDeveloper; }
          set {
                _BuildingDeveloper = value;
                BuildingDeveloperChanged=true;
              }
        }

        /// <summary>
        /// 属性: _BuildingDeveloperChanged
        /// </summary>
        public bool BuildingDeveloperChanged
        {
          get { return _BuildingDeveloperChanged;}
          set {
                _BuildingDeveloperChanged=value;
              }
        }

        /// <summary>
        /// 属性: _BuildingDeveloperCompareParam
        /// </summary>
        public CompareParam BuildingDeveloperCompareParam
        {
          get { return _BuildingDeveloperCompareParam ;}
          set {
                _BuildingDeveloperCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _BuildingDeveloper的数据库存储类型
        /// </summary>
        public string BuildingDeveloperDbType
        {
          get { 
                return _BuildingDeveloperDbType;
              }
        }
  
        /// <summary>
        /// 说明: 建材设施
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
        /// 说明: 建筑功能[项目特色]
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
        public System.Decimal BuildingHeight
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
        /// 说明: 楼盘图片
        /// </summary>
        public System.String BuildingImg
        {
          get { return _BuildingImg; }
          set {
                _BuildingImg = value;
                BuildingImgChanged=true;
              }
        }

        /// <summary>
        /// 属性: _BuildingImgChanged
        /// </summary>
        public bool BuildingImgChanged
        {
          get { return _BuildingImgChanged;}
          set {
                _BuildingImgChanged=value;
              }
        }

        /// <summary>
        /// 属性: _BuildingImgCompareParam
        /// </summary>
        public CompareParam BuildingImgCompareParam
        {
          get { return _BuildingImgCompareParam ;}
          set {
                _BuildingImgCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _BuildingImg的数据库存储类型
        /// </summary>
        public string BuildingImgDbType
        {
          get { 
                return _BuildingImgDbType;
              }
        }
  
        /// <summary>
        /// 说明: 建筑投资者
        /// </summary>
        public System.String BuildingInvestor
        {
          get { return _BuildingInvestor; }
          set {
                _BuildingInvestor = value;
                BuildingInvestorChanged=true;
              }
        }

        /// <summary>
        /// 属性: _BuildingInvestorChanged
        /// </summary>
        public bool BuildingInvestorChanged
        {
          get { return _BuildingInvestorChanged;}
          set {
                _BuildingInvestorChanged=value;
              }
        }

        /// <summary>
        /// 属性: _BuildingInvestorCompareParam
        /// </summary>
        public CompareParam BuildingInvestorCompareParam
        {
          get { return _BuildingInvestorCompareParam ;}
          set {
                _BuildingInvestorCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _BuildingInvestor的数据库存储类型
        /// </summary>
        public string BuildingInvestorDbType
        {
          get { 
                return _BuildingInvestorDbType;
              }
        }
  
        /// <summary>
        /// 说明: 写字楼类型[1:甲级写字楼]
        /// </summary>
        public System.Int32 BuildingLevel
        {
          get { return _BuildingLevel; }
          set {
                _BuildingLevel = value;
                BuildingLevelChanged=true;
              }
        }

        /// <summary>
        /// 属性: _BuildingLevelChanged
        /// </summary>
        public bool BuildingLevelChanged
        {
          get { return _BuildingLevelChanged;}
          set {
                _BuildingLevelChanged=value;
              }
        }

        /// <summary>
        /// 属性: _BuildingLevelCompareParam
        /// </summary>
        public CompareParam BuildingLevelCompareParam
        {
          get { return _BuildingLevelCompareParam ;}
          set {
                _BuildingLevelCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _BuildingLevel的数据库存储类型
        /// </summary>
        public string BuildingLevelDbType
        {
          get { 
                return _BuildingLevelDbType;
              }
        }
  
        /// <summary>
        /// 说明: 楼盘位置
        /// </summary>
        public System.String BuildingLocation
        {
          get { return _BuildingLocation; }
          set {
                _BuildingLocation = value;
                BuildingLocationChanged=true;
              }
        }

        /// <summary>
        /// 属性: _BuildingLocationChanged
        /// </summary>
        public bool BuildingLocationChanged
        {
          get { return _BuildingLocationChanged;}
          set {
                _BuildingLocationChanged=value;
              }
        }

        /// <summary>
        /// 属性: _BuildingLocationCompareParam
        /// </summary>
        public CompareParam BuildingLocationCompareParam
        {
          get { return _BuildingLocationCompareParam ;}
          set {
                _BuildingLocationCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _BuildingLocation的数据库存储类型
        /// </summary>
        public string BuildingLocationDbType
        {
          get { 
                return _BuildingLocationDbType;
              }
        }
  
        /// <summary>
        /// 说明: 楼盘名称
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
        /// 说明: 建筑类型[5:综合体]
        /// </summary>
        public System.Int32 BuildingProperty
        {
          get { return _BuildingProperty; }
          set {
                _BuildingProperty = value;
                BuildingPropertyChanged=true;
              }
        }

        /// <summary>
        /// 属性: _BuildingPropertyChanged
        /// </summary>
        public bool BuildingPropertyChanged
        {
          get { return _BuildingPropertyChanged;}
          set {
                _BuildingPropertyChanged=value;
              }
        }

        /// <summary>
        /// 属性: _BuildingPropertyCompareParam
        /// </summary>
        public CompareParam BuildingPropertyCompareParam
        {
          get { return _BuildingPropertyCompareParam ;}
          set {
                _BuildingPropertyCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _BuildingProperty的数据库存储类型
        /// </summary>
        public string BuildingPropertyDbType
        {
          get { 
                return _BuildingPropertyDbType;
              }
        }
  
        /// <summary>
        /// 说明: 商务区代码[例如解放碑]
        /// </summary>
        public System.String BusinessDistrictCode
        {
          get { return _BusinessDistrictCode; }
          set {
                _BusinessDistrictCode = value;
                BusinessDistrictCodeChanged=true;
              }
        }

        /// <summary>
        /// 属性: _BusinessDistrictCodeChanged
        /// </summary>
        public bool BusinessDistrictCodeChanged
        {
          get { return _BusinessDistrictCodeChanged;}
          set {
                _BusinessDistrictCodeChanged=value;
              }
        }

        /// <summary>
        /// 属性: _BusinessDistrictCodeCompareParam
        /// </summary>
        public CompareParam BusinessDistrictCodeCompareParam
        {
          get { return _BusinessDistrictCodeCompareParam ;}
          set {
                _BusinessDistrictCodeCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _BusinessDistrictCode的数据库存储类型
        /// </summary>
        public string BusinessDistrictCodeDbType
        {
          get { 
                return _BusinessDistrictCodeDbType;
              }
        }
  
        /// <summary>
        /// 说明: 业务地区[例如：渝中]
        /// </summary>
        public System.String BusinessRegionCode
        {
          get { return _BusinessRegionCode; }
          set {
                _BusinessRegionCode = value;
                BusinessRegionCodeChanged=true;
              }
        }

        /// <summary>
        /// 属性: _BusinessRegionCodeChanged
        /// </summary>
        public bool BusinessRegionCodeChanged
        {
          get { return _BusinessRegionCodeChanged;}
          set {
                _BusinessRegionCodeChanged=value;
              }
        }

        /// <summary>
        /// 属性: _BusinessRegionCodeCompareParam
        /// </summary>
        public CompareParam BusinessRegionCodeCompareParam
        {
          get { return _BusinessRegionCodeCompareParam ;}
          set {
                _BusinessRegionCodeCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _BusinessRegionCode的数据库存储类型
        /// </summary>
        public string BusinessRegionCodeDbType
        {
          get { 
                return _BusinessRegionCodeDbType;
              }
        }
  
        /// <summary>
        /// 说明: 装修情况[精装修]
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
        /// 说明: 描述
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
        /// 说明: 楼层状况
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
        public System.Int32 Id
        {
          get { return _Id; }
          set {
                _Id = value;
                IdChanged=true;
              }
        }

        /// <summary>
        /// 属性: _IdChanged
        /// </summary>
        public bool IdChanged
        {
          get { return _IdChanged;}
          set {
                _IdChanged=value;
              }
        }

        /// <summary>
        /// 属性: _IdCompareParam
        /// </summary>
        public CompareParam IdCompareParam
        {
          get { return _IdCompareParam ;}
          set {
                _IdCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _Id的数据库存储类型
        /// </summary>
        public string IdDbType
        {
          get { 
                return _IdDbType;
              }
        }
  
        /// <summary>
        /// 说明: 内部支持
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
        /// 说明: 新盘1、在售2、在租3
        /// </summary>
        public System.String IsNew
        {
          get { return _IsNew; }
          set {
                _IsNew = value;
                IsNewChanged=true;
              }
        }

        /// <summary>
        /// 属性: _IsNewChanged
        /// </summary>
        public bool IsNewChanged
        {
          get { return _IsNewChanged;}
          set {
                _IsNewChanged=value;
              }
        }

        /// <summary>
        /// 属性: _IsNewCompareParam
        /// </summary>
        public CompareParam IsNewCompareParam
        {
          get { return _IsNewCompareParam ;}
          set {
                _IsNewCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _IsNew的数据库存储类型
        /// </summary>
        public string IsNewDbType
        {
          get { 
                return _IsNewDbType;
              }
        }
  
        /// <summary>
        /// 说明: 是否显示在首页上
        /// </summary>
        public System.Boolean IsShow
        {
          get { return _IsShow; }
          set {
                _IsShow = value;
                IsShowChanged=true;
              }
        }

        /// <summary>
        /// 属性: _IsShowChanged
        /// </summary>
        public bool IsShowChanged
        {
          get { return _IsShowChanged;}
          set {
                _IsShowChanged=value;
              }
        }

        /// <summary>
        /// 属性: _IsShowCompareParam
        /// </summary>
        public CompareParam IsShowCompareParam
        {
          get { return _IsShowCompareParam ;}
          set {
                _IsShowCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _IsShow的数据库存储类型
        /// </summary>
        public string IsShowDbType
        {
          get { 
                return _IsShowDbType;
              }
        }
  
        /// <summary>
        /// 说明: 是否推荐
        /// </summary>
        public System.Boolean isUp
        {
          get { return _isUp; }
          set {
                _isUp = value;
                isUpChanged=true;
              }
        }

        /// <summary>
        /// 属性: _isUpChanged
        /// </summary>
        public bool isUpChanged
        {
          get { return _isUpChanged;}
          set {
                _isUpChanged=value;
              }
        }

        /// <summary>
        /// 属性: _isUpCompareParam
        /// </summary>
        public CompareParam isUpCompareParam
        {
          get { return _isUpCompareParam ;}
          set {
                _isUpCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _isUp的数据库存储类型
        /// </summary>
        public string isUpDbType
        {
          get { 
                return _isUpDbType;
              }
        }
  
        /// <summary>
        /// 说明: 电梯数目
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
        /// 说明: 百度地图坐标
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
        public System.String NickName
        {
          get { return _NickName; }
          set {
                _NickName = value;
                NickNameChanged=true;
              }
        }

        /// <summary>
        /// 属性: _NickNameChanged
        /// </summary>
        public bool NickNameChanged
        {
          get { return _NickNameChanged;}
          set {
                _NickNameChanged=value;
              }
        }

        /// <summary>
        /// 属性: _NickNameCompareParam
        /// </summary>
        public CompareParam NickNameCompareParam
        {
          get { return _NickNameCompareParam ;}
          set {
                _NickNameCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _NickName的数据库存储类型
        /// </summary>
        public string NickNameDbType
        {
          get { 
                return _NickNameDbType;
              }
        }
  
        /// <summary>
        /// 说明: 总占地面积
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
        /// 说明: 停车位置
        /// </summary>
        public System.String ParkingDescri
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
        /// 说明: 产权费用[物管费]
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
        /// 说明: 物业经理[物管]
        /// </summary>
        public System.String PropertyManager
        {
          get { return _PropertyManager; }
          set {
                _PropertyManager = value;
                PropertyManagerChanged=true;
              }
        }

        /// <summary>
        /// 属性: _PropertyManagerChanged
        /// </summary>
        public bool PropertyManagerChanged
        {
          get { return _PropertyManagerChanged;}
          set {
                _PropertyManagerChanged=value;
              }
        }

        /// <summary>
        /// 属性: _PropertyManagerCompareParam
        /// </summary>
        public CompareParam PropertyManagerCompareParam
        {
          get { return _PropertyManagerCompareParam ;}
          set {
                _PropertyManagerCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _PropertyManager的数据库存储类型
        /// </summary>
        public string PropertyManagerDbType
        {
          get { 
                return _PropertyManagerDbType;
              }
        }
  
        /// <summary>
        /// 说明: 租金
        /// </summary>
        public System.String RentPrice
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
        /// 说明: 售价
        /// </summary>
        public System.String SalePrice
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
        /// 说明: 新盘时间
        /// </summary>
        public System.DateTime SaleXinPan
        {
          get { return _SaleXinPan; }
          set {
                _SaleXinPan = value;
                SaleXinPanChanged=true;
              }
        }

        /// <summary>
        /// 属性: _SaleXinPanChanged
        /// </summary>
        public bool SaleXinPanChanged
        {
          get { return _SaleXinPanChanged;}
          set {
                _SaleXinPanChanged=value;
              }
        }

        /// <summary>
        /// 属性: _SaleXinPanCompareParam
        /// </summary>
        public CompareParam SaleXinPanCompareParam
        {
          get { return _SaleXinPanCompareParam ;}
          set {
                _SaleXinPanCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _SaleXinPan的数据库存储类型
        /// </summary>
        public string SaleXinPanDbType
        {
          get { 
                return _SaleXinPanDbType;
              }
        }
  
        /// <summary>
        /// 说明: 楼层高度
        /// </summary>
        public System.Decimal StoryHeight
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
        /// 说明: 交通
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
        /// 说明: 占地面积
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
        public System.DateTime UpdateTime
        {
          get { return _UpdateTime; }
          set {
                _UpdateTime = value;
                UpdateTimeChanged=true;
              }
        }

        /// <summary>
        /// 属性: _UpdateTimeChanged
        /// </summary>
        public bool UpdateTimeChanged
        {
          get { return _UpdateTimeChanged;}
          set {
                _UpdateTimeChanged=value;
              }
        }

        /// <summary>
        /// 属性: _UpdateTimeCompareParam
        /// </summary>
        public CompareParam UpdateTimeCompareParam
        {
          get { return _UpdateTimeCompareParam ;}
          set {
                _UpdateTimeCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _UpdateTime的数据库存储类型
        /// </summary>
        public string UpdateTimeDbType
        {
          get { 
                return _UpdateTimeDbType;
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
  