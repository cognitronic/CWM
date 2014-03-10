using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CWM.Core.Domain.Interfaces;

namespace CWM.Core.Domain
{
    public class HomeSideBar : IHomeSideBar
    {
        public virtual int ID { get; set; }
        public virtual string ImagePath { get; set; }
        public virtual string Name { get; set; }
        public virtual string Address { get; set; }
        public virtual string URL { get; set; }
    }
}
