using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASPAdvancedDemo.Controllers;
using System.Web.Mvc;
using System.Web;
using Moq;
using ASPAdvancedDemo.Models;

namespace ASPAdvancedDemo.Tests
{
    [TestClass]
    public class BooksTests
    {
        [TestMethod]
        public void Test_Index_ReturnsIndexView()
        {
            //Arrange
            string expected = "Index";
            BooksController classUnderTest = new BooksController();

            //Act
            var actual = classUnderTest.Index() as ViewResult;

            //Assert
            Assert.AreEqual(expected, actual.ViewName);

            //REDIRECT TO ACTION
            //var actual = classUnderTest.Index() as RedirectToRouteResult;
            //Assert.AreEqual("Index", actual.RouteValues["action"]);

            //PARTIAL VIEW
            //var actual = classUnderTest.Index() as PartialViewResult;
            //Assert.AreEqual("Index, name of view..", actual.Viewname);
        }

        [TestMethod]
        public void Test_Create_ReturnsSuccessPartialView_WhenRequestIsAjax()
        {
            //Arrange
            var mockRequest = new Mock<HttpRequestBase>();
            mockRequest.Setup(x => x ["X-Requested-With"]).Returns("XMLHttpRequest"); //think its ajax and make a http request

            var mockHttpContext = new Mock<HttpContextBase>();
            mockHttpContext.SetupGet(x => x.Request).Returns(mockRequest.Object);  //give it a context

            var controllerContext = new ControllerContext();
            controllerContext.HttpContext = mockHttpContext.Object; //put that inside a controller context

            BooksController classUnderTest = new BooksController();
            classUnderTest.ControllerContext = controllerContext;  //put that in a controller

            //Above is wrapping it all up to make it think its ajax

            Mock<Book> mockBook = new Mock<Book>();

            //Need to mock DB, that's why its failing XD

            //Act
            var actual = classUnderTest.Create() as PartialViewResult;

            //Assert
            Assert.AreEqual("_success", actual.ViewName);

        }
    }
}
