using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PoolApp.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public string RouteDay { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }

        public Customer(string userId, string routeDay, string firstName, string lastName, string address, string city, string state, string zipcode, string phone, string email, string notes)
        {
            this.UserID = userId;
            this.RouteDay = routeDay;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address =address;
            this.City = city;
            this.State = state;
            this.Zipcode = zipcode;
            this.Phone = phone;
            this.Email = email;
            this.Notes = notes;
        }

        public Customer()
        {

        }
    }
}