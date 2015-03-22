using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PoolApp.Models;

namespace PoolApp.Tests.UnitTests
{
    [TestClass]
    public class CustomerModelTest
    {
        [TestMethod]
        public void CustomerConstructorTestSuccess()
        {
            Customer customer = new Customer("1", "Monday", "Maxwell", "Edison", "1969 Abbey Rd", "Liverpool", "TN", "37685", "615-809-0987", "edisonm@silverhammer.com", "Majoring in medicine, sneaks up from behind.");
            Assert.AreEqual("1", customer.UserID);
            Assert.AreEqual("Monday", customer.RouteDay);
            Assert.AreEqual("Maxwell", customer.FirstName);
            Assert.AreEqual("Edison", customer.LastName);
            Assert.AreEqual("1969 Abbey Rd", customer.Address);
            Assert.AreEqual("Liverpool", customer.City);
            Assert.AreEqual("TN", customer.State);
            Assert.AreEqual("37685", customer.Zipcode);
            Assert.AreEqual("615-809-0987", customer.Phone);
            Assert.AreEqual("edisonm@silverhammer.com", customer.Email);
            Assert.AreEqual("Majoring in medicine, sneaks up from behind.", customer.Notes);
        }
    }
}
