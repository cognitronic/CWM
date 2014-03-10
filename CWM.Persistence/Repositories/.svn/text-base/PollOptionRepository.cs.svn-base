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
    public class PollOptionRepository : BaseRepository<PollOption, int>
    {
        public IList<PollOption> GetByPollID(int pollID)
        {
            return Session.CreateCriteria<PollOption>()
                .Add(Expression.Eq("PollID", pollID))
                .List<PollOption>();
        }
    }
}
