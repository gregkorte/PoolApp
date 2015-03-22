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
        void Add(Customer customer);
        void Edit(Customer customer);
        void Delete(int id);
        void Clear();
        int GetCount();
        //List<Customer> GetAllCustomers();
        List<Customer> GetAllByUserId(string userID);
    }
}