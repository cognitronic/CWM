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
    public class DefaultRouteHandler : IRouteHandler
    {
        public string VirtualPath { get; set; }

        public DefaultRouteHandler(string virtualPath)
        {
            this.VirtualPath = virtualPath;
        }

        #region IRouteHandler Members

        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            HttpPageHelper.CurrentItem = null;
            var p = new CWM.Core.Domain.Page();
            if(HttpPageHelper.CurrentUser == null)
                p = new PageServices().GetByNameAccessLevel(VirtualPath, 0);
            else
                p = new PageServices().GetByNameAccessLevel(VirtualPath, HttpPageHelper.CurrentUser.AccessLevel);
            HttpPageHelper.CurrentPage = p;

            var item = new Item();
            item.Description = p.Name;
            item.Name = p.Name;
            item.SEOTitle = p.SEOTitle;
            item.ItemReference = item;
            HttpPageHelper.CurrentItem = item;

            CWMBasePage page;

            page = (CWMBasePage)BuildManager.CreateInstanceFromVirtualPath(p.URLRoute, typeof(System.Web.UI.Page));

            HttpPageHelper.IsValidRequest = true;
            return page;
        }

        #endregion
    }
}
