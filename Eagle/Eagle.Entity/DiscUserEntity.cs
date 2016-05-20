
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
      /// 数据库表DiscUser所对应的实体类
      /// </summary>
    public partial class DiscUserEntity:IEntity
    {
        #region 主键字段数组，存储主键字段列名。
      private string[] _PrimaryKeys = {"UserId"};
      #endregion

          #region 成员变量:_Company
          private System.String _Company;
          private bool _CompanyChanged = false;
          CompareParam _CompanyCompareParam = CompareParam.Equal;
          public string _CompanyDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_ConLoginDates
          private System.Int32 _ConLoginDates;
          private bool _ConLoginDatesChanged = false;
          CompareParam _ConLoginDatesCompareParam = CompareParam.Equal;
          public string _ConLoginDatesDbType = "int";
          #endregion
  
          #region 成员变量:_CreateDate
          private System.DateTime _CreateDate;
          private bool _CreateDateChanged = false;
          CompareParam _CreateDateCompareParam = CompareParam.Equal;
          public string _CreateDateDbType = "smalldatetime";
          #endregion
  
          #region 成员变量:_Email
          private System.String _Email;
          private bool _EmailChanged = false;
          CompareParam _EmailCompareParam = CompareParam.Equal;
          public string _EmailDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_Integral
          private System.Int32 _Integral;
          private bool _IntegralChanged = false;
          CompareParam _IntegralCompareParam = CompareParam.Equal;
          public string _IntegralDbType = "int";
          #endregion
  
          #region 成员变量:_IsEmail
          private System.Boolean _IsEmail;
          private bool _IsEmailChanged = false;
          CompareParam _IsEmailCompareParam = CompareParam.Equal;
          public string _IsEmailDbType = "bit";
          #endregion
  
          #region 成员变量:_IsValid
          private System.Boolean _IsValid;
          private bool _IsValidChanged = false;
          CompareParam _IsValidCompareParam = CompareParam.Equal;
          public string _IsValidDbType = "bit";
          #endregion
  
          #region 成员变量:_JianJie
          private System.String _JianJie;
          private bool _JianJieChanged = false;
          CompareParam _JianJieCompareParam = CompareParam.Equal;
          public string _JianJieDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_LoginDate
          private System.DateTime _LoginDate;
          private bool _LoginDateChanged = false;
          CompareParam _LoginDateCompareParam = CompareParam.Equal;
          public string _LoginDateDbType = "smalldatetime";
          #endregion
  
          #region 成员变量:_LoginDates
          private System.Int32 _LoginDates;
          private bool _LoginDatesChanged = false;
          CompareParam _LoginDatesCompareParam = CompareParam.Equal;
          public string _LoginDatesDbType = "int";
          #endregion
  
          #region 成员变量:_MSN
          private System.String _MSN;
          private bool _MSNChanged = false;
          CompareParam _MSNCompareParam = CompareParam.Equal;
          public string _MSNDbType = "varchar";
          #endregion
  
          #region 成员变量:_OpenId
          private System.String _OpenId;
          private bool _OpenIdChanged = false;
          CompareParam _OpenIdCompareParam = CompareParam.Equal;
          public string _OpenIdDbType = "varchar";
          #endregion
  
          #region 成员变量:_Phone
          private System.String _Phone;
          private bool _PhoneChanged = false;
          CompareParam _PhoneCompareParam = CompareParam.Equal;
          public string _PhoneDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_QQ
          private System.String _QQ;
          private bool _QQChanged = false;
          CompareParam _QQCompareParam = CompareParam.Equal;
          public string _QQDbType = "varchar";
          #endregion
  
          #region 成员变量:_RoleCode
          private System.String _RoleCode;
          private bool _RoleCodeChanged = false;
          CompareParam _RoleCodeCompareParam = CompareParam.Equal;
          public string _RoleCodeDbType = "nchar";
          #endregion
  
          #region 成员变量:_ServiceCall
          private System.String _ServiceCall;
          private bool _ServiceCallChanged = false;
          CompareParam _ServiceCallCompareParam = CompareParam.Equal;
          public string _ServiceCallDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_UploadGroupId
          private System.Int32 _UploadGroupId;
          private bool _UploadGroupIdChanged = false;
          CompareParam _UploadGroupIdCompareParam = CompareParam.Equal;
          public string _UploadGroupIdDbType = "int";
          #endregion
  
          #region 成员变量:_UserAccount
          private System.String _UserAccount;
          private bool _UserAccountChanged = false;
          CompareParam _UserAccountCompareParam = CompareParam.Equal;
          public string _UserAccountDbType = "varchar";
          #endregion
  
          #region 成员变量:_UserId
          private System.Int32 _UserId;
          private bool _UserIdChanged = false;
          CompareParam _UserIdCompareParam = CompareParam.Equal;
          public string _UserIdDbType = "int";
          #endregion
  
          #region 成员变量:_UserName
          private System.String _UserName;
          private bool _UserNameChanged = false;
          CompareParam _UserNameCompareParam = CompareParam.Equal;
          public string _UserNameDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_UserPwd
          private System.String _UserPwd;
          private bool _UserPwdChanged = false;
          CompareParam _UserPwdCompareParam = CompareParam.Equal;
          public string _UserPwdDbType = "varchar";
          #endregion
  
          /// <summary>
          /// 构造函数
          /// </summary>
          public DiscUserEntity()
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
        /// 说明: 单位
        /// </summary>
        public System.String Company
        {
          get { return _Company; }
          set {
                _Company = value;
                CompanyChanged=true;
              }
        }

        /// <summary>
        /// 属性: _CompanyChanged
        /// </summary>
        public bool CompanyChanged
        {
          get { return _CompanyChanged;}
          set {
                _CompanyChanged=value;
              }
        }

        /// <summary>
        /// 属性: _CompanyCompareParam
        /// </summary>
        public CompareParam CompanyCompareParam
        {
          get { return _CompanyCompareParam ;}
          set {
                _CompanyCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _Company的数据库存储类型
        /// </summary>
        public string CompanyDbType
        {
          get { 
                return _CompanyDbType;
              }
        }
  
        /// <summary>
        /// 说明: 连续登录天数
        /// </summary>
        public System.Int32 ConLoginDates
        {
          get { return _ConLoginDates; }
          set {
                _ConLoginDates = value;
                ConLoginDatesChanged=true;
              }
        }

        /// <summary>
        /// 属性: _ConLoginDatesChanged
        /// </summary>
        public bool ConLoginDatesChanged
        {
          get { return _ConLoginDatesChanged;}
          set {
                _ConLoginDatesChanged=value;
              }
        }

        /// <summary>
        /// 属性: _ConLoginDatesCompareParam
        /// </summary>
        public CompareParam ConLoginDatesCompareParam
        {
          get { return _ConLoginDatesCompareParam ;}
          set {
                _ConLoginDatesCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _ConLoginDates的数据库存储类型
        /// </summary>
        public string ConLoginDatesDbType
        {
          get { 
                return _ConLoginDatesDbType;
              }
        }
  
        /// <summary>
        /// 说明: 创建时间
        /// </summary>
        public System.DateTime CreateDate
        {
          get { return _CreateDate; }
          set {
                _CreateDate = value;
                CreateDateChanged=true;
              }
        }

        /// <summary>
        /// 属性: _CreateDateChanged
        /// </summary>
        public bool CreateDateChanged
        {
          get { return _CreateDateChanged;}
          set {
                _CreateDateChanged=value;
              }
        }

        /// <summary>
        /// 属性: _CreateDateCompareParam
        /// </summary>
        public CompareParam CreateDateCompareParam
        {
          get { return _CreateDateCompareParam ;}
          set {
                _CreateDateCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _CreateDate的数据库存储类型
        /// </summary>
        public string CreateDateDbType
        {
          get { 
                return _CreateDateDbType;
              }
        }
  
        /// <summary>
        /// 说明: 邮箱
        /// </summary>
        public System.String Email
        {
          get { return _Email; }
          set {
                _Email = value;
                EmailChanged=true;
              }
        }

        /// <summary>
        /// 属性: _EmailChanged
        /// </summary>
        public bool EmailChanged
        {
          get { return _EmailChanged;}
          set {
                _EmailChanged=value;
              }
        }

        /// <summary>
        /// 属性: _EmailCompareParam
        /// </summary>
        public CompareParam EmailCompareParam
        {
          get { return _EmailCompareParam ;}
          set {
                _EmailCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _Email的数据库存储类型
        /// </summary>
        public string EmailDbType
        {
          get { 
                return _EmailDbType;
              }
        }
  
        /// <summary>
        /// 说明: 积分
        /// </summary>
        public System.Int32 Integral
        {
          get { return _Integral; }
          set {
                _Integral = value;
                IntegralChanged=true;
              }
        }

        /// <summary>
        /// 属性: _IntegralChanged
        /// </summary>
        public bool IntegralChanged
        {
          get { return _IntegralChanged;}
          set {
                _IntegralChanged=value;
              }
        }

        /// <summary>
        /// 属性: _IntegralCompareParam
        /// </summary>
        public CompareParam IntegralCompareParam
        {
          get { return _IntegralCompareParam ;}
          set {
                _IntegralCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _Integral的数据库存储类型
        /// </summary>
        public string IntegralDbType
        {
          get { 
                return _IntegralDbType;
              }
        }
  
        /// <summary>
        /// 说明: 是否验证邮箱
        /// </summary>
        public System.Boolean IsEmail
        {
          get { return _IsEmail; }
          set {
                _IsEmail = value;
                IsEmailChanged=true;
              }
        }

        /// <summary>
        /// 属性: _IsEmailChanged
        /// </summary>
        public bool IsEmailChanged
        {
          get { return _IsEmailChanged;}
          set {
                _IsEmailChanged=value;
              }
        }

        /// <summary>
        /// 属性: _IsEmailCompareParam
        /// </summary>
        public CompareParam IsEmailCompareParam
        {
          get { return _IsEmailCompareParam ;}
          set {
                _IsEmailCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _IsEmail的数据库存储类型
        /// </summary>
        public string IsEmailDbType
        {
          get { 
                return _IsEmailDbType;
              }
        }
  
        /// <summary>
        /// 说明: 是否有效
        /// </summary>
        public System.Boolean IsValid
        {
          get { return _IsValid; }
          set {
                _IsValid = value;
                IsValidChanged=true;
              }
        }

        /// <summary>
        /// 属性: _IsValidChanged
        /// </summary>
        public bool IsValidChanged
        {
          get { return _IsValidChanged;}
          set {
                _IsValidChanged=value;
              }
        }

        /// <summary>
        /// 属性: _IsValidCompareParam
        /// </summary>
        public CompareParam IsValidCompareParam
        {
          get { return _IsValidCompareParam ;}
          set {
                _IsValidCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _IsValid的数据库存储类型
        /// </summary>
        public string IsValidDbType
        {
          get { 
                return _IsValidDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.String JianJie
        {
          get { return _JianJie; }
          set {
                _JianJie = value;
                JianJieChanged=true;
              }
        }

        /// <summary>
        /// 属性: _JianJieChanged
        /// </summary>
        public bool JianJieChanged
        {
          get { return _JianJieChanged;}
          set {
                _JianJieChanged=value;
              }
        }

        /// <summary>
        /// 属性: _JianJieCompareParam
        /// </summary>
        public CompareParam JianJieCompareParam
        {
          get { return _JianJieCompareParam ;}
          set {
                _JianJieCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _JianJie的数据库存储类型
        /// </summary>
        public string JianJieDbType
        {
          get { 
                return _JianJieDbType;
              }
        }
  
        /// <summary>
        /// 说明: 登录时间
        /// </summary>
        public System.DateTime LoginDate
        {
          get { return _LoginDate; }
          set {
                _LoginDate = value;
                LoginDateChanged=true;
              }
        }

        /// <summary>
        /// 属性: _LoginDateChanged
        /// </summary>
        public bool LoginDateChanged
        {
          get { return _LoginDateChanged;}
          set {
                _LoginDateChanged=value;
              }
        }

        /// <summary>
        /// 属性: _LoginDateCompareParam
        /// </summary>
        public CompareParam LoginDateCompareParam
        {
          get { return _LoginDateCompareParam ;}
          set {
                _LoginDateCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _LoginDate的数据库存储类型
        /// </summary>
        public string LoginDateDbType
        {
          get { 
                return _LoginDateDbType;
              }
        }
  
        /// <summary>
        /// 说明: 登录天数
        /// </summary>
        public System.Int32 LoginDates
        {
          get { return _LoginDates; }
          set {
                _LoginDates = value;
                LoginDatesChanged=true;
              }
        }

        /// <summary>
        /// 属性: _LoginDatesChanged
        /// </summary>
        public bool LoginDatesChanged
        {
          get { return _LoginDatesChanged;}
          set {
                _LoginDatesChanged=value;
              }
        }

        /// <summary>
        /// 属性: _LoginDatesCompareParam
        /// </summary>
        public CompareParam LoginDatesCompareParam
        {
          get { return _LoginDatesCompareParam ;}
          set {
                _LoginDatesCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _LoginDates的数据库存储类型
        /// </summary>
        public string LoginDatesDbType
        {
          get { 
                return _LoginDatesDbType;
              }
        }
  
        /// <summary>
        /// 说明: MSN
        /// </summary>
        public System.String MSN
        {
          get { return _MSN; }
          set {
                _MSN = value;
                MSNChanged=true;
              }
        }

        /// <summary>
        /// 属性: _MSNChanged
        /// </summary>
        public bool MSNChanged
        {
          get { return _MSNChanged;}
          set {
                _MSNChanged=value;
              }
        }

        /// <summary>
        /// 属性: _MSNCompareParam
        /// </summary>
        public CompareParam MSNCompareParam
        {
          get { return _MSNCompareParam ;}
          set {
                _MSNCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _MSN的数据库存储类型
        /// </summary>
        public string MSNDbType
        {
          get { 
                return _MSNDbType;
              }
        }
  
        /// <summary>
        /// 说明: 开放ID
        /// </summary>
        public System.String OpenId
        {
          get { return _OpenId; }
          set {
                _OpenId = value;
                OpenIdChanged=true;
              }
        }

        /// <summary>
        /// 属性: _OpenIdChanged
        /// </summary>
        public bool OpenIdChanged
        {
          get { return _OpenIdChanged;}
          set {
                _OpenIdChanged=value;
              }
        }

        /// <summary>
        /// 属性: _OpenIdCompareParam
        /// </summary>
        public CompareParam OpenIdCompareParam
        {
          get { return _OpenIdCompareParam ;}
          set {
                _OpenIdCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _OpenId的数据库存储类型
        /// </summary>
        public string OpenIdDbType
        {
          get { 
                return _OpenIdDbType;
              }
        }
  
        /// <summary>
        /// 说明: 电话
        /// </summary>
        public System.String Phone
        {
          get { return _Phone; }
          set {
                _Phone = value;
                PhoneChanged=true;
              }
        }

        /// <summary>
        /// 属性: _PhoneChanged
        /// </summary>
        public bool PhoneChanged
        {
          get { return _PhoneChanged;}
          set {
                _PhoneChanged=value;
              }
        }

        /// <summary>
        /// 属性: _PhoneCompareParam
        /// </summary>
        public CompareParam PhoneCompareParam
        {
          get { return _PhoneCompareParam ;}
          set {
                _PhoneCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _Phone的数据库存储类型
        /// </summary>
        public string PhoneDbType
        {
          get { 
                return _PhoneDbType;
              }
        }
  
        /// <summary>
        /// 说明: QQ号码
        /// </summary>
        public System.String QQ
        {
          get { return _QQ; }
          set {
                _QQ = value;
                QQChanged=true;
              }
        }

        /// <summary>
        /// 属性: _QQChanged
        /// </summary>
        public bool QQChanged
        {
          get { return _QQChanged;}
          set {
                _QQChanged=value;
              }
        }

        /// <summary>
        /// 属性: _QQCompareParam
        /// </summary>
        public CompareParam QQCompareParam
        {
          get { return _QQCompareParam ;}
          set {
                _QQCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _QQ的数据库存储类型
        /// </summary>
        public string QQDbType
        {
          get { 
                return _QQDbType;
              }
        }
  
        /// <summary>
        /// 说明: 
        /// </summary>
        public System.String RoleCode
        {
          get { return _RoleCode; }
          set {
                _RoleCode = value;
                RoleCodeChanged=true;
              }
        }

        /// <summary>
        /// 属性: _RoleCodeChanged
        /// </summary>
        public bool RoleCodeChanged
        {
          get { return _RoleCodeChanged;}
          set {
                _RoleCodeChanged=value;
              }
        }

        /// <summary>
        /// 属性: _RoleCodeCompareParam
        /// </summary>
        public CompareParam RoleCodeCompareParam
        {
          get { return _RoleCodeCompareParam ;}
          set {
                _RoleCodeCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _RoleCode的数据库存储类型
        /// </summary>
        public string RoleCodeDbType
        {
          get { 
                return _RoleCodeDbType;
              }
        }
  
        /// <summary>
        /// 说明: 服务电话
        /// </summary>
        public System.String ServiceCall
        {
          get { return _ServiceCall; }
          set {
                _ServiceCall = value;
                ServiceCallChanged=true;
              }
        }

        /// <summary>
        /// 属性: _ServiceCallChanged
        /// </summary>
        public bool ServiceCallChanged
        {
          get { return _ServiceCallChanged;}
          set {
                _ServiceCallChanged=value;
              }
        }

        /// <summary>
        /// 属性: _ServiceCallCompareParam
        /// </summary>
        public CompareParam ServiceCallCompareParam
        {
          get { return _ServiceCallCompareParam ;}
          set {
                _ServiceCallCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _ServiceCall的数据库存储类型
        /// </summary>
        public string ServiceCallDbType
        {
          get { 
                return _ServiceCallDbType;
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
        /// 说明: 用户帐号
        /// </summary>
        public System.String UserAccount
        {
          get { return _UserAccount; }
          set {
                _UserAccount = value;
                UserAccountChanged=true;
              }
        }

        /// <summary>
        /// 属性: _UserAccountChanged
        /// </summary>
        public bool UserAccountChanged
        {
          get { return _UserAccountChanged;}
          set {
                _UserAccountChanged=value;
              }
        }

        /// <summary>
        /// 属性: _UserAccountCompareParam
        /// </summary>
        public CompareParam UserAccountCompareParam
        {
          get { return _UserAccountCompareParam ;}
          set {
                _UserAccountCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _UserAccount的数据库存储类型
        /// </summary>
        public string UserAccountDbType
        {
          get { 
                return _UserAccountDbType;
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
        /// 说明: 用户名
        /// </summary>
        public System.String UserName
        {
          get { return _UserName; }
          set {
                _UserName = value;
                UserNameChanged=true;
              }
        }

        /// <summary>
        /// 属性: _UserNameChanged
        /// </summary>
        public bool UserNameChanged
        {
          get { return _UserNameChanged;}
          set {
                _UserNameChanged=value;
              }
        }

        /// <summary>
        /// 属性: _UserNameCompareParam
        /// </summary>
        public CompareParam UserNameCompareParam
        {
          get { return _UserNameCompareParam ;}
          set {
                _UserNameCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _UserName的数据库存储类型
        /// </summary>
        public string UserNameDbType
        {
          get { 
                return _UserNameDbType;
              }
        }
  
        /// <summary>
        /// 说明: 用户密码
        /// </summary>
        public System.String UserPwd
        {
          get { return _UserPwd; }
          set {
                _UserPwd = value;
                UserPwdChanged=true;
              }
        }

        /// <summary>
        /// 属性: _UserPwdChanged
        /// </summary>
        public bool UserPwdChanged
        {
          get { return _UserPwdChanged;}
          set {
                _UserPwdChanged=value;
              }
        }

        /// <summary>
        /// 属性: _UserPwdCompareParam
        /// </summary>
        public CompareParam UserPwdCompareParam
        {
          get { return _UserPwdCompareParam ;}
          set {
                _UserPwdCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _UserPwd的数据库存储类型
        /// </summary>
        public string UserPwdDbType
        {
          get { 
                return _UserPwdDbType;
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
  