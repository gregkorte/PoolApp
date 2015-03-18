using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PoolApp.Models;

namespace PoolApp.Tests.UnitTests
{
    [TestClass]
    public class ServiceModelTests
    {
        [TestClass]
        public class ServiceModelTest
        {
            [TestMethod]
            public void ServiceConstructorTestSuccess()
            {
                Service service = new Service("Regular Cleaning", 45, "Week");
                Assert.AreEqual("Regular Cleaning", service.Name);
                Assert.AreEqual(45, service.Cost);
                Assert.AreEqual("Week", service.WorkUnit);
            }
        }
    }
}
