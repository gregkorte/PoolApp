using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PoolApp.Models;

namespace PoolApp.Tests.UnitTests
{
    [TestClass]
    public class ServiceModelTests
    {
        [TestMethod]
        public void ServiceConstructorTestSuccess()
        {
            Service service = new Service("1", "Regular Cleaning", 45, "Week");
            Assert.AreEqual("1", service.UserID);
            Assert.AreEqual("Regular Cleaning", service.Name);
            Assert.AreEqual(45, service.Cost);
            Assert.AreEqual("Week", service.WorkUnit);
        }
    }
}
