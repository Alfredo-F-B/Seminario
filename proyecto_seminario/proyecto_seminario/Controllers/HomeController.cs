﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proyecto_seminario.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Pagina de inicio!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
