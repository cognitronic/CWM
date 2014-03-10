using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IdeaSeed.Core;
using CWM.Core.Domain;

namespace CWM.Presenters.ViewInterfaces
{
    public interface IPollView : IView
    {
        Poll CurrentPoll { get; set; }
    }
}
