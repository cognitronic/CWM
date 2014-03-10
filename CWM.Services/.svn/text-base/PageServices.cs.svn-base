using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CWM.Core.Domain;
using CWM.Persistence.Repositories;

namespace CWM.Services
{
    public class PageServices
    {
        public Page GetByID(int id)
        {
            return new PageRepository().GetByID(id, false);
        }

        public IList<Page> GetPagedList(int startRow, int pageSize, out int count)
        {
            return new PageRepository()
                .GetPagedList(startRow, pageSize, out count)
                .OrderBy(o => o.SortOrder)
                .ToList<Page>();
        }

        public IList<Page> GetAll()
        {
            return new PageRepository()
                .GetAll()
                .OrderBy(o => o.SortOrder)
                .ToList<Page>();
        }

        public Page Save(Page item)
        {
            return new PageRepository().SaveOrUpdate(item);
        }

        public void Delete(Page item)
        {
            new PageRepository().Delete(item);
        }

        public IList<Page> GetByNavigationTypeAccessLevel(int navtype, int accesslevel)
        {
            return new PageRepository()
                .GetByNavigationTypeAccessLevel(navtype, accesslevel)
                .OrderBy(o => o.SortOrder)
                .ToList<Page>();
        }

        public IList<Page> GetByNavigationTypeID(int navtype)
        {
            return new PageRepository()
                .GetByNavigationTypeID(navtype)
                .OrderBy(o => o.SortOrder)
                .ToList<Page>();
        }

        public Page GetByNameAccessLevel(string name, int accesslevel)
        {
            return new PageRepository()
            .GetByNameAccessLevel(name, accesslevel);
        }

        public IList<Page> GetByManageable(bool isManageable)
        {
            return new PageRepository().GetByManageable(isManageable);
        }
    }
}
