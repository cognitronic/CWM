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

namespace CWMAdmin.Website
{
    public partial class Page : CWMAdminBasePage
    {
        const int MaxTotalBytes = 1048576; // 1 MB
        int totalBytes;

        public bool? IsRadAsyncValid
        {
            get
            {
                if (Session["IsRadAsyncValid"] == null)
                {
                    Session["IsRadAsyncValid"] = true;
                }

                return Convert.ToBoolean(Session["IsRadAsyncValid"].ToString());
            }
            set
            {
                Session["IsRadAsyncValid"] = value;
            }
        }

        public CWM.Core.Domain.Page CurrentPge
        {
            get
            {
                if ((CWM.Core.Domain.Page)Session["CurrentPage"] != null)
                {
                    return Session["CurrentPage"] as CWM.Core.Domain.Page;
                }
                return null;
            }
            set
            {
                Session["CurrentPage"] = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            RadAjaxManager ram = (RadAjaxManager)this.Master.FindControl("RadAjaxManager1");
            RadAjaxLoadingPanel alp = (RadAjaxLoadingPanel)this.Master.FindControl("AjaxLoadingPanel1");
            ram.AjaxSettings.AddAjaxSetting(rgPageLinks, rgPageLinks, alp);
            if (!IsPostBack)
            {
                LoadPage();
                LoadLinks(true);
            }
        }

        private void LoadPage()
        {
            if (!string.IsNullOrEmpty(Request.QueryString["id"]))
            {
                this.CurrentPge = new PageServices().GetByID(Convert.ToInt32(Request.QueryString["id"]));
                tbDisplayName.Text = this.CurrentPge.DisplayName;
                tbSeoDescription.Text = this.CurrentPge.SEODescription;
                tbSeoKeywords.Text = this.CurrentPge.SEOKeywords;
                tbSeoTitle.Text = this.CurrentPge.SEOTitle;
                cbIsActive.Checked = this.CurrentPge.IsActive;
                tbPageContent.Text = this.CurrentPge.Content[0].PageData;
                tbTitle.Text = this.CurrentPge.Content[0].Title;
                tbSubTitle.Text = this.CurrentPge.Content[0].SubTitle;
            }
        }

        protected void EditPageClicked(object o, EventArgs e)
        { 
            
        }

        protected void SavePageClicked(object o, EventArgs e)
        {
            SavePage();
        }

        protected void CancelClicked(object o, EventArgs e)
        {
            Response.Redirect(Request.Url.PathAndQuery);
        }

        protected void NeedDataSource(object o, GridNeedDataSourceEventArgs e)
        {
            LoadLinks(false);
        }

        private void LoadLinks(bool bindData)
        {
            rgPageLinks.DataSource = this.CurrentPge.Links;
            if(bindData)
                rgPageLinks.DataBind();
        }

        protected void ItemCreated(object o, GridItemEventArgs e)
        {
            if (e.Item is GridEditableItem && e.Item.IsInEditMode)
            {
                RadAsyncUpload upload = ((GridEditableItem)e.Item)["Upload"].FindControl("AsyncUpload1") as RadAsyncUpload;
                TableCell cell = (TableCell)upload.Parent;

                CustomValidator validator = new CustomValidator();
                validator.ErrorMessage = "Please select file to be uploaded";
                validator.ClientValidationFunction = "validateRadUpload";
                validator.Display = ValidatorDisplay.Dynamic;
                cell.Controls.Add(validator);
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
                    var i = new PageLink();
                    i.Title = "";
                    i.ImagePath = "";
                    i.ID = 0;
                    e.Item.OwnerTableView.InsertItem(new PageLink());
                    break;
                case RadGrid.UpdateCommandName:
                    var img = new PageLinkServices().GetByID(Convert.ToInt32(e.Item.OwnerTableView.DataKeyValues[e.Item.ItemIndex]["ID"].ToString()));
                    GridEditFormItem insertItem = e.Item as GridEditFormItem;
                    string imageName = (insertItem["Title"].FindControl("tbTitle") as RadTextBox).Text;
                     RadAsyncUpload radAsyncUpload = insertItem["Upload"].FindControl("AsyncUpload1") as RadAsyncUpload;
                     if (radAsyncUpload.UploadedFiles.Count > 0)
                     {
                         UploadedFile file = radAsyncUpload.UploadedFiles[0];
                         string filePath = this.CurrentPge.Name.Replace(" ", "-") + "_" +
                             DateTime.Now.Ticks.ToString() + "_" +
                             file.FileName;
                         //string filePath = file.FileName;
                         file.SaveAs(Server.MapPath("~/contentImages/") + filePath, false);
                         img.ImagePath = "/contentImages/" + filePath;
                     }
                    img.Title = imageName;
                    img.LinkContent = (insertItem["LinkContent"].FindControl("tbLinkContent") as RadTextBox).Text;
                    img.PageID = this.CurrentPge.ID;
                    img.URL = (insertItem["URL"].FindControl("tbURL") as RadTextBox).Text;
                    new PageLinkServices().Save(img);
                    LoadPage();
                    LoadLinks(true);
                    break;
                case RadGrid.PerformInsertCommandName:
                    insertItem = e.Item as GridEditFormInsertItem;
                    imageName = (insertItem["Title"].FindControl("tbTitle") as RadTextBox).Text;
                    
                    radAsyncUpload = insertItem["Upload"].FindControl("AsyncUpload1") as RadAsyncUpload;
                    UploadedFile filez = radAsyncUpload.UploadedFiles[0];
                    string filePathz = this.CurrentPge.Name.Replace(" ", "-") + "_" +
                        DateTime.Now.Ticks.ToString() + "_" +
                        filez.FileName;
                    //string filePath = file.FileName;
                    filez.SaveAs(Server.MapPath("~/contentImages/content") + filePathz, false);
                    img = new PageLink();
                    img.ImagePath = "/contentImages/content" + filePathz;
                    img.Title = imageName;
                    img.LinkContent = (insertItem["LinkContent"].FindControl("tbLinkContent") as RadTextBox).Text;
                    img.PageID = this.CurrentPge.ID;
                    img.URL = (insertItem["URL"].FindControl("tbURL") as RadTextBox).Text;
                    new PageLinkServices().Save(img);

                    LoadPage();
                    LoadLinks(true);

                    break;
                case RadGrid.DeleteCommandName:
                    img = new PageLinkServices().GetByID(Convert.ToInt32(e.Item.OwnerTableView.DataKeyValues[e.Item.ItemIndex]["ID"].ToString()));
                    new PageLinkServices().Delete(img);
                    LoadPage();
                    LoadLinks(true);
                    break;
            }
        }

        public void RadAsyncUpload1_ValidatingFile(object sender, Telerik.Web.UI.Upload.ValidateFileEventArgs e)
        {
            if ((totalBytes < MaxTotalBytes) && (e.UploadedFile.ContentLength < MaxTotalBytes))
            {
                e.IsValid = true;
                totalBytes += e.UploadedFile.ContentLength;
                IsRadAsyncValid = true;
            }
            else
            {
                e.IsValid = false;
                IsRadAsyncValid = false;
            }
        }

        private void SavePage()
        {
            var p = new PageServices().GetByID(this.CurrentPge.ID);
            p.DisplayName = tbDisplayName.Text;
            p.SEODescription = tbSeoDescription.Text;
            p.SEOKeywords = tbSeoKeywords.Text;
            p.SEOTitle = tbSeoTitle.Text;
            p.Content[0].PageData = tbPageContent.Text;
            p.Content[0].Title = tbTitle.Text;
            p.Content[0].SubTitle = tbSubTitle.Text;
            p.IsActive = cbIsActive.Checked;
            new PageServices().Save(p);
            Response.Redirect(Request.Url.PathAndQuery);
        }
    }
}