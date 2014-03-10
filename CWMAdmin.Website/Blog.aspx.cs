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
using CWMAdmin.Web.Utils;
using CWM.Core.Security;

namespace CWMAdmin.Website
{
    public partial class Blog : CWMAdminBasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadBlog(true);
            }
        }


        protected void NeedDataSource(object o, GridNeedDataSourceEventArgs e)
        {
            LoadBlog(false);
        }



        protected void ItemCommand(object o, GridCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case RadGrid.InitInsertCommandName:
                    Response.Redirect("/BlogPost.aspx");

                    break;
                case RadGrid.EditCommandName:
                    Response.Redirect("/BlogPost.aspx?id=" + e.Item.OwnerTableView.DataKeyValues[e.Item.ItemIndex]["ID"].ToString());
                    break;
                case RadGrid.DeleteCommandName:
                    var img = new BlogServices().GetByID(Convert.ToInt32(e.Item.OwnerTableView.DataKeyValues[e.Item.ItemIndex]["ID"].ToString()));
                    new BlogServices().Delete(img);
                    //LoadLinks(true);
                    break;
            }
        }

        private void LoadBlog(bool binddata)
        {
            switch (((CWM.Core.Domain.User)SecurityContextManager.Current.CurrentUser).AccessLevel)
            { 
                case 60:
                    var list = new BlogServices().GetAll();
                    rgBlog.DataSource = list;
                    if (binddata)
                        rgBlog.DataBind();
                    break;
                case 50:
                    list = new BlogServices().GetByPostType((int)BlogPostType.ARTS);
                    rgBlog.DataSource = list;
                    if (binddata)
                        rgBlog.DataBind();
                    break;
                case 40:
                    list = new BlogServices().GetByPostType((int)BlogPostType.BUSINESS);
                    rgBlog.DataSource = list;
                    if (binddata)
                        rgBlog.DataBind();
                    break;
                case 30:
                    list = new BlogServices().GetByPostType((int)BlogPostType.CITY);
                    rgBlog.DataSource = list;
                    if (binddata)
                        rgBlog.DataBind();
                    break;
            }
        }
    }
}