using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IdeaSeed.Core;
using CWM.Core.Domain.Interfaces;

namespace CWM.Presenters.ViewInterfaces
{
    public interface IBlogListView : IView
    {
        string BlogHTML { get; set; }
    }
}
