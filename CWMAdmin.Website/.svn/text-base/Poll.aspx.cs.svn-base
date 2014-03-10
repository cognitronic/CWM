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
    public partial class Poll : CWMAdminBasePage
    {
        private CWM.Core.Domain.Poll SelectedPoll
        {
            get
            {
                if (!string.IsNullOrEmpty(Request.QueryString["id"]))
                {
                    var p = new PollServices().GetByID(Convert.ToInt32(Request.QueryString["id"]));
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
                LoadPoll();
                LoadOptions(true);
            }
        }

        protected void SavePageClicked(object o, EventArgs e)
        {
            SavePoll();

            
        }

        protected void CancelClicked(object o, EventArgs e)
        {
            Response.Redirect(Request.Url.PathAndQuery);
        }

        protected void LoadPoll()
        {
            if (SelectedPoll != null)
            {
                tbEndDate.SelectedDate = SelectedPoll.EndDate;
                tbStartDate.SelectedDate = SelectedPoll.StartDate;
                tbQuestion.Text = SelectedPoll.Question;
                cbIsActive.Checked = SelectedPoll.IsActive;
            }
        }

        private void SavePoll()
        {
            var p = new CWM.Core.Domain.Poll();
            if (SelectedPoll != null)
            {
                p = SelectedPoll;
            }
            p.IsActive = cbIsActive.Checked;
            p.EndDate = (DateTime)tbEndDate.SelectedDate;
            p.StartDate = (DateTime)tbStartDate.SelectedDate;
            p.Question = tbQuestion.Text;
            p.Name = tbQuestion.Text;
            new PollServices().Save(p);

            if (SelectedPoll != null)
            {
                Response.Redirect("/Polls.aspx");
            }
            else
            {
                Response.Redirect("/Poll.aspx?id=" + p.ID.ToString());
            }
        }

        protected void NeedDataSource(object o, GridNeedDataSourceEventArgs e)
        {
            LoadOptions(false);
        }

        private void LoadOptions(bool bindData)
        {
            if (SelectedPoll != null)
            {
                rgOptions.DataSource = new PollOptionServices().GetByPollID(SelectedPoll.ID);
                if (bindData)
                    rgOptions.DataBind();
            }
        }

        protected void ItemCommand(object o, GridCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case RadGrid.EditCommandName:
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "SetEditMode", "isEditMode = true;", true);
                    break;
                case RadGrid.InitInsertCommandName:
                    e.Canceled = true;
                    var i = new PollOption();
                    i.Name = "";
                    i.PollID = 0;
                    i.ID = 0;
                    e.Item.OwnerTableView.InsertItem(new PollOption());
                    break;
                case RadGrid.UpdateCommandName:
                    var img = new PollOptionServices().GetByID(Convert.ToInt32(e.Item.OwnerTableView.DataKeyValues[e.Item.ItemIndex]["ID"].ToString()));
                    GridEditFormItem insertItem = e.Item as GridEditFormItem;
                    string imageName = (insertItem["Name"].FindControl("tbName") as RadTextBox).Text;
                    img.Name = imageName;
                    new PollOptionServices().Save(img);

                    break;
                case RadGrid.PerformInsertCommandName:
                    insertItem = e.Item as GridEditFormInsertItem;
                    imageName = (insertItem["Name"].FindControl("tbName") as RadTextBox).Text;
                    img = new PollOption();
                    img.Name = imageName;
                    img.PollID = SelectedPoll.ID;
                    new PollOptionServices().Save(img);

                    //LoadLinks(true);

                    break;
                case RadGrid.DeleteCommandName:
                    img = new PollOptionServices().GetByID(Convert.ToInt32(e.Item.OwnerTableView.DataKeyValues[e.Item.ItemIndex]["ID"].ToString()));
                    new PollOptionServices().Delete(img);
                    //LoadLinks(true);
                    break;
            }
        }
    }
}