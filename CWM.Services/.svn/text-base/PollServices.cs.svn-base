using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CWM.Core.Domain;
using CWM.Persistence.Repositories;

namespace CWM.Services
{
    public class PollServices
    {
        public Poll GetByID(int id)
        {
            return new PollRepository().GetByID(id, false);
        }

        public IList<Poll> GetPagedList(int startRow, int pageSize, out int count)
        {
            return new PollRepository()
                .GetPagedList(startRow, pageSize, out count)
                .OrderBy(o => o.ID)
                .ToList<Poll>();
        }

        public IList<Poll> GetAll()
        {
            return new PollRepository()
                .GetAll()
                .OrderBy(o => o.ID)
                .ToList<Poll>();
        }

        public Poll Save(Poll item)
        {
            return new PollRepository().SaveOrUpdate(item);
        }

        public void Delete(Poll item)
        {
            new PollRepository().Delete(item);
        }

        public Poll GetActivePoll()
        {
            return new PollRepository().GetActivePoll();
        }
    }
}
