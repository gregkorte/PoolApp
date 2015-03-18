using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PoolApp.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Manufacturer { get; set; }
        public string ProductNumber { get; set; }
        public string ManufacturerPartNumber { get; set; }
        public string UnitOfMeasurement { get; set; }
        public string Description { get; set; }
        public string Department { get; set; }
        public string ProductLine { get; set; }
        public string Upc { get; set; }
        public decimal Cost { get; set; }
        public string ImageUrl { get; set; }

        public virtual Invoice Invoices { get; set; }

        public Product(string name, string company, string manufacturer, string productNumber, string manufacturerPartNumber, string unitOfMeasurement, string description, string department, string productLine, string upc, decimal cost, string imageUrl)
        {
            this.Name = name;
            this.Company = company;
            this.Manufacturer = manufacturer;
            this.ProductNumber = productNumber;
            this.ManufacturerPartNumber = manufacturerPartNumber;
            this.UnitOfMeasurement = unitOfMeasurement;
            this.Description = description;
            this.Department = department;
            this.ProductLine = productLine;
            this.Upc = upc;
            this.Cost = cost;
            this.ImageUrl = imageUrl;
        }

        public Product()
        {

        }
    }
}