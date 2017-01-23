//using FDMGift.EntityFramework;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace FDMGift.Web.UI.Controllers
//{
//    public class UserDashController : Controller
//    {
//        EFramework db = new EFramework();

//        [HttpGet]
//        public ActionResult UpdateDetails()
//        {
//            return View();
//        }

//        [HttpPost]
//        public ActionResult UpdateDetails(string email, string fullName, string password)
//        {
//            string WhatToChange = "fullName";
//            string WhatToChange1 = "password";

//            UserRepository ur = new UserRepository(db);

//            if (Request.IsAjaxRequest())
//            {
//                ur.updateUser(email, WhatToChange, fullName);
//                ur.updateUser(email, WhatToChange1, password);
//                return PartialView("_success");
//            }
//            return PartialView("_unsuccessful");
//        }
//    }
//}