
    /// <summary>
    /// 说  明：本代码由工具软件生成，数据库设计发生变化后，应重新自动生成。
    /// 日  期：2015年10月10日 00:03:43
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
      /// 数据库表DiscOfficeRent所对应的实体类
      /// </summary>
    public partial class DiscOfficeRentEntity:IEntity
    {
        #region 主键字段数组，存储主键字段列名。
      private string[] _PrimaryKeys = {"OfficeRentId"};
      #endregion

          #region 成员变量:_BuildingId
          private System.Int32 _BuildingId;
          private bool _BuildingIdChanged = false;
          CompareParam _BuildingIdCompareParam = CompareParam.Equal;
          public string _BuildingIdDbType = "int";
          #endregion
  
          #region 成员变量:_Descri
          private System.String _Descri;
          private bool _DescriChanged = false;
          CompareParam _DescriCompareParam = CompareParam.Equal;
          public string _DescriDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_Floor
          private System.Int32 _Floor;
          private bool _FloorChanged = false;
          CompareParam _FloorCompareParam = CompareParam.Equal;
          public string _FloorDbType = "int";
          #endregion
  
          #region 成员变量:_HitCount
          private System.Int32 _HitCount;
          private bool _HitCountChanged = false;
          CompareParam _HitCountCompareParam = CompareParam.Equal;
          public string _HitCountDbType = "int";
          #endregion
  
          #region 成员变量:_InputTime
          private System.DateTime _InputTime;
          private bool _InputTimeChanged = false;
          CompareParam _InputTimeCompareParam = CompareParam.Equal;
          public string _InputTimeDbType = "datetime";
          #endregion
  
          #region 成员变量:_InternalCode
          private System.String _InternalCode;
          private bool _InternalCodeChanged = false;
          CompareParam _InternalCodeCompareParam = CompareParam.Equal;
          public string _InternalCodeDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_IsDivision
          private System.Boolean _IsDivision;
          private bool _IsDivisionChanged = false;
          CompareParam _IsDivisionCompareParam = CompareParam.Equal;
          public string _IsDivisionDbType = "bit";
          #endregion
  
          #region 成员变量:_IsPropertyFees
          private System.Boolean _IsPropertyFees;
          private bool _IsPropertyFeesChanged = false;
          CompareParam _IsPropertyFeesCompareParam = CompareParam.Equal;
          public string _IsPropertyFeesDbType = "bit";
          #endregion
  
          #region 成员变量:_IsTemplate
          private System.Boolean _IsTemplate;
          private bool _IsTemplateChanged = false;
          CompareParam _IsTemplateCompareParam = CompareParam.Equal;
          public string _IsTemplateDbType = "bit";
          #endregion
  
          #region 成员变量:_OfficeGradeId
          private System.Int32 _OfficeGradeId;
          private bool _OfficeGradeIdChanged = false;
          CompareParam _OfficeGradeIdCompareParam = CompareParam.Equal;
          public string _OfficeGradeIdDbType = "int";
          #endregion
  
          #region 成员变量:_OfficeRentAddress
          private System.String _OfficeRentAddress;
          private bool _OfficeRentAddressChanged = false;
          CompareParam _OfficeRentAddressCompareParam = CompareParam.Equal;
          public string _OfficeRentAddressDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_OfficeRentId
          private System.Int32 _OfficeRentId;
          private bool _OfficeRentIdChanged = false;
          CompareParam _OfficeRentIdCompareParam = CompareParam.Equal;
          public string _OfficeRentIdDbType = "int";
          #endregion
  
          #region 成员变量:_OfficeRentName
          private System.String _OfficeRentName;
          private bool _OfficeRentNameChanged = false;
          CompareParam _OfficeRentNameCompareParam = CompareParam.Equal;
          public string _OfficeRentNameDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_OfficeTypeId
          private System.Int32 _OfficeTypeId;
          private bool _OfficeTypeIdChanged = false;
          CompareParam _OfficeTypeIdCompareParam = CompareParam.Equal;
          public string _OfficeTypeIdDbType = "int";
          #endregion
  
          #region 成员变量:_PaymentMethodId
          private System.Int32 _PaymentMethodId;
          private bool _PaymentMethodIdChanged = false;
          CompareParam _PaymentMethodIdCompareParam = CompareParam.Equal;
          public string _PaymentMethodIdDbType = "int";
          #endregion
  
          #region 成员变量:_PropertyFees
          private System.Decimal _PropertyFees;
          private bool _PropertyFeesChanged = false;
          CompareParam _PropertyFeesCompareParam = CompareParam.Equal;
          public string _PropertyFeesDbType = "decimal";
          #endregion
  
          #region 成员变量:_RentPrice
          private System.Decimal _RentPrice;
          private bool _RentPriceChanged = false;
          CompareParam _RentPriceCompareParam = CompareParam.Equal;
          public string _RentPriceDbType = "decimal";
          #endregion
  
          #region 成员变量:_RoomNumber
          private System.String _RoomNumber;
          private bool _RoomNumberChanged = false;
          CompareParam _RoomNumberCompareParam = CompareParam.Equal;
          public string _RoomNumberDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_SquareFootage
          private System.String _SquareFootage;
          private bool _SquareFootageChanged = false;
          CompareParam _SquareFootageCompareParam = CompareParam.Equal;
          public string _SquareFootageDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_UploadGroupId
          private System.Int32 _UploadGroupId;
          private bool _UploadGroupIdChanged = false;
          CompareParam _UploadGroupIdCompareParam = CompareParam.Equal;
          public string _UploadGroupIdDbType = "int";
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
          public DiscOfficeRentEntity()
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
        /// 说明: 描述
        /// </summary>
        public System.String Descri
        {
          get { return _Descri; }
          set {
                _Descri = value;
                DescriChanged=true;
              }
        }

        /// <summary>
        /// 属性: _DescriChanged
        /// </summary>
        public bool DescriChanged
        {
          get { return _DescriChanged;}
          set {
                _DescriChanged=value;
              }
        }

        /// <summary>
        /// 属性: _DescriCompareParam
        /// </summary>
        public CompareParam DescriCompareParam
        {
          get { return _DescriCompareParam ;}
          set {
                _DescriCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _Descri的数据库存储类型
        /// </summary>
        public string DescriDbType
        {
          get { 
                return _DescriDbType;
              }
        }
  
        /// <summary>
        /// 说明: 楼层
        /// </summary>
        public System.Int32 Floor
        {
          get { return _Floor; }
          set {
                _Floor = value;
                FloorChanged=true;
              }
        }

        /// <summary>
        /// 属性: _FloorChanged
        /// </summary>
        public bool FloorChanged
        {
          get { return _FloorChanged;}
          set {
                _FloorChanged=value;
              }
        }

        /// <summary>
        /// 属性: _FloorCompareParam
        /// </summary>
        public CompareParam FloorCompareParam
        {
          get { return _FloorCompareParam ;}
          set {
                _FloorCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _Floor的数据库存储类型
        /// </summary>
        public string FloorDbType
        {
          get { 
                return _FloorDbType;
              }
        }
  
        /// <summary>
        /// 说明: 点击次数
        /// </summary>
        public System.Int32 HitCount
        {
          get { return _HitCount; }
          set {
                _HitCount = value;
                HitCountChanged=true;
              }
        }

        /// <summary>
        /// 属性: _HitCountChanged
        /// </summary>
        public bool HitCountChanged
        {
          get { return _HitCountChanged;}
          set {
                _HitCountChanged=value;
              }
        }

        /// <summary>
        /// 属性: _HitCountCompareParam
        /// </summary>
        public CompareParam HitCountCompareParam
        {
          get { return _HitCountCompareParam ;}
          set {
                _HitCountCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _HitCount的数据库存储类型
        /// </summary>
        public string HitCountDbType
        {
          get { 
                return _HitCountDbType;
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
        /// 说明: 内部编号
        /// </summary>
        public System.String InternalCode
        {
          get { return _InternalCode; }
          set {
                _InternalCode = value;
                InternalCodeChanged=true;
              }
        }

        /// <summary>
        /// 属性: _InternalCodeChanged
        /// </summary>
        public bool InternalCodeChanged
        {
          get { return _InternalCodeChanged;}
          set {
                _InternalCodeChanged=value;
              }
        }

        /// <summary>
        /// 属性: _InternalCodeCompareParam
        /// </summary>
        public CompareParam InternalCodeCompareParam
        {
          get { return _InternalCodeCompareParam ;}
          set {
                _InternalCodeCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _InternalCode的数据库存储类型
        /// </summary>
        public string InternalCodeDbType
        {
          get { 
                return _InternalCodeDbType;
              }
        }
  
        /// <summary>
        /// 说明: 是否可分割
        /// </summary>
        public System.Boolean IsDivision
        {
          get { return _IsDivision; }
          set {
                _IsDivision = value;
                IsDivisionChanged=true;
              }
        }

        /// <summary>
        /// 属性: _IsDivisionChanged
        /// </summary>
        public bool IsDivisionChanged
        {
          get { return _IsDivisionChanged;}
          set {
                _IsDivisionChanged=value;
              }
        }

        /// <summary>
        /// 属性: _IsDivisionCompareParam
        /// </summary>
        public CompareParam IsDivisionCompareParam
        {
          get { return _IsDivisionCompareParam ;}
          set {
                _IsDivisionCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _IsDivision的数据库存储类型
        /// </summary>
        public string IsDivisionDbType
        {
          get { 
                return _IsDivisionDbType;
              }
        }
  
        /// <summary>
        /// 说明: 是否含物业费
        /// </summary>
        public System.Boolean IsPropertyFees
        {
          get { return _IsPropertyFees; }
          set {
                _IsPropertyFees = value;
                IsPropertyFeesChanged=true;
              }
        }

        /// <summary>
        /// 属性: _IsPropertyFeesChanged
        /// </summary>
        public bool IsPropertyFeesChanged
        {
          get { return _IsPropertyFeesChanged;}
          set {
                _IsPropertyFeesChanged=value;
              }
        }

        /// <summary>
        /// 属性: _IsPropertyFeesCompareParam
        /// </summary>
        public CompareParam IsPropertyFeesCompareParam
        {
          get { return _IsPropertyFeesCompareParam ;}
          set {
                _IsPropertyFeesCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _IsPropertyFees的数据库存储类型
        /// </summary>
        public string IsPropertyFeesDbType
        {
          get { 
                return _IsPropertyFeesDbType;
              }
        }
  
        /// <summary>
        /// 说明: 是否是模版
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
        /// 说明: 写字楼等级
        /// </summary>
        public System.Int32 OfficeGradeId
        {
          get { return _OfficeGradeId; }
          set {
                _OfficeGradeId = value;
                OfficeGradeIdChanged=true;
              }
        }

        /// <summary>
        /// 属性: _OfficeGradeIdChanged
        /// </summary>
        public bool OfficeGradeIdChanged
        {
          get { return _OfficeGradeIdChanged;}
          set {
                _OfficeGradeIdChanged=value;
              }
        }

        /// <summary>
        /// 属性: _OfficeGradeIdCompareParam
        /// </summary>
        public CompareParam OfficeGradeIdCompareParam
        {
          get { return _OfficeGradeIdCompareParam ;}
          set {
                _OfficeGradeIdCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _OfficeGradeId的数据库存储类型
        /// </summary>
        public string OfficeGradeIdDbType
        {
          get { 
                return _OfficeGradeIdDbType;
              }
        }
  
        /// <summary>
        /// 说明: 写字楼地址
        /// </summary>
        public System.String OfficeRentAddress
        {
          get { return _OfficeRentAddress; }
          set {
                _OfficeRentAddress = value;
                OfficeRentAddressChanged=true;
              }
        }

        /// <summary>
        /// 属性: _OfficeRentAddressChanged
        /// </summary>
        public bool OfficeRentAddressChanged
        {
          get { return _OfficeRentAddressChanged;}
          set {
                _OfficeRentAddressChanged=value;
              }
        }

        /// <summary>
        /// 属性: _OfficeRentAddressCompareParam
        /// </summary>
        public CompareParam OfficeRentAddressCompareParam
        {
          get { return _OfficeRentAddressCompareParam ;}
          set {
                _OfficeRentAddressCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _OfficeRentAddress的数据库存储类型
        /// </summary>
        public string OfficeRentAddressDbType
        {
          get { 
                return _OfficeRentAddressDbType;
              }
        }
  
        /// <summary>
        /// 说明: 写字楼
        /// </summary>
        public System.Int32 OfficeRentId
        {
          get { return _OfficeRentId; }
          set {
                _OfficeRentId = value;
                OfficeRentIdChanged=true;
              }
        }

        /// <summary>
        /// 属性: _OfficeRentIdChanged
        /// </summary>
        public bool OfficeRentIdChanged
        {
          get { return _OfficeRentIdChanged;}
          set {
                _OfficeRentIdChanged=value;
              }
        }

        /// <summary>
        /// 属性: _OfficeRentIdCompareParam
        /// </summary>
        public CompareParam OfficeRentIdCompareParam
        {
          get { return _OfficeRentIdCompareParam ;}
          set {
                _OfficeRentIdCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _OfficeRentId的数据库存储类型
        /// </summary>
        public string OfficeRentIdDbType
        {
          get { 
                return _OfficeRentIdDbType;
              }
        }
  
        /// <summary>
        /// 说明: 写字楼名
        /// </summary>
        public System.String OfficeRentName
        {
          get { return _OfficeRentName; }
          set {
                _OfficeRentName = value;
                OfficeRentNameChanged=true;
              }
        }

        /// <summary>
        /// 属性: _OfficeRentNameChanged
        /// </summary>
        public bool OfficeRentNameChanged
        {
          get { return _OfficeRentNameChanged;}
          set {
                _OfficeRentNameChanged=value;
              }
        }

        /// <summary>
        /// 属性: _OfficeRentNameCompareParam
        /// </summary>
        public CompareParam OfficeRentNameCompareParam
        {
          get { return _OfficeRentNameCompareParam ;}
          set {
                _OfficeRentNameCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _OfficeRentName的数据库存储类型
        /// </summary>
        public string OfficeRentNameDbType
        {
          get { 
                return _OfficeRentNameDbType;
              }
        }
  
        /// <summary>
        /// 说明: 写字楼类型
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
        /// 说明: 支付方式
        /// </summary>
        public System.Int32 PaymentMethodId
        {
          get { return _PaymentMethodId; }
          set {
                _PaymentMethodId = value;
                PaymentMethodIdChanged=true;
              }
        }

        /// <summary>
        /// 属性: _PaymentMethodIdChanged
        /// </summary>
        public bool PaymentMethodIdChanged
        {
          get { return _PaymentMethodIdChanged;}
          set {
                _PaymentMethodIdChanged=value;
              }
        }

        /// <summary>
        /// 属性: _PaymentMethodIdCompareParam
        /// </summary>
        public CompareParam PaymentMethodIdCompareParam
        {
          get { return _PaymentMethodIdCompareParam ;}
          set {
                _PaymentMethodIdCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _PaymentMethodId的数据库存储类型
        /// </summary>
        public string PaymentMethodIdDbType
        {
          get { 
                return _PaymentMethodIdDbType;
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
        /// 说明: 房号
        /// </summary>
        public System.String RoomNumber
        {
          get { return _RoomNumber; }
          set {
                _RoomNumber = value;
                RoomNumberChanged=true;
              }
        }

        /// <summary>
        /// 属性: _RoomNumberChanged
        /// </summary>
        public bool RoomNumberChanged
        {
          get { return _RoomNumberChanged;}
          set {
                _RoomNumberChanged=value;
              }
        }

        /// <summary>
        /// 属性: _RoomNumberCompareParam
        /// </summary>
        public CompareParam RoomNumberCompareParam
        {
          get { return _RoomNumberCompareParam ;}
          set {
                _RoomNumberCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _RoomNumber的数据库存储类型
        /// </summary>
        public string RoomNumberDbType
        {
          get { 
                return _RoomNumberDbType;
              }
        }
  
        /// <summary>
        /// 说明: 建筑面积
        /// </summary>
        public System.String SquareFootage
        {
          get { return _SquareFootage; }
          set {
                _SquareFootage = value;
                SquareFootageChanged=true;
              }
        }

        /// <summary>
        /// 属性: _SquareFootageChanged
        /// </summary>
        public bool SquareFootageChanged
        {
          get { return _SquareFootageChanged;}
          set {
                _SquareFootageChanged=value;
              }
        }

        /// <summary>
        /// 属性: _SquareFootageCompareParam
        /// </summary>
        public CompareParam SquareFootageCompareParam
        {
          get { return _SquareFootageCompareParam ;}
          set {
                _SquareFootageCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _SquareFootage的数据库存储类型
        /// </summary>
        public string SquareFootageDbType
        {
          get { 
                return _SquareFootageDbType;
              }
        }
  
        /// <summary>
        /// 说明: 图片分组Id
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
        /// 说明: 信息所有人Id
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
  