
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
      /// 数据库表DiscPaymentMethod所对应的实体类
      /// </summary>
    public partial class DiscPaymentMethodEntity:IEntity
    {
        #region 主键字段数组，存储主键字段列名。
      private string[] _PrimaryKeys = {"PaymentMethodId"};
      #endregion

          #region 成员变量:_PaymentMethodId
          private System.Int32 _PaymentMethodId;
          private bool _PaymentMethodIdChanged = false;
          CompareParam _PaymentMethodIdCompareParam = CompareParam.Equal;
          public string _PaymentMethodIdDbType = "int";
          #endregion
  
          #region 成员变量:_PaymentMethodName
          private System.String _PaymentMethodName;
          private bool _PaymentMethodNameChanged = false;
          CompareParam _PaymentMethodNameCompareParam = CompareParam.Equal;
          public string _PaymentMethodNameDbType = "nvarchar";
          #endregion
  
          /// <summary>
          /// 构造函数
          /// </summary>
          public DiscPaymentMethodEntity()
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
        /// 说明: 
        /// </summary>
        public System.String PaymentMethodName
        {
          get { return _PaymentMethodName; }
          set {
                _PaymentMethodName = value;
                PaymentMethodNameChanged=true;
              }
        }

        /// <summary>
        /// 属性: _PaymentMethodNameChanged
        /// </summary>
        public bool PaymentMethodNameChanged
        {
          get { return _PaymentMethodNameChanged;}
          set {
                _PaymentMethodNameChanged=value;
              }
        }

        /// <summary>
        /// 属性: _PaymentMethodNameCompareParam
        /// </summary>
        public CompareParam PaymentMethodNameCompareParam
        {
          get { return _PaymentMethodNameCompareParam ;}
          set {
                _PaymentMethodNameCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _PaymentMethodName的数据库存储类型
        /// </summary>
        public string PaymentMethodNameDbType
        {
          get { 
                return _PaymentMethodNameDbType;
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
  