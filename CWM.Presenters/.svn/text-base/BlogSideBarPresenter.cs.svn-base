using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CWM.Presenters.ViewInterfaces;
using CWM.Core.Domain;
using CWM.Core.Security;
using IdeaSeed.Core;
using System.Configuration;
using CWM.Services;
using CWM.Core;

namespace CWM.Presenters
{
    public class BlogSideBarPresenter : Presenter
    {
        IBlogSideBarView _view;

        public BlogSideBarPresenter(IBlogSideBarView view, ISessionProvider session)
            : base(view, session)
        {
            _view = base.GetView<IBlogSideBarView>();
            _view.InitView += new EventHandler(_view_InitView);
            _view.LoadView += new EventHandler(_view_LoadView);
            _view.UnloadView += new EventHandler(_view_UnloadView);
        }

        void _view_UnloadView(object sender, EventArgs e)
        {

        }

        void _view_LoadView(object sender, EventArgs e)
        {
            
        }

        void _view_InitView(object sender, EventArgs e)
        {

        }
    }
}
