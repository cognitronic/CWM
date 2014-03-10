using System;
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
using Telerik.Web.UI;

namespace CWM.Website.Views
{
    [PresenterType(typeof(PageLinksPresenter))]
    public partial class PageLinksView : BaseWebUserControl, IPageLinksView
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            base.SelfRegister(this);
            if (!IsPostBack)
            {
                if (this.OnGetItems != null)
                {
                    var args = new CWMGridArg();
                    args.BindData = true;
                    this.OnGetItems(this, args);
                }
            }
        }

        protected void DetailsNeedDataSource(object o, RadListViewNeedDataSourceEventArgs e)
        {
            var args = new CWMGridArg();
            args.BindData = false;
            if (this.OnGetItems != null)
            {
                this.OnGetItems(this, args);
            }
        }

        #region IPageLinksView Members

        public IList<PageLink> Links
        {
            get;
            set;
        }

        public event EventHandler<CWMGridArg> OnGetItems;

        public void LoadResultSet(CWMGridArg args)
        {
            dlDetails.DataSource = null;
            dlDetails.DataSource = this.Links.OrderBy(o => o.Title);
            if (args.BindData)
                dlDetails.DataBind();
        }

        #endregion
    }
}