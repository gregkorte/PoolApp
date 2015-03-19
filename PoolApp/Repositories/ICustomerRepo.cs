using PoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PoolApp.Repositories
{
    interface ICustomerRepo
    {
        Customer GetById(int id);
        Customer Add(Customer product);
        Customer Edit(Customer product);
        Customer Delete(int id);
        List<Customer> GetAllCustomers(int id);
        void Clear();
        int GetCount();
    }
}