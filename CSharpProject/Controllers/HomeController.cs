using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharpProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Browse()
        {
            ViewBag.Message = "Browse the Daylily Database.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Please feel free to contact me.  The Daylily site is still a work in progress, and your insight would be beneficial.";

            return View();
        }

        public ActionResult AddDaylily()
        {
            ViewBag.Message = "Add a Daylily";

            return View();
        }

    }
}