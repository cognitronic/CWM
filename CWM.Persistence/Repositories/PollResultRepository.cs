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
    public class PollResultRepository : BaseRepository<PollResult, int>
    {
        public IList<PollResult> GetByPollID(int pollID)
        {
            return Session.CreateCriteria<PollResult>()
                .Add(Expression.Eq("PollID", pollID))
                .List<PollResult>();
        }

        public IList<PollResult> GetByPollOptionID(int pollOptionID)
        {
            return Session.CreateCriteria<PollResult>()
                .Add(Expression.Eq("PollOptionID", pollOptionID))
                .List<PollResult>();
        }
    }
}
