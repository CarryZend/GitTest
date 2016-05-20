
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
      /// 数据库表DiscCBD所对应的实体类
      /// </summary>
    public partial class DiscCBDEntity:IEntity
    {
        #region 主键字段数组，存储主键字段列名。
      private string[] _PrimaryKeys = {"CBDId"};
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
  
          #region 成员变量:_DistrictId
          private System.Int32 _DistrictId;
          private bool _DistrictIdChanged = false;
          CompareParam _DistrictIdCompareParam = CompareParam.Equal;
          public string _DistrictIdDbType = "int";
          #endregion
  
          /// <summary>
          /// 构造函数
          /// </summary>
          public DiscCBDEntity()
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
        /// 说明: 中央商务区地址
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
        /// 说明: 中央商务区Id
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
        /// 说明: 中央商务区名称
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
        /// 说明: 地区Id
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
  