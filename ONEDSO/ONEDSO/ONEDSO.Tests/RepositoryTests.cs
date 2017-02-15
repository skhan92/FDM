using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ONEDSO.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONEDSO.Tests
{
    [TestClass]
    public class RepositoryTests
    {
        //PRODUCT REPOSITORY
        [TestMethod]
        public void Test_GetAllProducts_ReturnsAllProducts()
        {
            //Arrange
            var expected = new List<Product>
            {
                new Product { productid = 1, productName = "A vs B", price = 20},
                new Product { productid = 2, productName = "C vs D", price = 30},
                new Product { productid = 3, productName = "E vs F", price = 40}
            };

            var testData = new List<Product>
            {
                new Product { productid = 1, productName = "A vs B", price = 20},
                new Product { productid = 2, productName = "C vs D", price = 30},
                new Product { productid = 3, productName = "E vs F", price = 40}
            }.AsQueryable();

            var dbSetMock = new Mock<DbSet<Product>>();
            dbSetMock.As<IQueryable<Product>>().Setup(d => d.Provider).Returns(testData.Provider);
            dbSetMock.As<IQueryable<Product>>().Setup(d => d.Expression).Returns(testData.Expression);
            dbSetMock.As<IQueryable<Product>>().Setup(d => d.ElementType).Returns(testData.ElementType);
            dbSetMock.As<IQueryable<Product>>().Setup(d => d.GetEnumerator()).Returns(testData.GetEnumerator());

            Mock<EFramework> contextMock = new Mock<EFramework>();
            contextMock.Setup(c => c.product).Returns(dbSetMock.Object);

            ProductRepository classUnderTest = new ProductRepository(contextMock.Object);

            //Act
            var actual = classUnderTest.GetAllProducts();

            //Assert
            Assert.AreEqual(expected[0].productid, actual[0].productid);
            Assert.AreEqual(expected[1].productid, actual[1].productid);
            Assert.AreEqual(expected[2].productid, actual[2].productid);
        }

        //BASKET REPOSITORY
        //[TestMethod]
        //public void Test_AddProduct_CallsAddOnDbSetAndSaveChangesOnContext()
        //{
        //    Mock<Basket> productsToAdd = new Mock<Basket>();

        //   // Arrange
        //    var mockDbSet = new Mock<DbSet<Basket>>();
        //    var mockContext = new Mock<EFramework>();

        //    mockContext.Setup(p => p.basket).Returns(mockDbSet.Object);

        //    var classUnderTest = new BasketRepository(mockContext.Object);

        //    //Act
        //    classUnderTest.AddProduct(products.Object);

        //    Assert
        //    mockDbSet.Verify(p => p.Add(products.Object), Times.Once);
        //    mockContext.Verify(p => p.SaveChanges(), Times.Once);
        //}
    }



}
