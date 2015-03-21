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
    }

    //------------//
    //  CUSTOMER  //
    //------------//
    //GET: /api/Customers/
}
