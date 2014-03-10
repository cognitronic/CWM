﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CWM.Presenters.ViewInterfaces;
using CWM.Presenters;
using CWM.Core.Domain;
using CWM.Core.Security;
using IdeaSeed.Core;
using CWM.Web.Bases;
using CWM.Core;

namespace CWM.Website.Views
{
    [PresenterType(typeof(BannerImagesPresenter))]
    public partial class BannerImagesView : BaseWebUserControl, IBannerImagesView
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            base.SelfRegister(this);
            if (this.LoadView != null)
            {
                this.LoadView(this, EventArgs.Empty);
            }
        }
        public new event EventHandler LoadView;
        #region IBannerImagesView Members

        public string BannerHTML
        {
            get
            {
                return divImages.InnerHtml;
            }
            set
            {
                divImages.InnerHtml = value;
            }
        }

        #endregion
    }
}