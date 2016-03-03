using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web1.Models;
namespace Web1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Books()
        {
            var books = BooksFactory.CreateBooks();
            return View(books);
        }
        public ActionResult Mydog()
        {
            return View();
        }
    }
}