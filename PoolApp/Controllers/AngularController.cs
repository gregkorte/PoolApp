using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PoolApp.Controllers
{
    public class AngularController : Controller
    {
        // GET: Angular
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}