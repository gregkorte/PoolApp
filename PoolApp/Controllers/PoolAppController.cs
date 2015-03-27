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
        private ProductRepo product_repo = new ProductRepo();
        private ServiceRepo service_repo = new ServiceRepo();

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
        [Route("Customers/{userID}/edit/{id}")]
        public HttpResponseMessage EditCustomer([FromBody] Customer customer)
        {
            customer_repo.Edit(customer);
            return new HttpResponseMessage(HttpStatusCode.OK)
;
        }

        [HttpDelete]
        [Route("Customers/{userID}/delete/{id}")]
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

        //------------//
        //  PRODUCTS  //
        //------------//
        //GET: /api/PoolApp/Products/userID
        [HttpGet]
        [Route("Products/{userID}")]
        public System.Web.Mvc.JsonResult GetProducts(string userID)
        {
            //return product_repo.GetAllByUserId(UserID);
            var products = product_repo.GetAllByUserId(userID);
            var json = new System.Web.Mvc.JsonResult();
            json.Data = new
            {
                products
            };
            return json;
        }

        [HttpPost]
        [Route("Products/{userID}")]
        public HttpResponseMessage Products(string userID, [FromBody] Product product)
        {
            product_repo.Add(product);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpPut]
        [Route("Products/{userID}/edit/{id}")]
        public HttpResponseMessage EditProduct([FromBody] Product product)
        {
            product_repo.Edit(product);
            return new HttpResponseMessage(HttpStatusCode.OK)
;
        }

        [HttpDelete]
        [Route("Products/{userID}/delete/{id}")]
        public HttpResponseMessage DeleteProduct(int id)
        {
            product_repo.Delete(id);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        //GET: /api/PoolApp/Products/userID/id
        [HttpGet]
        [Route("Products/{userID}/{id}")]
        public System.Web.Mvc.JsonResult GetProducts(int id)
        {
            var product = product_repo.GetById(id);
            var json = new System.Web.Mvc.JsonResult();
            json.Data = new
            {
                product
            };
            return json;
        }

        //------------//
        //  SERVICES  //
        //------------//
        //GET: /api/PoolApp/Services/userID
        [HttpGet]
        [Route("Services/{userID}")]
        public System.Web.Mvc.JsonResult GetServices(string userID)
        {
            //return service_repo.GetAllByUserId(UserID);
            var services = service_repo.GetAllByUserId(userID);
            var json = new System.Web.Mvc.JsonResult();
            json.Data = new
            {
                services
            };
            return json;
        }

        [HttpPost]
        [Route("Services/{userID}")]
        public HttpResponseMessage Services(string userID, [FromBody] Service service)
        {
            service_repo.Add(service);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpPut]
        [Route("Services/{userID}/edit/{id}")]
        public HttpResponseMessage EditService([FromBody] Service service)
        {
            service_repo.Edit(service);
            return new HttpResponseMessage(HttpStatusCode.OK)
;
        }

        [HttpDelete]
        [Route("Services/{userID}/delete/{id}")]
        public HttpResponseMessage DeleteService(int id)
        {
            service_repo.Delete(id);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        //GET: /api/PoolApp/Services/userID/id
        [HttpGet]
        [Route("Services/{userID}/{id}")]
        public System.Web.Mvc.JsonResult GetServices(int id)
        {
            var service = service_repo.GetById(id);
            var json = new System.Web.Mvc.JsonResult();
            json.Data = new
            {
                service
            };
            return json;
        }
    }
}
