using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CWM.Core.Domain;
using CWM.Persistence.Repositories;

namespace CWM.Services
{
    public class PollResultServices
    {
        public PollResult GetByID(int id)
        {
            return new PollResultRepository().GetByID(id, false);
        }

        public IList<PollResult> GetPagedList(int startRow, int pageSize, out int count)
        {
            return new PollResultRepository()
                .GetPagedList(startRow, pageSize, out count)
                .OrderBy(o => o.ID)
                .ToList<PollResult>();
        }

        public IList<PollResult> GetAll()
        {
            return new PollResultRepository()
                .GetAll()
                .OrderBy(o => o.ID)
                .ToList<PollResult>();
        }

        public PollResult Save(PollResult item)
        {
            return new PollResultRepository().SaveOrUpdate(item);
        }

        public void Delete(PollResult item)
        {
            new PollResultRepository().Delete(item);
        }

        public IList<PollResult> GetByPollID(int pollID)
        {
            return new PollResultRepository()
                .GetByPollID(pollID)
                .OrderBy(o => o.ID)
                .ToList<PollResult>();
        }

        public IList<PollResult> GetByPollOptionID(int pollOptionID)
        {
            return new PollResultRepository()
                .GetByPollOptionID(pollOptionID)
                .OrderBy(o => o.ID)
                .ToList<PollResult>();
        }
    }
}
