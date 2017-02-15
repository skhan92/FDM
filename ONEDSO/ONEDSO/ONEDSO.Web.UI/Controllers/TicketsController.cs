using ONEDSO.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.UI.Controllers
{
    public class TicketsController : Controller
    {
        EFramework db = new EFramework();
        //Get tickets
        public ActionResult Index()
        {
            return View("Index", db.product.ToList());
        }
    }
}