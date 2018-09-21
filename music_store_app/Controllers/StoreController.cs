﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace music_store_app.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            return View();
        }
        
        // GET: Store/Product/Product-Name
        public ActionResult Product(string ProductName)
        {
            ViewBag.Product = ProductName;
            return View();
        }
    }
}