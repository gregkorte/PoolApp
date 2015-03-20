﻿using PoolApp.Context;
using PoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PoolApp.Repositories
{
    public class CustomerRepo : ICustomerRepo
    {
        private PoolAppContext _dbContext;

        public CustomerRepo(string connection = "PoolAppContext")
        {
            _dbContext = new PoolAppContext(connection);
        }

        public Customer GetById(int id)
        {
            return _dbContext.Customers.Where(c => c.ID == id).First<Customer>();
        }

        public void Add(Customer customer)
        {
            _dbContext.Customers.Add(customer);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var customers = _dbContext.Customers.Where(c => c.ID == id);
            _dbContext.Customers.RemoveRange(customers);
            _dbContext.SaveChanges();
        }

        public void Edit(Customer customer)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllCustomers()
        {
            return _dbContext.Customers.ToList();
        }

        public void Clear()
        {
            var customers = this.GetAllCustomers();
            _dbContext.Customers.RemoveRange(customers);
            _dbContext.SaveChanges();
        }

        public int GetCount()
        {
            return _dbContext.Customers.Count<Customer>();
        }
    }
}