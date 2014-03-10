using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gallio.Framework;
using MbUnit.Framework;
using MbUnit.Framework.ContractVerifiers;
using IdeaSeed.Core.Utils;
using IdeaSeed.Core.Data.NHibernate;
using NHibernate.Criterion;
using CWM.Core.Domain;
using CWM.Persistence.Repositories;

namespace CWM.PersistenceTest
{
    [TestFixture]
    public class Class1
    {

        private PageRepository _pageRepository;
        private BlogRepository _blogRepository;

        [SetUp]
        public void TestFixtureSetup()
        {
            _pageRepository = new PageRepository();
            _blogRepository = new BlogRepository();
        }

        [Test]
        public void CanGetPage()
        {
            var b = _pageRepository.GetAll();
            Assert.AreEqual(1, b[0].ID);
        }

        [Test]
        public void CanAccessUserFromBlog()
        {
            var b = _blogRepository.GetByID(1, false);
            Assert.AreEqual(1, b.ID);
            Assert.IsNotNull(b.BlogUser);
            Assert.AreEqual("Daniel", b.BlogUser.FirstName);
            //Assert.IsInstanceOfType(typeof(User), b.BlogUser.GetType().BaseType);
        }

        [Test]
        public void CanGetBlogByType()
        {
            var b = _blogRepository.GetByPostType(3);
            Assert.AreEqual(1, b.Count);
            Assert.IsNotNull(b);
            Assert.AreEqual("Public input sought for Stanislaus supervisors districts", b[0].Title);
            //Assert.IsInstanceOfType(typeof(User), b.BlogUser.GetType().BaseType);
        }
    }
}
