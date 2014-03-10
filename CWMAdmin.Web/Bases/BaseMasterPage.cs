using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using CWM.Services;
using CWM.Core.Domain;
using CWM.Core.Security;
using IdeaSeed.Core;
using CWM.Core;
using CWMAdmin.Web.Utils;

namespace CWMAdmin.Web.Bases
{
    public class BaseMasterPage : System.Web.UI.MasterPage
    {
        protected override void OnLoad(EventArgs e)
        {
            if (SessionManager.Current != null)
            {
                //BuildNav();
                //HttpPageHelper.CurrentWebsite = (Website)SecurityContextManager.Current.CurrentWebsite;
            }
            base.OnLoad(e);
        }

        public void BuildNav()
        {
            //var sb = new StringBuilder();
            //var list = (Cache[ResourceStrings.Cache_PrimaryNavData] as IList<Page>).OrderBy(o => o.LoadOrder);
            //sb.Append("<ul id='menu_group_main' class='group'>");
            //foreach (var page in list)
            //{
            //    if (page.ID == list.ElementAt(0).ID)
            //    {
            //        sb.Append("<li class='item first' id=''>");
            //    }
            //    else if(page.ID == list.ElementAt((list.Count() - 1)).ID)
            //    {
            //        sb.Append("<li class='item last' id=''>");
            //    }
            //    else
            //    {
            //        sb.Append("<li class='item middle' id=''>");
            //    }
            //    string[] routes = page.URLRoute.ToLower().Split('/');
            //    if (routes[0] == HttpContext.Current.Request.Url.Segments[1].Replace("/", "").ToLower())
            //    {
            //        sb.Append("<a href='");
            //        sb.Append(Request.Url.GetLeftPart(UriPartial.Authority));
            //        sb.Append("/");
            //        sb.Append(page.URLRoute);
            //        if (page.ChildPages.Count > 0)
            //        {
            //            sb.Append("/");
            //            sb.Append(page.ChildPages[0].Name);
            //        }
            //        sb.Append("' alt='");
            //        sb.Append(page.Name);
            //        sb.Append("' class='main current'>");
            //        sb.Append("<span class='outer'>");
            //        sb.Append("<span class='inner ");
            //        sb.Append(page.Name.ToLower());
            //        sb.Append("'>");
            //        sb.Append(page.Name);
            //        sb.Append("</span></span></a></li>");
            //    }
            //    else
            //    {
            //        sb.Append("<a href='");
            //        sb.Append(Request.Url.GetLeftPart(UriPartial.Authority));
            //        sb.Append("/");
            //        sb.Append(page.URLRoute);
            //        if (page.ChildPages.Count > 0)
            //        {
            //            sb.Append("/");
            //            sb.Append(page.ChildPages[0].Name);
            //        }
            //        sb.Append("' alt='");
            //        sb.Append(page.Name);
            //        sb.Append("' class='main'>");
            //        sb.Append("<span class='outer'>");
            //        sb.Append("<span class='inner ");
            //        sb.Append(page.Name.ToLower());
            //        sb.Append("'>");
            //        sb.Append(page.Name);
            //        sb.Append("</span></span></a></li>");
            //    }
            //}
            //sb.Append("</ul>");

            //MasterPageContext.PrimaryNavText = sb.ToString();
            //BuildSubNav((int)SecurityContextManager.Current.CurrentPage.ParentID);
        }

        public void BuildSubNav(int parentID)
        {
            //var list = new PageServices().GetSubPagesByParentID(parentID).OrderBy(o => o.LoadOrder);
            //if (list != null)
            //{
            //    var sb = new StringBuilder();
            //    sb.Append("<div id='tabs'><div class='container'><ul>");
            //    foreach (var page in list)
            //    {
            //        string[] routes = page.URLRoute.ToLower().Split('/');
            //        if (routes[routes.Length - 1] == HttpContext.Current.Request.Url.Segments[HttpContext.Current.Request.Url.Segments.Length - 1].Replace("/", "").ToLower() || routes[routes.Length - 1] == "page")
            //        {
            //            sb.Append("<li>");
            //            sb.Append("<a href='");
            //            sb.Append(Request.Url.GetLeftPart(UriPartial.Authority));
            //            sb.Append("/");
            //            sb.Append(page.URLRoute);
            //            sb.Append("' alt='");
            //            sb.Append(page.Name);
            //            sb.Append("' class='current'><span>");
            //            sb.Append(page.Name);
            //            sb.Append("</span></a>");
            //            sb.Append("</li>");
            //        }
            //        else
            //        {
            //            sb.Append("<li>");
            //            sb.Append("<a href='");
            //            sb.Append(Request.Url.GetLeftPart(UriPartial.Authority));
            //            sb.Append("/");
            //            sb.Append(page.URLRoute);
            //            sb.Append("' alt='");
            //            sb.Append(page.Name);
            //            sb.Append("'><span>");
            //            sb.Append(page.Name);
            //            sb.Append("</span></a>");
            //            sb.Append("</li>");
            //        }
            //    }
            //    sb.Append("</ul></div></div>");
            //    MasterPageContext.SubNavText = sb.ToString();
            //}
        }
    }
}
