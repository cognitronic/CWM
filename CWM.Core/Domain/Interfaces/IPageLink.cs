using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CWM.Core.Domain.Interfaces
{
    public interface IPageLink
    {
        int ID { get; set; }
        int PageID { get; set; }
        string ImagePath { get; set; }
        string Title { get; set; }
        string URL { get; set; }
        string LinkContent { get; set; }
        Page PageRef { get; set; }
    }
}
