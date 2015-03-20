using PoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PoolApp.Repositories
{
    interface IProductRepo
    {
        Product GetById(int id);
        void Add(Product product);
        void Edit(Product product);
        void Delete(int id);
        void Clear();
        int GetCount();
        List<Product> GetAllProducts();
    }
}