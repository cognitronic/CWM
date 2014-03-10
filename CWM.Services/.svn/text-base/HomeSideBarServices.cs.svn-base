using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CWM.Core.Domain;
using CWM.Persistence.Repositories;

namespace CWM.Services
{
    public class HomeSideBarServices
    {
        public IList<HomeSideBar> GetAll()
        {
            return new HomeSideBarRepository().GetAll();
        }

        public HomeSideBar Save(HomeSideBar item)
        {
            return new HomeSideBarRepository().SaveOrUpdate(item);
        }

        public void Delete(HomeSideBar item)
        {
            new HomeSideBarRepository().Delete(item);
        }

        public HomeSideBar GetByID(int id)
        {
            return new HomeSideBarRepository().GetByID(id, false);
        }
    }
}
