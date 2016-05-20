
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
      /// 数据库表DiscDeveloper所对应的实体类
      /// </summary>
    public partial class DiscDeveloperEntity:IEntity
    {
        #region 主键字段数组，存储主键字段列名。
      private string[] _PrimaryKeys = {"DeveloperId"};
      #endregion

          #region 成员变量:_DeveloperAddress
          private System.String _DeveloperAddress;
          private bool _DeveloperAddressChanged = false;
          CompareParam _DeveloperAddressCompareParam = CompareParam.Equal;
          public string _DeveloperAddressDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_DeveloperId
          private System.Int32 _DeveloperId;
          private bool _DeveloperIdChanged = false;
          CompareParam _DeveloperIdCompareParam = CompareParam.Equal;
          public string _DeveloperIdDbType = "int";
          #endregion
  
          #region 成员变量:_DeveloperName
          private System.String _DeveloperName;
          private bool _DeveloperNameChanged = false;
          CompareParam _DeveloperNameCompareParam = CompareParam.Equal;
          public string _DeveloperNameDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_DeveloperPhone
          private System.String _DeveloperPhone;
          private bool _DeveloperPhoneChanged = false;
          CompareParam _DeveloperPhoneCompareParam = CompareParam.Equal;
          public string _DeveloperPhoneDbType = "nvarchar";
          #endregion
  
          #region 成员变量:_DistrictId
          private System.Int32 _DistrictId;
          private bool _DistrictIdChanged = false;
          CompareParam _DistrictIdCompareParam = CompareParam.Equal;
          public string _DistrictIdDbType = "int";
          #endregion
  
          /// <summary>
          /// 构造函数
          /// </summary>
          public DiscDeveloperEntity()
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
        /// 说明: 建筑公司地址
        /// </summary>
        public System.String DeveloperAddress
        {
          get { return _DeveloperAddress; }
          set {
                _DeveloperAddress = value;
                DeveloperAddressChanged=true;
              }
        }

        /// <summary>
        /// 属性: _DeveloperAddressChanged
        /// </summary>
        public bool DeveloperAddressChanged
        {
          get { return _DeveloperAddressChanged;}
          set {
                _DeveloperAddressChanged=value;
              }
        }

        /// <summary>
        /// 属性: _DeveloperAddressCompareParam
        /// </summary>
        public CompareParam DeveloperAddressCompareParam
        {
          get { return _DeveloperAddressCompareParam ;}
          set {
                _DeveloperAddressCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _DeveloperAddress的数据库存储类型
        /// </summary>
        public string DeveloperAddressDbType
        {
          get { 
                return _DeveloperAddressDbType;
              }
        }
  
        /// <summary>
        /// 说明: 建筑公司Id
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
        /// 说明: 建筑公司名称
        /// </summary>
        public System.String DeveloperName
        {
          get { return _DeveloperName; }
          set {
                _DeveloperName = value;
                DeveloperNameChanged=true;
              }
        }

        /// <summary>
        /// 属性: _DeveloperNameChanged
        /// </summary>
        public bool DeveloperNameChanged
        {
          get { return _DeveloperNameChanged;}
          set {
                _DeveloperNameChanged=value;
              }
        }

        /// <summary>
        /// 属性: _DeveloperNameCompareParam
        /// </summary>
        public CompareParam DeveloperNameCompareParam
        {
          get { return _DeveloperNameCompareParam ;}
          set {
                _DeveloperNameCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _DeveloperName的数据库存储类型
        /// </summary>
        public string DeveloperNameDbType
        {
          get { 
                return _DeveloperNameDbType;
              }
        }
  
        /// <summary>
        /// 说明: 建筑公司电话
        /// </summary>
        public System.String DeveloperPhone
        {
          get { return _DeveloperPhone; }
          set {
                _DeveloperPhone = value;
                DeveloperPhoneChanged=true;
              }
        }

        /// <summary>
        /// 属性: _DeveloperPhoneChanged
        /// </summary>
        public bool DeveloperPhoneChanged
        {
          get { return _DeveloperPhoneChanged;}
          set {
                _DeveloperPhoneChanged=value;
              }
        }

        /// <summary>
        /// 属性: _DeveloperPhoneCompareParam
        /// </summary>
        public CompareParam DeveloperPhoneCompareParam
        {
          get { return _DeveloperPhoneCompareParam ;}
          set {
                _DeveloperPhoneCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _DeveloperPhone的数据库存储类型
        /// </summary>
        public string DeveloperPhoneDbType
        {
          get { 
                return _DeveloperPhoneDbType;
              }
        }
  
        /// <summary>
        /// 说明: 建筑公司所在区Id(三)
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
  