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

        public ProductRepo(string connection = "PoolAppDBContext")
        {
            _dbContext = new PoolAppContext(connection);
        }
        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Product Add(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product Edit(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts(int id)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public int GetCount()
        {
            throw new NotImplementedException();
        }
    }
}