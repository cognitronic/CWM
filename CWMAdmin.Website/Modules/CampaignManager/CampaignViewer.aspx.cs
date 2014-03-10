﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using IdeaSeed.Web.UI;
using System.Data;
using Telerik.Web.UI;
using System.Configuration;
using System.IO;
using CampaignManager.Core;
using CampaignManager.Data.Repositories;
using CampaignManager.Presentation;
using IdeaSeed.Core;
using CWM.Services;
using CWM.Core.Domain;
using CWMAdmin.Web.Bases;
using CWM.Core.Security;
using CWMAdmin.Web.Utils;
using System.Drawing;

namespace CWMAdmin.Website.Modules.CampaignManager
{
    public partial class CampaignViewer : CWMAdminBasePage
    {
        #region Events
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!string.IsNullOrEmpty(Request.QueryString["cid"]))
                {
                    LoadCampaign();
                }
                //else if (!string.IsNullOrEmpty(Request.QueryString["cid"]))
                //{
                //    LoadCampaignPreview();
                //}
                //Master.IsMenuVisible = false;
                //Master.IsLogoVisible = false;
                //Master.IsLoggedOnUserVisible = false;
                //Master.IsApplicationDDLVisible = false;
                //Master.IsModuleNavVisible = false;
            }
        }

        #endregion

        #region Methods

        private void LoadCampaign()
        {
            var ch = new CampaignRepository().GetByID(Convert.ToInt32(Request.QueryString["cid"]), false);
            tbSubject.Text = ch.EmailSubject;
            lblBody.Text = ch.EmailBody;
            lblCampaign.Text = ch.CampaignName;
        }

        private void LoadCampaignPreview()
        {
            var c = new CampaignRepository().GetByID(Convert.ToInt32(Request.QueryString["cid"]), false);
            tbSubject.Text = c.EmailSubject;
            lblBody.Text = c.EmailBody;
            lblCampaign.Text = c.CampaignName;
        }
        #endregion
    }
}