using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web1.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Mydog()
        {
            return View();
        }
        public ActionResult Memesu()
        {
            return View();
        }
        public ActionResult Bike()
        {
            return View();
        }
    }
}