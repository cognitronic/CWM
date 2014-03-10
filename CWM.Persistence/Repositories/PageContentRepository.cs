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
    public class PageContentRepository : BaseRepository<PageContent, int>
    {
        public IList<PageContent> GetByPageID(int pageID)
        {
            return Session.CreateCriteria<PageContent>()
                .Add(Expression.Eq("PageID", pageID))
                .List<PageContent>();
        }
    }
}
