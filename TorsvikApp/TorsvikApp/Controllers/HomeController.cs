﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TorsvikApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult MainContent(string cont)
        {
            if (cont.Equals("about"))
            {
                return PartialView("_About");
            }
            else
            {
                return PartialView("_CV");
            }
        }
    }
}