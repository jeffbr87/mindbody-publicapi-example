using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PublicApiApp.Repositories;

namespace PublicApiAppTests.Repositories
{
    [TestClass]
    public class ClassRepositoryIntegrationTests
    {
        [TestMethod]
        public void TestGetClasses()
        {
            var repo = new ClassRepository();

            var result = repo.GetClasses("100015650", DateTime.Now, DateTime.Now.AddMonths(1));

            Assert.AreNotEqual(0, result.Count);
        }
    }
}
