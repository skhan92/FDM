using FDMGift.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class CharitiesController : Controller
    {
        EFramework db = new EFramework();
        // GET: Charities
        public ActionResult Index()
        {
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