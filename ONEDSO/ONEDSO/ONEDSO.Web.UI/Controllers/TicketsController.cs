using log4net;
using ONEDSO.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace Web.UI.Controllers
{
    public class TicketsController : Controller
    {
        private static readonly ILog logger = LogManager.GetLogger("TicketsController.cs");

        EFramework db = new EFramework();
        //Get tickets
        public ActionResult Index()
        {
            logger.Info("Tickets List has been returned");
            return View("Index", db.product.ToList());
        }
    }
}