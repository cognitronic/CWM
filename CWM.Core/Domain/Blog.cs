using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CWM.Core.Domain.Interfaces;

namespace CWM.Core.Domain
{
    public class Blog : IBlog
    {
        public virtual int ID { get; set; }
        public virtual string Title { get; set; }
        public virtual int EnteredBy { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual DateTime EndDate { get; set; }
        public virtual string BlogContent { get; set; }
        public virtual int PostType { get; set; }
        public virtual IUser BlogUser { get; set; }
        public virtual string SEOKeywords { get; set; }
        public virtual string SEODescription { get; set; }
    }
}
