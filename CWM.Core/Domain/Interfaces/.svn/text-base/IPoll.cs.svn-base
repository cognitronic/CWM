using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CWM.Core.Domain.Interfaces
{
    public interface IPoll
    {
        int ID { get; set; }
        string Name { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        string Question { get; set; }
        IList<PollOption> Options { get; set; }
        bool IsActive { get; set; }
    }
}
