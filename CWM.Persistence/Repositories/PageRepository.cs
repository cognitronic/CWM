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
    public class PageRepository : BaseRepository<Page, int>
    {
        public Page GetByNameAccessLevel(string name, int accesslevel)
        {
            return Session.CreateCriteria<Page>()
                .Add(Expression.Eq("Name", name))
                .Add(Expression.Eq("AccessLevel", accesslevel))
                .UniqueResult<Page>();
        }

        public IList<Page> GetByNavigationTypeAccessLevel(int navtype, int accesslevel)
        {
            return Session.CreateCriteria<Page>()
                .Add(Expression.Eq("NavigationTypeID", navtype))
                .Add(Expression.Eq("AccessLevel", accesslevel))
                .List<Page>();
        }

        public IList<Page> GetByManageable(bool isManageable)
        {
            return Session.CreateCriteria<Page>()
                .Add(Expression.Eq("IsManageable", isManageable))
                .List<Page>();
        }

        public IList<Page> GetByNavigationTypeID(int navigationtypeid)
        {
            return Session.CreateCriteria<Page>()
                .Add(Expression.Eq("NavigationTypeID", navigationtypeid))
                .List<Page>();
        }

        public IList<Page> GetSubPagesByParentID(int parentID)
        {
            return Session.CreateCriteria<Page>()
                    .Add(Expression.Eq("IsActive", true))
                    .Add(Expression.Eq("ParentID", parentID))
                    .List<Page>();
        }
    }
}
