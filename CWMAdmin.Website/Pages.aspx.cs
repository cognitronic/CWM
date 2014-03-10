using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using IdeaSeed.Core;
using CWM.Services;
using CWM.Core.Domain;
using System.Web.UI.WebControls;
using Telerik.Web.UI;
using CWMAdmin.Web.Bases;

namespace CWMAdmin.Website
{
    public partial class Pages : CWMAdminBasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadPages(true);
            }
        }

        protected void EditPageClicked(object o, EventArgs e)
        {
            Response.Redirect("/Page.aspx?id=" + ((LinkButton)o).Attributes["pageid"]);
        }

        protected void NeedDataSource(object o, GridNeedDataSourceEventArgs e)
        {
            LoadPages(false);
        }

        private void LoadPages(bool bindData)
        {
            var pages = new PageServices().GetByManageable(true);
            rgPages.DataSource = pages;
            if (bindData)
                rgPages.DataBind();
        }
    }
}