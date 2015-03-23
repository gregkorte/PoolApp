using PoolApp.Models;
using PoolApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PoolApp.Controllers
{
    [RoutePrefix("api/PoolApp")]
    public class PoolAppController : ApiController
    {
        private CustomerRepo customer_repo = new CustomerRepo();

        //------------//
        //  CUSTOMER  //
        //------------//
        //GET: /api/PoolApp/Customers/userID
        [HttpGet]
        [Route("Customers/{userID}")]
        public System.Web.Mvc.JsonResult GetCustomers(string userID)
        {
            //return customer_repo.GetAllByUserId(UserID);
            var customers = customer_repo.GetAllByUserId(userID);
            var json = new System.Web.Mvc.JsonResult();
            json.Data = new
            {
                customers
            };
            return json;
        }

        [HttpPost]
        [Route("Customers/{userID}")]
        public HttpResponseMessage Customers(string userID, [FromBody] Customer customer)
        {
            customer_repo.Add(customer);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpPut]
        [Route("Customers/{userID}/Edit/{id}")]
        public HttpResponseMessage EditCustomer([FromBody] Customer customer)
        {
            customer_repo.Edit(customer);
            return new HttpResponseMessage(HttpStatusCode.OK)
;
        }

        [HttpDelete]
        [Route("Customers/{userID}/Delete/{id}")]
        public HttpResponseMessage DeleteCustomer(int id)
        {
            customer_repo.Delete(id);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        //GET: /api/PoolApp/Customers/userID/id
        [HttpGet]
        [Route("Customers/{userID}/{id}")]
        public System.Web.Mvc.JsonResult GetCustomers(int id)
        {
            var customer = customer_repo.GetById(id);
            var json = new System.Web.Mvc.JsonResult();
            json.Data = new
            {
                customer
            };
            return json;
        }
    }
}
