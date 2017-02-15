using Microsoft.VisualStudio.TestTools.UnitTesting;
using ONEDSO.Web.UI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Web.UI.Controllers;

namespace ONEDSO.Tests
{
    [TestClass]
    public class WebUITests
    {
        //Tickets Controller
        [TestMethod]
        public void Test_Index_ReturnsIndexView()
        {
            var expected = "Index";

            TicketsController classUnderTest = new TicketsController();

            var actual = classUnderTest.Index() as ViewResult;

            Assert.AreEqual(expected, actual.ViewName);
        }

        //Home Controller
        [TestMethod]
        public void Test_HomeIndex_ReturnsHomeIndexView()
        {
            var expected = "Index";

            HomeController classUnderTest = new HomeController();

            var actual = classUnderTest.Index() as ViewResult;

            Assert.AreEqual(expected, actual.ViewName);
        }
    }
}
