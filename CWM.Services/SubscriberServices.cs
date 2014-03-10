using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CWM.Core.Domain;
using CWM.Persistence.Repositories;

namespace CWM.Services
{
    public class SubscriberServices
    {
        public Subscriber GetByID(int id)
        {
            return new SubscriberRepository().GetByID(id, false);
        }

        public IList<Subscriber> GetPagedList(int startRow, int pageSize, out int count)
        {
            return new SubscriberRepository()
                .GetPagedList(startRow, pageSize, out count)
                .OrderByDescending(o => o.Email)
                .ToList<Subscriber>();
        }

        public IList<Subscriber> GetAll()
        {
            return new SubscriberRepository()
                .GetAll()
                .OrderByDescending(o => o.Email)
                .ToList<Subscriber>();
        }

        public Subscriber Save(Subscriber item)
        {
            return new SubscriberRepository().SaveOrUpdate(item);
        }

        public void Delete(Subscriber item)
        {
            new SubscriberRepository().Delete(item);
        }

        public Subscriber GetByEmail(string email)
        {
            return new SubscriberRepository().GetByEmail(email);
        }

        public void SaveNewSubscriber(string email)
        {
            var s = GetByEmail(email);
            if (s == null)
            {
                s = new Subscriber();
                s.Email = email;
                Save(s);
            }
        }
    }
}
