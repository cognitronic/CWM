using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IdeaSeed.Core;
using CWM.Core.Domain.Interfaces;

namespace CWM.Presenters.ViewInterfaces
{
    public interface IInternalContentView : IView
    {
        string ContentHTML { get; set; }
    }
}
