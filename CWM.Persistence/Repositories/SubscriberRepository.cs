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
    public class SubscriberRepository : BaseRepository<Subscriber, int>
    {
        public Subscriber GetByEmail(string email)
        {
            return Session.CreateCriteria<Subscriber>()
                .Add(Expression.Eq("Email", email))
                .UniqueResult<Subscriber>();
        }
    }
}
