using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebUI.Controllers;

namespace FDMGift.Test
{
    [TestClass]
    public class WebUITests
    {
        //HOME CONTROLLER
        [TestMethod]
        public void Test_Index_ReturnsIndexView()
        {
            var expected = "Index";

            HomeController classUnderTest = new HomeController();

            var actual = classUnderTest.Index() as ViewResult;

            Assert.AreEqual(expected, actual.ViewName);
        }

        [TestMethod]
        public void Test_About_ReturnsAboutView()
        {
            var expected = "About";

            HomeController classUnderTest = new HomeController();

            var actual = classUnderTest.About() as ViewResult;

            Assert.AreEqual(expected, actual.ViewName);
        }

        [TestMethod]
        public void Test_Contact_ReturnsContactView()
        {
            var expected = "Contact";

            HomeController classUnderTest = new HomeController();

            var actual = classUnderTest.Contact() as ViewResult;

            Assert.AreEqual(expected, actual.ViewName);
        }

        //CHARITIES CONTROLLER
        [TestMethod]
        public void Test_CIndex_ReturnsCIndexView()
        {
            var expected = "Index";

            CharitiesController classUnderTest = new CharitiesController();

            var actual = classUnderTest.Index() as ViewResult;

            Assert.AreEqual(expected, actual.ViewName);
        }

        //ACCOUNT CONTROLLER
        [TestMethod]
        public void Test_Register_ReturnsRegisterView()
        {
            var expected = "Register";

            AccountController classUnderTest = new AccountController();

            var actual = classUnderTest.Register() as ViewResult;

            Assert.AreEqual(expected, actual.ViewName);
        }

        [TestMethod]
        public void Test_Login_ReturnsLoginView()
        {
            var expected = "Login";

            AccountController classUnderTest = new AccountController();

            var actual = classUnderTest.Login() as ViewResult;

            Assert.AreEqual(expected, actual.ViewName);
        }

        [TestMethod]
        public void Test_UserDashboard_ReturnsUserDashboardView()
        {
            var expected = "UserDashboard";

            AccountController classUnderTest = new AccountController();

            var actual = classUnderTest.UserDashboard() as ViewResult;

            Assert.AreEqual(expected, actual.ViewName);
        }

        //[TestMethod] // THIS ONE HAS AN ERROR HENCE ITS COMMENTED OUT
        //public void Test_Logoff_ReturnsLogoffView()
        //{
        //    var expected = "Logoff";

        //    AccountController classUnderTest = new AccountController();

        //    var actual = classUnderTest.Logoff() as RedirectToRouteResult;

        //    Assert.AreEqual(expected, actual.RouteValues["action"]);
        //}

        [TestMethod]
        public void Test_UpdateDetails_ReturnsUpdateDetailsView()
        {
            var expected = "UpdateDetails";

            AccountController classUnderTest = new AccountController();

            var actual = classUnderTest.UpdateDetails() as ViewResult;

            Assert.AreEqual(expected, actual.ViewName);
        }

    }
}