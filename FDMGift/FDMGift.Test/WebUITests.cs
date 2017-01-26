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
    }
}