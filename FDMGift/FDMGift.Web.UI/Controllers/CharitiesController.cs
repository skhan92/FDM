using FDMGift.EntityFramework;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace WebUI.Controllers
{
    public class CharitiesController : Controller
    {
        private static readonly ILog logger = LogManager.GetLogger("CharitiesController.cs");

        EFramework db = new EFramework();
        // GET: Charities
        public ActionResult Index()
        {
            logger.Info("List has not been returned - no database connection");
            return View("Index", db.charities.ToList());
        }

        //[HttpGet]
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult addCharity(Charities CharitiesToAdd)
        //{
        //    CharitiesRepository cr = new CharitiesRepository();
        //    addCharity = cr.addCharities(Charities CharitiesToAdd);

        //    if (Request.IsAjaxRequest())
        //    {
        //        return PartialView("_success");
        //    }
        //    else
        //    {
        //        return RedirectToAction("Index");
        //    }
        //}
    }
}