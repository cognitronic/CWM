using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using IdeaSeed.Core.Data.NHibernate;
using CWM.Core.Domain;

namespace CWM.Persistence.Repositories
{
    public class PollRepository : BaseRepository<Poll, int>
    {
        public Poll GetActivePoll()
        {
            return Session.CreateCriteria<Poll>()
                .Add(Expression.Eq("IsActive", true))
                .AddOrder(Order.Desc("StartDate"))
                .SetMaxResults(1)
                .UniqueResult<Poll>();
        }
    }
}
