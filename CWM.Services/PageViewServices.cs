using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CWM.Core.Domain;
using CWM.Persistence.Repositories;
using CWM.Core.Domain.Interfaces;

namespace CWM.Services
{
    public class PageViewServices
    {
        public IOrderedEnumerable<PageApplicationView> GetPageApplicationViewsByPageID(int pageID)
        {
            return new PageApplicationViewRepository().GetByPageID(pageID).OrderBy(o => o.SortOrder);
        }

        public PageApplicationView GetPageApplicationViewsByPageIDApplicationViewID(int pageID, int appViewID)
        {
            return new PageApplicationViewRepository().GetByPageIDApplicationViewID(pageID, appViewID);
        }
    }
}
