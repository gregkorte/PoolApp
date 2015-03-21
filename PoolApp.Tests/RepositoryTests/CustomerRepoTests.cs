using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PoolApp.Repositories;
using PoolApp.Models;
using System.Collections.Generic;

namespace PoolApp.Tests.RepositoryTests
{
    [TestClass]
    public class CustomerRepoTests
    {
        private static CustomerRepo customer_repo = new CustomerRepo("Name=PoolAppTestContext");
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
            customer_repo.Clear();
        }

        [ClassCleanup]
        public static void CleanUp()
        {
            helperTests.ClearDB();
        }

        [TestMethod]
        public void CustomerTestGetAllCustomers()
        {
            var allCustomers = customer_repo.GetAllCustomers();
            Assert.AreEqual(2, allCustomers.Count);
        }

        [TestMethod]
        public void CustomerTestClear()
        {
            List<Customer> customers = customer_repo.GetAllCustomers();
            int preCount = customer_repo.GetCount();
            Assert.AreEqual(2, preCount);
            customer_repo.Clear();
            int postCount = customer_repo.GetCount();
            Assert.AreEqual(0, postCount);
        }

        [TestMethod]
        public void CustomerTestDelete()
        {
            List<Customer> customers = customer_repo.GetAllCustomers();
            Assert.AreEqual(2, customers.Count);
            var firstCustomerId = customers[0].ID;
            customer_repo.Delete(firstCustomerId);
            List<Customer> newCustomerList = customer_repo.GetAllCustomers();
            Assert.AreEqual(1, newCustomerList.Count);
            Assert.AreEqual("Arnold", newCustomerList[0].FirstName);
        }

        [TestMethod]
        public void CustomerTestGetById()
        {
            List<Customer> customer = customer_repo.GetAllCustomers();
            int firstCustomerId = customer[0].ID;
            Customer firstCustomer = customer_repo.GetById(firstCustomerId);
            Assert.AreEqual(customer[0], firstCustomer);
        }

        [TestMethod]
        public void CustomerTestAdd()
        {
            int customerCount = customer_repo.GetAllCustomers().Count;
            Customer maxwell = new Customer("1", "Thursday", "Maxwell", "Edison", "1969 Abbey Rd", "Liverpool", "TN", "36543", "6157363456", "edisonm@silverhammer.com", "Majoring in medicine, sneaks up from behind");
            customer_repo.Add(maxwell);
            List<Customer> newCustomerList = customer_repo.GetAllCustomers();
            Assert.AreEqual(3, newCustomerList.Count);
            Assert.AreEqual(maxwell, newCustomerList[2]);
        }

        [TestMethod]
        public void CustomerTestGetCount()
        {
            int customerCount = customer_repo.GetCount();
            Assert.AreEqual(2, customerCount);
        }

        [TestMethod]
        public void CustomerTestEdit()
        {
            Customer grimble = customer_repo.GetAllCustomers()[0];
            grimble.Phone = "615-987-0989";
            customer_repo.Edit(grimble);
            Customer newGrimble = customer_repo.GetAllCustomers()[0];
            Assert.AreEqual("615-987-0989", newGrimble.Phone);
        }
    }
}
