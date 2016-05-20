
    /// <summary>
    /// 说  明：本代码由工具软件生成，数据库设计发生变化后，应重新自动生成。
    /// 日  期：2015年10月09日 23:26:39
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
      /// 数据库表DiscUserBuilding所对应的实体类
      /// </summary>
    public partial class DiscUserBuildingEntity:IEntity
    {
        #region 主键字段数组，存储主键字段列名。
      private string[] _PrimaryKeys = {"UserBuildingId"};
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
  
          #region 成员变量:_PropertyFees
          private System.Decimal _PropertyFees;
          private bool _PropertyFeesChanged = false;
          CompareParam _PropertyFeesCompareParam = CompareParam.Equal;
          public string _PropertyFeesDbType = "numeric";
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
          public DiscUserBuildingEntity()
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
        /// 说明: 外部环境
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
        /// 说明: 建筑设施
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
        /// 说明: 建筑特点
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
        /// 说明: 建筑高度
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
        /// 说明: 楼盘Id
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
        /// 说明: 装修情况
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
        /// 说明: 地面条件
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
        /// 说明: 录入时间
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
        /// 说明: 内部环境
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
        /// 说明: 电梯数量
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
        /// 说明: 坐标点
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
        /// 说明: 总建筑面积
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
        /// 说明: 停车位
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
        /// 说明: 物业费
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
        /// 说明: 租金
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
        /// 说明: 售价
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
        /// 说明: 层高
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
        /// 说明: 交通情况
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
        /// 说明: 实际建筑面积
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
        /// 说明: 用户楼盘表
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
  