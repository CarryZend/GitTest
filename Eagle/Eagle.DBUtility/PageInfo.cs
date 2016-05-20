/// <summary>
/// 名  称：分页相关类
/// 说  明：按照.net 2.0的写法。可降低版本。。
/// 日  期：2015年09月02日
/// 作  者：张桂华
/// 邮  箱：zhangguihua1414@163.com  
/// </summary>
using System.Text;

namespace Eagle.DBUtility
{
    /// <summary>
    /// 名  称：分页相关类
    /// 说  明：按照.net 2.0的写法。可降低版本。
    /// </summary>
    public class PageInfo
    {
        //每页数据条目数量
        int _PageSize = 12;
        //总记录数
        int _TotalRecords = 0;
        //总页数
        int _TotalPages = 0;
        //当前页码
        int _CurrentPage = 1;

        /// <summary>
        /// 页大小
        /// </summary>
        public int PageSize
        {
            get
            {
                return _PageSize;
            }
            set
            {
                _PageSize = value;
            }
        }

        /// <summary>
        /// 总记录数
        /// </summary>
        public int TotalRecords
        {
            get
            {
                return _TotalRecords;
            }
            set
            {
                _TotalRecords = value;
            }
        }

        /// <summary>
        /// 总页数
        /// </summary>
        public int TotalPages
        {
            get
            {
                return _TotalPages;
            }
            set
            {
                _TotalPages = value;
            }
        }

        /// <summary>
        /// 当前页码
        /// </summary>
        public int CurrentPage
        {
            get
            {
                return _CurrentPage;
            }
            set
            {
                _CurrentPage = value;
            }
        }

        /// <summary>
        /// 每次获取分页数据后，根据总数据记录数得到页数等
        /// </summary>
        public void CalculatePages()
        {
            int lastPageRecords = TotalRecords % PageSize;
            _TotalPages = TotalRecords / PageSize;
            if (lastPageRecords != 0)
            {
                _TotalPages += 1;
            }
        }

