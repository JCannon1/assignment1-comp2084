using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JesseCannon_Assignment1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your teams list page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your players list page.";

            return View();
        }
    }
}