using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CWM.Core.Domain;
using CWM.Persistence.Repositories;

namespace CWM.Services
{
    public class BlogServices
    {
        public Blog GetByID(int id)
        {
            return new BlogRepository().GetByID(id, false);
        }

        public IList<Blog> GetPagedList(int startRow, int pageSize, out int count)
        {
            return new BlogRepository()
                .GetPagedList(startRow, pageSize, out count)
                .OrderByDescending(o => o.StartDate)
                .ToList<Blog>();
        }

        public IList<Blog> GetAll()
        {
            return new BlogRepository()
                .GetAll()
                .OrderByDescending(o => o.StartDate)
                .ToList<Blog>();
        }

        public Blog Save(Blog item)
        {
            return new BlogRepository().SaveOrUpdate(item);
        }

        public void Delete(Blog item)
        {
            new BlogRepository().Delete(item);
        }

        public IList<Blog> GetByPostType(int postType)
        {
            return new BlogRepository().GetByPostType(postType).OrderByDescending(o => o.StartDate).ToList<Blog>();
        }

        public Blog GetLatestByType(int postType)
        {
            return new BlogRepository().GetLatestByType(postType);
        }

        public IList<Blog> GetHomePagePosts()
        {
            var list = new List<Blog>();
            list.Add(new BlogRepository().GetLatestByType((int)BlogPostType.ARTS));
            list.Add(new BlogRepository().GetLatestByType((int)BlogPostType.BUSINESS));
            list.Add(new BlogRepository().GetLatestByType((int)BlogPostType.CITY));
            return list;
        }

        public Blog GetByTypeTitle(int postType, string title)
        {
            return new BlogRepository().GetByTypeTitle(postType, title);
        }
    }
}
