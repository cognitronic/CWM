using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CWM.Core.Domain.Interfaces;

namespace CWM.Core.Domain
{
    public class Poll : IPoll
    {
        public virtual int ID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Question { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual DateTime EndDate { get; set; }
        private IList<PollOption> _options = new List<PollOption>();
        public virtual IList<PollOption> Options { get { return _options; } set { _options = value; } }
    }
}
