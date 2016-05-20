using Eagle.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI;

namespace Eagle.Manage
{
    /// <summary>
    /// AdminPage 的摘要说明。
    /// 后台管理页面基类
    /// </summary>
    public class AdminPage : Page
    {
        private string _UserName;
        /// <summary>
        /// 用户称呼
        /// </summary>
        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }

        private string _UserAccount;
        /// <summary>
        /// 用户帐号
        /// </summary>
        public string UserAccount
        {
            get { return _UserAccount; }
            set { _UserAccount = value; }
        }

        private int _UserId;
        /// <summary>
        /// 用户Id
        /// </summary>
        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }

        public AdminPage()
        {
            //if (Request.Cookies["User"] == null)
            //{
            //    Response.Redirect("/officeadmin/syslogin.aspx");
            //    return;
            //}
            //else
            //{
            //    UserId = int.Parse(Request.Cookies["User"].Values["UserId"]);
            //    UserName = Request.Cookies["User"].Values["UserName"];
            //    UserAccount = Request.Cookies["User"].Values["UserAccount"];
            //}
        }
    
        protected override void OnLoad(EventArgs e)
        {
            

        }
    }
}
