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
    public partial class Banners : CWMAdminBasePage
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

        protected void Page_Load(object sender, EventArgs e)
        {
            RadAjaxManager ram = (RadAjaxManager)this.Master.FindControl("RadAjaxManager1");
            RadAjaxLoadingPanel alp = (RadAjaxLoadingPanel)this.Master.FindControl("AjaxLoadingPanel1");
            ram.AjaxSettings.AddAjaxSetting(rgBanner, rgBanner, alp);
            if (!IsPostBack)
            {
                LoadBanners(true);
            }
        }

        protected void NeedDataSource(object o, GridNeedDataSourceEventArgs e)
        {
            LoadBanners(false);
        }

        private void LoadBanners(bool bindData)
        {
            rgBanner.DataSource = new BannerImageServices().GetAll();
            if (bindData)
                rgBanner.DataBind();
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
                    var i = new BannerImage();
                    i.Title = "";
                    i.Path = "";
                    i.SubText = "";
                    i.ToolTip = "";
                    i.ID = 0;
                    e.Item.OwnerTableView.InsertItem(new BannerImage());
                    break;
                case RadGrid.UpdateCommandName:
                    var img = new BannerImageServices().GetByID(Convert.ToInt32(e.Item.OwnerTableView.DataKeyValues[e.Item.ItemIndex]["ID"].ToString()));
                    GridEditFormItem insertItem = e.Item as GridEditFormItem;
                    string imageName = (insertItem["Title"].FindControl("tbTitle") as RadTextBox).Text;
                    img.Title = imageName;
                    img.SubText = (insertItem["SubText"].FindControl("tbSubText") as RadTextBox).Text;
                    img.ToolTip = (insertItem["ToolTip"].FindControl("tbToolTip") as RadTextBox).Text;
                    new BannerImageServices().Save(img);

                    break;
                case RadGrid.PerformInsertCommandName:
                    insertItem = e.Item as GridEditFormInsertItem;
                    imageName = (insertItem["Title"].FindControl("tbTitle") as RadTextBox).Text;

                    RadAsyncUpload radAsyncUpload = insertItem["Upload"].FindControl("AsyncUpload1") as RadAsyncUpload;
                    UploadedFile file = radAsyncUpload.UploadedFiles[0];
                    string filePath = DateTime.Now.Ticks.ToString() + "_" +
                        file.FileName;
                    //string filePath = file.FileName;
                    file.SaveAs(Server.MapPath("~/BannerImages/") + filePath, false);
                    img = new BannerImage();
                    img.Path = "/BannerImages/" + filePath;
                    img.Title = imageName;
                    img.SubText = (insertItem["SubText"].FindControl("tbSubText") as RadTextBox).Text;
                    img.ToolTip = (insertItem["ToolTip"].FindControl("tbToolTip") as RadTextBox).Text;
                    new BannerImageServices().Save(img);

                    //LoadLinks(true);

                    break;
                case RadGrid.DeleteCommandName:
                    img = new BannerImageServices().GetByID(Convert.ToInt32(e.Item.OwnerTableView.DataKeyValues[e.Item.ItemIndex]["ID"].ToString()));
                    new BannerImageServices().Delete(img);
                    //LoadLinks(true);
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
    }
}