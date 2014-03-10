using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CWM.Core.Domain;
using CWM.Persistence.Repositories;

namespace CWM.Services
{
    public class PollOptionServices
    {
        public PollOption GetByID(int id)
        {
            return new PollOptionRepository().GetByID(id, false);
        }

        public IList<PollOption> GetPagedList(int startRow, int pageSize, out int count)
        {
            return new PollOptionRepository()
                .GetPagedList(startRow, pageSize, out count)
                .OrderBy(o => o.ID)
                .ToList<PollOption>();
        }

        public IList<PollOption> GetAll()
        {
            return new PollOptionRepository()
                .GetAll()
                .OrderBy(o => o.ID)
                .ToList<PollOption>();
        }

        public PollOption Save(PollOption item)
        {
            return new PollOptionRepository().SaveOrUpdate(item);
        }

        public void Delete(PollOption item)
        {
            new PollOptionRepository().Delete(item);
        }

        public IList<PollOption> GetByPollID(int pollID)
        {
            return new PollOptionRepository()
                .GetByPollID(pollID)
                .OrderBy(o => o.ID)
                .ToList<PollOption>();
        }
    }
}
