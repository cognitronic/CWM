using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using IdeaSeed.Core;
using CWM.Core.Domain;
using CWM.Core.Security;
using CWM.Core;
using CWM.Services;

namespace CWM.Web.Bases
{
    public class BaseMasterPage : System.Web.UI.MasterPage
    {

        protected override void OnLoad(EventArgs e)
        {
            if (SessionManager.Current != null)
            {
                BuildNav();
            }
            base.OnLoad(e);
        }

        public void BuildNav()
        { 
            var sb = new StringBuilder();
            var list = Cache[ResourceStrings.Cache_PrimaryPublicNavData] as IList<Page>;
            var resident = from l in list 
                           where l.NavigationTypeID == 1 
                           select l;

            var visitors = from l in list
                           where l.NavigationTypeID == 2
                           select l;

            var business = from l in list
                           where l.NavigationTypeID == 3
                           select l;

            var media = from l in list
                           where l.NavigationTypeID == 4
                           select l; 
            sb.Append("<ul id='mainNav'>");
            sb.Append("<li class='menu grid_2'><strong>Residents</strong><ul class='subMenu'>");
            foreach (var item in resident)
            {
                sb.Append("<li><a href='");
                sb.Append(SecurityContextManager.Current.BaseURL);
                sb.Append("/");
                sb.Append(item.Name.Replace(" ", "-").Trim());
                sb.Append("'>");
                sb.Append(item.DisplayName);
                sb.Append("</a></li>");
            }
            sb.Append("</ul></li>");
            sb.Append("<li class='menu grid_2'><strong>Visitors</strong><ul class='subMenu'>");
            foreach (var item in visitors)
            {
                sb.Append("<li><a href='");
                sb.Append(SecurityContextManager.Current.BaseURL);
                sb.Append("/");
                sb.Append(item.Name.Replace(" ", "-").Trim());
                sb.Append("'>");
                sb.Append(item.DisplayName);
                sb.Append("</a></li>");
            }
            sb.Append("</ul></li>");
            sb.Append("<li class='menu grid_2'><strong>Business</strong><ul class='subMenu'>");
            foreach (var item in business)
            {
                sb.Append("<li><a href='");
                sb.Append(SecurityContextManager.Current.BaseURL);
                sb.Append("/");
                sb.Append(item.Name.Replace(" ", "-").Trim());
                sb.Append("'>");
                sb.Append(item.DisplayName);
                sb.Append("</a></li>");
            }
            sb.Append("</ul></li>");
            sb.Append("<li class='menu grid_2'><strong>Media</strong><ul class='subMenu'>");
            foreach (var item in media)
            {
                sb.Append("<li><a href='");
                sb.Append(SecurityContextManager.Current.BaseURL);
                sb.Append("/");
                sb.Append(item.Name.Replace(" ", "-").Trim());
                sb.Append("'>");
                sb.Append(item.DisplayName);
                sb.Append("</a></li>");
            }
            sb.Append("</ul></li></ul>");

            MasterPageContext.PrimaryNavText = sb.ToString();
            //MasterPageContext.BannerImageData = Cache[ResourceStrings.Cache_BannerImagesData] as IList<BannerImage>;
        }
    }
}
