using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CWM.Core.Domain.Interfaces
{
    public interface IHomeSideBar
    {
        int ID { get; set; }
        string ImagePath { get; set; }
        string Name { get; set; }
        string Address { get; set; }
        string URL { get; set; }
    }
}
