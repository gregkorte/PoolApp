﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace PoolApp.Controllers
{
    public class AppController : Controller
    {
        // GET: Angular
        [Authorize]
        public ActionResult Index()
        {
            ViewBag.UserId = User.Identity.GetUserId();
            return View();
        }
    }
}