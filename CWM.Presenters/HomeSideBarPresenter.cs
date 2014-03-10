using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CWM.Presenters.ViewInterfaces;
using CWM.Core.Domain;
using CWM.Core.Security;
using IdeaSeed.Core;
using CWM.Services;
using CWM.Core;

namespace CWM.Presenters
{
    public class HomeSideBarPresenter : Presenter
    {
        IHomeSideBarView _view;

        public HomeSideBarPresenter(IHomeSideBarView view, ISessionProvider session)
            : base(view, session)
        {
            _view = base.GetView<IHomeSideBarView>();
            _view.InitView += new EventHandler(_view_InitView);
            _view.LoadView += new EventHandler(_view_LoadView);
            _view.UnloadView += new EventHandler(_view_UnloadView);
        }

        void _view_UnloadView(object sender, EventArgs e)
        {

        }

        void _view_LoadView(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            var list = new HomeSideBarServices().GetAll();
            sb.Append("<ul class='thumbs'>");
            foreach (var item in list)
            {
                sb.Append("<li><a href='");
                sb.Append(item.URL);
                sb.Append("' target='_blank'><img style='height: 155px; width: 250px;' src='");
                sb.Append(item.ImagePath);
                sb.Append("'/></a><h3><a href='");
                sb.Append(item.URL);
                sb.Append("'>");
                sb.Append(item.Name);
                sb.Append("</a><br /><span style='font-weight:normal;'>");
                sb.Append(item.Address);
                sb.Append("</span></h3></li> ");
            }
            sb.Append("</ul>");
            _view.SideBarHTML = sb.ToString();
        }

        void _view_InitView(object sender, EventArgs e)
        {

        }
    }
}
