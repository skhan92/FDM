using FDMGift.EntityFramework;
using FDMGift.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace WebUI.Controllers
{
    //NEED TO MAKE ADMIN AND USER LOGIN WORK TOGETHER!
    public class AccountController : Controller
    {
        EFramework db = new EFramework();

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Users userToAdd)
        {
            UserLogic ulogic = new UserLogic(db);
            if (ulogic.RegisterUser(userToAdd) == true)
            {
                if (Request.IsAjaxRequest())
                {
                    return PartialView("_unsuccessful");
                }
            }
            return PartialView("_success");
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Users checkUser, string returnUrl)
        {
            UserRepository ur = new UserRepository(db);
            if (ModelState.IsValid)
            {
                UserLogic ul = new UserLogic(db);
                string email = checkUser.email;
                string password = checkUser.password;

                if (ur.checkUserDetails(checkUser.email, checkUser.password) == true)
                {
                    FormsAuthentication.SetAuthCookie(email, false);
                    if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                        && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    if (Request.IsAjaxRequest())
                    {
                        return JavaScript("window.location = '" + Url.Action("UserDashboard", "Account") + "'");
                        return JavaScript("location.reload(true)");
                        UserDashboard();
                    }
                    return PartialView("_unsuccessful");
                }
            }
            return View(checkUser);
        }

        public ActionResult UserDashboard()
        {
            return View();
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Home");
        }

        //[HttpPost]
        //public ActionResult Login(Admins checkAdmin)
        //{
        //    AdminRepository ur = new AdminRepository(db);

        //    if (ur.checkAdminDetails(checkAdmin.email, checkAdmin.password) == true)
        //    {
        //        if (Request.IsAjaxRequest())
        //        {
        //            return JavaScript("window.location = '" + Url.Action("AdminDashboard", "Account") + "'");
        //            return JavaScript("location.reload(true)");
        //            AdminDashboard();
        //        }
        //    }
        //    return PartialView("_unsuccessful");
        //}

        //public ActionResult AdminDashboard()
        //{
        //    return View();
        //}
    }
}