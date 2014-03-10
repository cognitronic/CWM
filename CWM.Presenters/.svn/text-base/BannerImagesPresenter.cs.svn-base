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
    public class BannerImagesPresenter : Presenter
    {
        IBannerImagesView _view;

        public BannerImagesPresenter(IBannerImagesView view, ISessionProvider session)
            : base(view, session)
        {
            _view = base.GetView<IBannerImagesView>();
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
            var list = ApplicationContext.BannerImageData;
            sb.Append("<div id='slides'>");
            foreach (var item in list)
            {
                sb.Append("<div class='active' data-delay='5'><img src='");
                sb.Append(item.Path);
                sb.Append("' alt='");
                sb.Append(item.ToolTip);
                sb.Append("' /><div><h1 class='clearfix'><a href='#'>");
                sb.Append(item.Title);
                sb.Append("</a></h1><h3>");
                sb.Append(item.SubText);
                sb.Append("</h3></div></div>");
            }
            sb.Append("</div>");
            _view.BannerHTML = sb.ToString();
        }

        void _view_InitView(object sender, EventArgs e)
        {

        }
    }
}
