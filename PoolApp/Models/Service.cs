using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PoolApp.Models
{
    public class Service
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public string WorkUnit { get; set; }

        public virtual Invoice Invoices { get; set; }

        public Service(string name, decimal cost, string workUnit)
        {
            this.Name = name;
            this.Cost = cost;
            this.WorkUnit = workUnit;
        }

        public Service()
        {

        }
    }
}