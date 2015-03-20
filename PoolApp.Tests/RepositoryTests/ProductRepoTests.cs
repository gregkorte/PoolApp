using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PoolApp.Repositories;
using PoolApp.Models;
using System.Collections.Generic;

namespace PoolApp.Tests.RepositoryTests
{
    [TestClass]
    public class ProductRepoTests
    {
        private static ProductRepo product_repo = new ProductRepo("Name=PoolAppTestContext");
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
            product_repo.Clear();
        }

        [ClassCleanup]
        public static void CleanUp()
        {
            helperTests.ClearDB();
        }

        [TestMethod]
        public void ProductTestGetAllProducts()
        {
            var allProducts = product_repo.GetAllProducts();
            Assert.AreEqual(2, allProducts.Count);
        }

        [TestMethod]
        public void ProductTestClear()
        {
            List<Product> Products = product_repo.GetAllProducts();
            int preCount = product_repo.GetCount();
            Assert.AreEqual(2, preCount);
            product_repo.Clear();
            int postCount = product_repo.GetCount();
            Assert.AreEqual(0, postCount);
        }

        [TestMethod]
        public void ProductTestDelete()
        {
            List<Product> Products = product_repo.GetAllProducts();
            Assert.AreEqual(2, Products.Count);
            var firstProductId = Products[0].ID;
            product_repo.Delete(firstProductId);
            List<Product> newProductList = product_repo.GetAllProducts();
            Assert.AreEqual(1, newProductList.Count);
            Assert.AreEqual("Shock", newProductList[0].Name);
        }

        [TestMethod]
        public void ProductTestGetById()
        {
            List<Product> Product = product_repo.GetAllProducts();
            int firstProductId = Product[0].ID;
            Product firstProduct = product_repo.GetById(firstProductId);
            Assert.AreEqual(Product[0], firstProduct);
        }

        [TestMethod]
        public void ProductTestAdd()
        {
            int ProductCount = product_repo.GetAllProducts().Count;
            Product chlorineTabs = new Product("Chlorine Tabs", "ChemCo", "ChemCo", "90888", "90888", "tab", "Chlorine tablets", "Chemicals", "Chlorine", "0394809384093", 2, "https://image.poolcorp.com/images/CLU/50/CLU-50-5026_s.jpg");
            product_repo.Add(chlorineTabs);
            List<Product> newProductList = product_repo.GetAllProducts();
            Assert.AreEqual(3, newProductList.Count);
            Assert.AreEqual(chlorineTabs, newProductList[2]);
        }

        [TestMethod]
        public void ProductTestGetCount()
        {
            int ProductCount = product_repo.GetCount();
            Assert.AreEqual(2, ProductCount);
        }

        [TestMethod]
        public void ProductTestEdit()
        {
            Product chlorine = product_repo.GetAllProducts()[0];
            chlorine.Upc = "0394809384094";
            product_repo.Edit(chlorine);
            Product newProduct = product_repo.GetAllProducts()[0];
            Assert.AreEqual("0394809384094", newProduct.Upc);
        }
    }
}
