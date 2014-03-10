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
using CWM.Core.Security;
using CWMAdmin.Web.Utils;

namespace CWMAdmin.Website
{
    public partial class BlogPost : CWMAdminBasePage
    {

        private CWM.Core.Domain.Blog SelectedBlog
        {
            get
            {
                if (!string.IsNullOrEmpty(Request.QueryString["id"]))
                { 
                    var p = new BlogServices().GetByID(Convert.ToInt32(Request.QueryString["id"]));
                    if (p != null && p.ID > 0)
                    {
                        return p;
                    }
                    return null;
                }
                return null;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadPost();
            }
        }

        protected void SavePageClicked(object o, EventArgs e)
        {
            SavePost();
            Response.Redirect("/Blog.aspx");
        }

        protected void CancelClicked(object o, EventArgs e)
        {
            Response.Redirect(Request.Url.PathAndQuery);
        }

        protected void LoadPost()
        {
            if (SelectedBlog != null)
            {
                tbEndDate.SelectedDate = SelectedBlog.EndDate;
                tbStartDate.SelectedDate = SelectedBlog.StartDate;
                tbPageContent.Text = SelectedBlog.BlogContent;
                tbSeoDescription.Text = SelectedBlog.SEODescription;
                tbSeoKeywords.Text = SelectedBlog.SEOKeywords;
                tbTitle.Text = SelectedBlog.Title;
            }
            else
            {
                if (((CWM.Core.Domain.User)SecurityContextManager.Current.CurrentUser).AccessLevel < 60)
                {
                    divPostType.Visible = false;
                }
                else
                {
                    divPostType.Visible = true;
                }
            }
        }

        private void SavePost()
        {
            var p = new CWM.Core.Domain.Blog();
            if (SelectedBlog != null)
            {
                p = SelectedBlog;
            }
            else
            {
                p.EnteredBy = SecurityContextManager.Current.CurrentUser.ID;
            }
            p.BlogContent = tbPageContent.Text;
            p.EndDate = (DateTime)tbEndDate.SelectedDate;
            switch (((CWM.Core.Domain.User)SecurityContextManager.Current.CurrentUser).AccessLevel)
            {
                case 60:
                    p.PostType = Convert.ToInt16(ddlPostType.SelectedValue);
                    break;
                case 50:
                    p.PostType = (int)BlogPostType.ARTS;
                    break;
                case 40:
                    p.PostType = (int)BlogPostType.BUSINESS;
                    break;
                case 30:
                    p.PostType = (int)BlogPostType.CITY;
                    break;
            }
            p.SEODescription = tbSeoDescription.Text;
            p.SEOKeywords = tbSeoKeywords.Text;
            p.StartDate = (DateTime)tbStartDate.SelectedDate;
            p.Title = tbTitle.Text;
            new BlogServices().Save(p);
        }
    }
}