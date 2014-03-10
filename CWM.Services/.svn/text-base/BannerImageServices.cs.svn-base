using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CWM.Core.Domain;
using CWM.Persistence.Repositories;

namespace CWM.Services
{
    public class BannerImageServices
    {
        public IList<BannerImage> GetAll()
        {
            return new BannerImageRepository().GetAll();
        }

        public BannerImage Save(BannerImage item)
        {
            return new BannerImageRepository().SaveOrUpdate(item);
        }

        public void Delete(BannerImage item)
        {
            new BannerImageRepository().Delete(item);
        }

        public BannerImage GetByID(int id)
        {
            return new BannerImageRepository().GetByID(id, false);
        }
    }
}
