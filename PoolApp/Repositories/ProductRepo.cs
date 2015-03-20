using PoolApp.Context;
using PoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PoolApp.Repositories
{
    public class ProductRepo : IProductRepo
    {
        private PoolAppContext _dbContext;

        public ProductRepo(string connection = "PoolAppContext")
        {
            _dbContext = new PoolAppContext(connection);
        }
        public Product GetById(int id)
        {
            return _dbContext.Products.Where(p => p.ID == id).First<Product>();
        }

        public void Add(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var products = _dbContext.Products.Where(p => p.ID == id);
            _dbContext.Products.RemoveRange(products);
            _dbContext.SaveChanges();
        }

        public void Edit(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            return _dbContext.Products.ToList();
        }

        public void Clear()
        {
            var products = this.GetAllProducts();
            _dbContext.Products.RemoveRange(products);
            _dbContext.SaveChanges();
        }

        public int GetCount()
        {
            return _dbContext.Products.Count<Product>();
        }
    }
}