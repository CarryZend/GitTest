
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
      /// 数据库表DiscOfficeGrade所对应的实体类
      /// </summary>
    public partial class DiscOfficeGradeEntity:IEntity
    {
        #region 主键字段数组，存储主键字段列名。
      private string[] _PrimaryKeys = {"OfficeGradeId"};
      #endregion

          #region 成员变量:_OfficeGradeId
          private System.Int32 _OfficeGradeId;
          private bool _OfficeGradeIdChanged = false;
          CompareParam _OfficeGradeIdCompareParam = CompareParam.Equal;
          public string _OfficeGradeIdDbType = "int";
          #endregion
  
          #region 成员变量:_OfficeGradeName
          private System.String _OfficeGradeName;
          private bool _OfficeGradeNameChanged = false;
          CompareParam _OfficeGradeNameCompareParam = CompareParam.Equal;
          public string _OfficeGradeNameDbType = "nvarchar";
          #endregion
  
          /// <summary>
          /// 构造函数
          /// </summary>
          public DiscOfficeGradeEntity()
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
        /// 说明: 写字楼等级Id
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
        /// 说明: 写字楼等级名称
        /// </summary>
        public System.String OfficeGradeName
        {
          get { return _OfficeGradeName; }
          set {
                _OfficeGradeName = value;
                OfficeGradeNameChanged=true;
              }
        }

        /// <summary>
        /// 属性: _OfficeGradeNameChanged
        /// </summary>
        public bool OfficeGradeNameChanged
        {
          get { return _OfficeGradeNameChanged;}
          set {
                _OfficeGradeNameChanged=value;
              }
        }

        /// <summary>
        /// 属性: _OfficeGradeNameCompareParam
        /// </summary>
        public CompareParam OfficeGradeNameCompareParam
        {
          get { return _OfficeGradeNameCompareParam ;}
          set {
                _OfficeGradeNameCompareParam = value;
              }
        }

        /// <summary>
        /// 属性: _OfficeGradeName的数据库存储类型
        /// </summary>
        public string OfficeGradeNameDbType
        {
          get { 
                return _OfficeGradeNameDbType;
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
  