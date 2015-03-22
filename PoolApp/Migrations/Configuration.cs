namespace PoolApp.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using PoolApp.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PoolApp.Context.PoolAppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        private void AddUser(ApplicationDbContext context)
        {
            if (!(context.Users.Any(u => u.UserName == "gryph@gmail.com")))
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userHandler = new UserManager<ApplicationUser>(userStore);
                var userInsert = new ApplicationUser
                {
                    UserName = "gryph@gmail.com",
                    PhoneNumber = "6156457837"
                };

                userHandler.Create(userInsert, "password");
            }
            context.SaveChanges();
        }

        protected override void Seed(PoolApp.Context.PoolAppContext context)
        {

            ApplicationDbContext userContext = new ApplicationDbContext();

            AddUser(userContext);

            ApplicationUser user = userContext.Users.Where(x => x.UserName == "gryph@gmail.com").First();

            var customers = new List<Customer>
            {
                new Customer
                {
                    UserID = user.Id,
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
                    UserID = user.Id,
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

            customers.ForEach(sd => context.Customers.AddOrUpdate(c => c.Phone, sd));
            context.SaveChanges();

            var products = new List<Product>
            {
                new Product
                {
                    UserID = user.Id,
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
                    UserID = user.Id,
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

            products.ForEach(sd => context.Products.AddOrUpdate(p => p.Upc, sd));
            context.SaveChanges();

            var services = new List<Service>
            {
                new Service
                {
                    UserID = user.Id,
                    Name = "Regular Cleaning",
                    Cost = 45,
                    WorkUnit = "Week"
                },

                new Service
                {
                    UserID = user.Id,
                    Name = "One-Time Cleaning",
                    Cost = 55,
                    WorkUnit = "Per"
                }
            };

                services.ForEach(sd => context.Services.AddOrUpdate(s => s.Name, sd));
                context.SaveChanges();
        }
    }
}