        /// <summary>
        /// 再次访问时生成页码html
        /// </summary>
        public string ReGeneratePageItems(string currentPageId)
        {
            StringBuilder GeneratePageOrder = new StringBuilder();
            if (_CurrentPage == 1)
            {
                GeneratePageOrder.AppendFormat("<li value=\"pre\" class=\"paginItem\" onclick=\"PrePage('" + currentPageId + "')\"><a href=\"#\"><span class=\"pagepre\"></span></a></li>");
            }
            else
            {
                GeneratePageOrder.AppendFormat("<li value=\"pre\" class=\"paginItem\" onclick=\"PrePage('" + currentPageId + "')\"><a href=\"#\"><span class=\"pagepre1\"></span></a></li>");
            }
            if (_CurrentPage == 1)
            {
                GeneratePageOrder.AppendFormat("<li value=\"0\" class=\"paginItem current\" onclick=\"GotoPage('" + currentPageId + "'," + (_CurrentPage).ToString() + ")\"><a href=\"#\">" + (_CurrentPage).ToString() + "</a></li>");
                if (_TotalPages > 1)
                {
                    GeneratePageOrder.AppendFormat("<li value=\"0\" class=\"paginItem\" onclick=\"GotoPage('" + currentPageId + "'," + (_CurrentPage + 1).ToString() + ")\"><a href=\"#\">" + (_CurrentPage + 1).ToString() + "</a></li>");
                }
            }
            else if (_CurrentPage > 1 && _CurrentPage < 6)
            {
                for (int i = 1; i <= _CurrentPage + 1; i++)
                {
                    if (i > _TotalPages)
                    {
                        continue;
                    }
                    if (i == _CurrentPage)
                    {
                        GeneratePageOrder.AppendFormat("<li value=\"0\" class=\"paginItem current\" onclick=\"GotoPage('" + currentPageId + "'," + (i).ToString() + ")\"><a href=\"#\">" + (i).ToString() + "</a></li>");
                    }
                    else
                    {
                        GeneratePageOrder.AppendFormat("<li value=\"0\" class=\"paginItem\" onclick=\"GotoPage('" + currentPageId + "'," + (i).ToString() + ")\"><a href=\"#\">" + (i).ToString() + "</a></li>");
                    }
                }
            }
            else if (_CurrentPage >= 6)
            {
                GeneratePageOrder.AppendFormat("<li value=\"0\" class=\"paginItem\" onclick=\"GotoPage('" + currentPageId + "',1)\"><a href=\"#\">" + 1 + "</a></li>");
                GeneratePageOrder.AppendFormat("<li value=\"0\" class=\"paginItem\" onclick=\"GotoPage('" + currentPageId + "',2)\"><a href=\"#\">" + 2 + "</a></li>");
                GeneratePageOrder.AppendFormat("<li value=\"0\" class=\"paginItem\"><a href=\"#\">" + "..." + "</a></li>");
                for (int i = _CurrentPage - 2; i <= _CurrentPage + 1; i++)
                {
                    if (i > _TotalPages)
                    {
                        continue;
                    }
                    if (i == _CurrentPage)
                    {
                        GeneratePageOrder.AppendFormat("<li value=\"0\" class=\"paginItem current\" onclick=\"GotoPage('" + currentPageId + "'," + (i).ToString() + ")\"><a href=\"#\">" + (i).ToString() + "</a></li>");
                    }
                    else
                    {
                        GeneratePageOrder.AppendFormat("<li value=\"0\" class=\"paginItem\" onclick=\"GotoPage('" + currentPageId + "'," + (i).ToString() + ")\"><a href=\"#\">" + (i).ToString() + "</a></li>");
                    }
                }
            }
            if (_CurrentPage < _TotalPages && _TotalPages > 2 && _CurrentPage + 1 < _TotalPages)
            {
                GeneratePageOrder.AppendFormat("<li value=\"0\" class=\"paginItem\"><a href=\"#\">" + "..." + "</a></li>");
            }
            if (_CurrentPage == _TotalPages)
            {
                GeneratePageOrder.AppendFormat("<li value=\"next\" class=\"paginItem\" onclick=\"NextPage('" + currentPageId + "')\"><a href=\"#\"><span class=\"pagenxt1\"></span></a></li>");
            }
            else
            {
                GeneratePageOrder.AppendFormat("<li value=\"next\" class=\"paginItem\" onclick=\"NextPage('" + currentPageId + "')\"><a href=\"#\"><span class=\"pagenxt\"></span></a></li>");
            }
            return GeneratePageOrder.ToString();
        }

        /// <summary>
        /// 首次访问时生成页码html
        /// </summary>
        public string GeneratePageList(string currentPageId)
        {
            //限制只显示最多6个页码比如，12...6789 参考淘宝
            StringBuilder GeneratePageOrder = new StringBuilder();
            GeneratePageOrder.AppendFormat("<li value=\"pre\" class=\"paginItem\" onclick=\"PrePage('" + currentPageId + "')\"><a href=\"#\"><span class=\"pagepre\"  id=\"pagepre1\"></span></a></li>");
            GeneratePageOrder.AppendFormat("<li value=\"0\" class=\"paginItem current\" onclick=\"GotoPage('" + currentPageId + "',1)\"><a href=\"#\">" + 1 + "</a></li>");
            if (_TotalPages > 1)
            {
                GeneratePageOrder.AppendFormat("<li value=\"0\" class=\"paginItem\" onclick=\"GotoPage('" + currentPageId + "',2)\"><a href=\"#\">" + 2 + "</a></li>");
            }
            if (_TotalPages > 2)
            {
                GeneratePageOrder.AppendFormat("<li value=\"0\" class=\"paginItem\" ><a href=\"#\">" + "..." + "</a></li>");
            }
            GeneratePageOrder.AppendFormat("<li value=\"next\" class=\"paginItem\" onclick=\"NextPage('" + currentPageId + "')\"><a href=\"#\"><span class=\"pagenxt\"  id=\"pagenxt1\"></span></a></li>");
            return GeneratePageOrder.ToString();
        }
    }
}
