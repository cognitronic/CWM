﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CWM.Presenters.ViewInterfaces;
using CWM.Core.Domain;
using CWM.Core.Security;
using IdeaSeed.Core;
using CWM.Services;
using CWM.Core;
using CWM.Core.Domain.Interfaces;

namespace CWM.Presenters
{
    public class PrimaryNavPresenter : Presenter
    {
        IPrimaryNavView _view;

        public PrimaryNavPresenter(IPrimaryNavView view, ISessionProvider session)
            : base(view, session)
        {
            _view = base.GetView<IPrimaryNavView>();
            _view.InitView += new EventHandler(_view_InitView);
            _view.LoadView += new EventHandler(_view_LoadView);
            _view.UnloadView += new EventHandler(_view_UnloadView);
            _view.OnLinkClicked += new EventHandler(_view_OnLinkClicked);
            _view.OnLoadNav += new EventHandler(_view_OnLoadNav);
        }

        void _view_OnLoadNav(object sender, EventArgs e)
        {
            _view.PrimaryNavText = MasterPageContext.PrimaryNavText;
        }

        void _view_OnLinkClicked(object sender, EventArgs e)
        {

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
