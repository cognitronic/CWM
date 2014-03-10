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
    public partial class Users : CWMAdminBasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadUsers(true);
            }
        }

        protected void NeedDataSource(object o, GridNeedDataSourceEventArgs e)
        {
            LoadUsers(false);
        }



        protected void ItemCommand(object o, GridCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case RadGrid.InitInsertCommandName:
                    Response.Redirect("/User.aspx");

                    break;
                case RadGrid.EditCommandName:
                    Response.Redirect("/User.aspx?id=" + e.Item.OwnerTableView.DataKeyValues[e.Item.ItemIndex]["ID"].ToString());
                    break;
                case RadGrid.DeleteCommandName:
                    var img = new UserServices().GetByID(Convert.ToInt32(e.Item.OwnerTableView.DataKeyValues[e.Item.ItemIndex]["ID"].ToString()));
                    new UserServices().Delete(img);
                    //LoadLinks(true);
                    break;
            }
        }

        private void LoadUsers(bool bindData)
        {
            var u = new UserServices().GetAll();
            rgUser.DataSource = u;
            if (bindData)
                rgUser.DataBind();
        }
    }
}