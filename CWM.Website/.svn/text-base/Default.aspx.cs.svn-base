using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using CWM.Presenters;
using IdeaSeed.Core;
using CWM.Web.Bases;
using CWM.Presenters.ViewInterfaces;
using CWM.Core.Domain;
using CWM.Core.Domain.Interfaces;
using CWM.Core.Security;

namespace CWM.Website
{
    [PresenterType(typeof(DefaultPagePresenter))]
    public partial class Default : CWMBasePage, IDefaultPageView
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadViewControls(Master.MainContent);
            Master.Page.Title = SecurityContextManager.Current.CurrentItem.SEOTitle;
            CWM.Website.Views.PrimaryNavView view = new Views.PrimaryNavView();
        }

        private void LoadViewControls(ContentPlaceHolder mainContent)
        {
            var header = new ContentPlaceHolder();
            header = (ContentPlaceHolder)this.Master.FindControl("head");
            this.Title = SecurityContextManager.Current.CurrentPage.Title;
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "keywords";
            meta.Content = ((CWM.Core.Domain.Page)SecurityContextManager.Current.CurrentPage).SEOKeywords;
            header.Controls.Add(meta);

            meta = new HtmlMeta();
            meta.Name = "Description";
            meta.Content = ((CWM.Core.Domain.Page)SecurityContextManager.Current.CurrentPage).SEODescription;
            header.Controls.Add(meta);

            base.SelfRegister(HttpContext.Current.Handler as System.Web.UI.Page);
            if (this.OnLoadData != null)
            {
                this.OnLoadData(this, EventArgs.Empty);
            }

            foreach (var view in MainContentViews)
            {
                Control c = LoadControl(view.ApplicationView.Path);
                mainContent.Controls.Add(c);
            }
        }

        #region IPageManagerView Members

        public event EventHandler OnLoadData;

        private IList<IPageApplicationView> _mainContentViews = new List<IPageApplicationView>();
        public IList<IPageApplicationView> MainContentViews
        {
            get
            {
                return _mainContentViews;
            }
            set
            {
                _mainContentViews = value;
            }
        }

        #endregion
    }
}