using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Configuration;
using System.Web.Compilation;
using System.Web.UI;
using System.Collections;
using CWM.Web.Utils;
using CWM.Services;
using CWM.Core.Domain;
using CWM.Core;
using CWM.Web.Bases;

namespace CWM.Web.Routing
{
    public class BlogSingleRouteHandler : IRouteHandler
    {
        public string VirtualPath { get; set; }

        public BlogSingleRouteHandler(string virtualPath)
        {
            this.VirtualPath = virtualPath;
        }

        #region IRouteHandler Members

        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            int blogType = (int)requestContext.RouteData.DataTokens["BlogType"];
            string title = HttpUtility.HtmlDecode((string)requestContext.RouteData.Values["title"]);

            HttpPageHelper.CurrentItem = null;
            HttpPageHelper.CurrentBlogPostType = 0;
            HttpPageHelper.CurrentBlog = null;

            var p = new CWM.Core.Domain.Page();
            p = new PageServices().GetByNameAccessLevel(VirtualPath, 0);
            HttpPageHelper.CurrentPage = p;

            var b = new BlogServices().GetByTypeTitle(blogType, title.Replace("-", " "));

            var item = new Item();
            item.Description = p.Name;
            item.Name = p.Name;
            item.SEOTitle = title.Replace("-", " ") + " - CWM Blog";
            item.ItemReference = item;
            HttpPageHelper.CurrentItem = item;
            HttpPageHelper.CurrentBlogPostType = (BlogPostType)blogType;
            HttpPageHelper.CurrentBlog = b;

            CWMBasePage page;

            page = (CWMBasePage)BuildManager.CreateInstanceFromVirtualPath(p.URLRoute, typeof(System.Web.UI.Page));

            HttpPageHelper.IsValidRequest = true;
            return page;
        }

        #endregion
    }
}
