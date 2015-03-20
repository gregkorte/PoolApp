using PoolApp.Context;
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
            var q = _dbContext.Customers.Where(c => c.ID == customer.ID);
            foreach (Customer dbCustomer in q)
            {
                dbCustomer.RouteDay = customer.RouteDay;
                dbCustomer.FirstName = customer.FirstName;
                dbCustomer.LastName = customer.LastName;
                dbCustomer.Address = customer.Address;
                dbCustomer.City = customer.City;
                dbCustomer.State = customer.State;
                dbCustomer.Zipcode = customer.Zipcode;
                dbCustomer.Phone = customer.Phone;
                dbCustomer.Email = customer.Email;
                dbCustomer.Notes = customer.Notes;
            }

            _dbContext.SaveChanges();
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