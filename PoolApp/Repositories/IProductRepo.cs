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
        Product Add(Product product);
        Product Edit(Product product);
        Product Delete(int id);
        List<Product> GetAllProducts(int id);
        void Clear();
        int GetCount();
    }
}