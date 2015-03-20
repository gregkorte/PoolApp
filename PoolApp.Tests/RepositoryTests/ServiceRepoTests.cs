using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PoolApp.Repositories;
using PoolApp.Models;
using System.Collections.Generic;

namespace PoolApp.Tests.RepositoryTests
{
        [TestClass]
    public class ServiceRepoTests
    {
        private static ServiceRepo service_repo = new ServiceRepo("Name=PoolAppTestContext");
        private static ApplicationUser user;

        [ClassInitialize]
        public static void SetUp(TestContext _context)
        {
            helperTests.ClearDB();
            user = helperTests.firstUser();
        }

        [TestInitialize]
        public void TestSetUp() 
        {
            helperTests.ClearDB();
            helperTests.seedDb();
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            service_repo.Clear();
        }

        [ClassCleanup]
        public static void CleanUp()
        {
            helperTests.ClearDB();
        }

        [TestMethod]
        public void ServiceTestGetAllServices()
        {
            var allServices = service_repo.GetAllServices();
            Assert.AreEqual(2, allServices.Count);
        }

        [TestMethod]
        public void ServiceTestClear()
        {
            List<Service> services = service_repo.GetAllServices();
            int preCount = service_repo.GetCount();
            Assert.AreEqual(2, preCount);
            service_repo.Clear();
            int postCount = service_repo.GetCount();
            Assert.AreEqual(0, postCount);
        }

        [TestMethod]
        public void ServiceTestDelete()
        {
            List<Service> services = service_repo.GetAllServices();
            Assert.AreEqual(2, services.Count);
            var firstServiceId = services[0].ID;
            service_repo.Delete(firstServiceId);
            List<Service> newServiceList = service_repo.GetAllServices();
            Assert.AreEqual(1, newServiceList.Count);
            Assert.AreEqual("One-Time Cleaning", newServiceList[0].Name);
        }

        [TestMethod]
        public void ServiceTestGetById()
        {
            List<Service> service = service_repo.GetAllServices();
            int firstServiceId = service[0].ID;
            Service firstService = service_repo.GetById(firstServiceId);
            Assert.AreEqual(service[0], firstService);
        }

        [TestMethod]
        public void ServiceTestAdd()
        {
            int serviceCount = service_repo.GetAllServices().Count;
            Service regularCleaning = new Service("Regular Cleaning", 45, "Week");
            service_repo.Add(regularCleaning);
            List<Service> newServiceList = service_repo.GetAllServices();
            Assert.AreEqual(3, newServiceList.Count);
            Assert.AreEqual(regularCleaning, newServiceList[2]);
        }

        [TestMethod]
        public void ServiceTestGetCount()
        {
            int serviceCount = service_repo.GetCount();
            Assert.AreEqual(2, serviceCount);
        }

        [TestMethod]
        public void ServiceTestEdit()
        {
            Service regularCleaning = service_repo.GetAllServices()[0];
            regularCleaning.Name = "Regular Weekly Cleaning";
            service_repo.Edit(regularCleaning);
            Service newService = service_repo.GetAllServices()[0];
            Assert.AreEqual("Regular Weekly Cleaning", newService.Name);
        }
    }
}
