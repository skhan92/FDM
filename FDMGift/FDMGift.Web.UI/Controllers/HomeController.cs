using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Application description page.";

            return View("About");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Application contact page.";

            return View("Contact");
        }
    }
}