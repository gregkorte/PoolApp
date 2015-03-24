using PoolApp.Context;
using PoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using PoolApp.Repositories;

namespace PoolApp.Tests.RepositoryTests
{
    public class helperTests
    {
        private static ApplicationDbContext userContext = new ApplicationDbContext();
        private static PoolAppContext context = new PoolAppContext();
        private static CustomerRepo customer_repo = new CustomerRepo("Name=PoolAppTestContext");
        private static ProductRepo product_repo = new ProductRepo("Name=PoolAppTestContext");
        private static ServiceRepo service_repo = new ServiceRepo("Name=PoolAppTestContext");

        public static ApplicationUser firstUser()
        {
            ApplicationUser user = userContext.Users.First();
            return user;
        }

        public static void seedDb()
        {
            var user = userContext.Users.First();
            //ApplicationDbContext userContext = new ApplicationDbContext();
            //PoolAppContext context = new PoolAppContext();

            //ApplicationUser user = userContext.Users.Where(x => x.UserName == "gryph@gmail.com").First();

            var customers = new List<Customer>
            {
                new Customer
                {
                    RouteDay = "Monday",
                    FirstName = "Grimble",
                    LastName = "Crumble",
                    Address = "1967 Gates of Dawn Rd",
                    City = "Piper",
                    State = "TN",
                    Zipcode = "34567",
                    Phone = "615-987-0988",
                    Email = "the_gnome@bigadventure.com",
                    Notes = "He wears a scarlet tunic, a bluegreen hood, it looks quite good."
                },

                new Customer
                {
                    RouteDay = "Tuesday",
                    FirstName = "Arnold",
                    LastName = "Layne",
                    Address = "1965 Moonshine Ln",
                    City = "Washing Line",
                    State = "TN",
                    Zipcode = "32459",
                    Phone = "615-987-6543",
                    Email = "babyblue@distortedview.net",
                    Notes = "Has a strange hobby, collecting clothes..."
                }
            };

            customers.ForEach(c => customer_repo.Add(c));
            context.SaveChanges();

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Chlorine Tabs",
                    Company = "ChemCo",
                    Manufacturer = "ChemCo",
                    ProductNumber = "90888",
                    ManufacturerPartNumber = "90888",
                    UnitOfMeasurement = "tab",
                    Description = "Chlorine tablets",
                    Department = "Chemicals",
                    ProductLine = "Chlorine",
                    Upc = "0394809384093",
                    Cost = 2,
                    ImageUrl = "https://image.poolcorp.com/images/CLU/50/CLU-50-5026_s.jpg"
                },

                new Product
                {
                    Name = "Shock",
                    Company = "Pools & Spas",
                    Manufacturer = "Poolstyle",
                    ProductNumber = "PSL-50-1373",
                    ManufacturerPartNumber = "C002983-CS20P5",
                    UnitOfMeasurement = "bag",
                    Description = "Pool Style 1lb Bag Multi Performance Shock {12/CS}",
                    Department = "Chemicals",
                    ProductLine = "Shock",
                    Upc = "0394809384023",
                    Cost = 23,
                    ImageUrl = "https://image.poolcorp.com/images/PSL/50/PSL-50-1373_s.jpg"
                }
            };

            products.ForEach(p => product_repo.Add(p));
            context.SaveChanges();

            var services = new List<Service>
            {
                new Service
                {
                    Name = "Regular Cleaning",
                    Cost = 45,
                    WorkUnit = "Week"
                },

                new Service
                {
                    Name = "One-Time Cleaning",
                    Cost = 55,
                    WorkUnit = "Per"
                }
            };

            services.ForEach(s => service_repo.Add(s));
            context.SaveChanges();
        }

        public static void ClearDB()
        {
            customer_repo.Clear();
            product_repo.Clear();
            service_repo.Clear();
        }
    }
}
