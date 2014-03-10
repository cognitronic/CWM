using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CWM.Presenters.ViewInterfaces;
using CWM.Core.Domain;
using CWM.Core.Security;
using IdeaSeed.Core;
using CWM.Services;

namespace CWM.Presenters
{
    public class DefaultPagePresenter : Presenter
    {
        IDefaultPageView _view;

        public DefaultPagePresenter(IDefaultPageView view, ISessionProvider session)
            : base(view, session)
        {
            _view = base.GetView<IDefaultPageView>();
            _view.OnLoadData += new EventHandler(_view_OnLoadData);
        }

        void _view_OnLoadData(object sender, EventArgs e)
        {
            var views = new PageViewServices().GetPageApplicationViewsByPageID(SecurityContextManager.Current.CurrentPage.ID);
            var list = new List<ApplicationView>();
            foreach (var view in views)
            {
                if (view.ApplicationView != null)
                {
                    switch (view.ViewLayout)
                    { 
                        case ApplicationViewLayout.MAIN:
                            _view.MainContentViews.Add(view);
                            break;
                    }
                }
            }
        }
    }
}
