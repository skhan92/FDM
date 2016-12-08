using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Mocking.BookShop;

namespace Mocking.Tests
{
    [TestClass]
    public class StockCheckerTests
    {
        [TestMethod]
        public void TestNumberInStock_CallsTheReadQuantityMethodOfOurDatabaseReader_WhenCalled()
        {
            //Arrange
            Mock<IDatabaseReader> mockDatabaseReader = new Mock<IDatabaseReader>();
            string isbn = "ABC123"; //string isbn for act
            StockChecker stockChecker = new StockChecker(mockDatabaseReader.Object); //Object
            
            //Act
            stockChecker.NumberInStock(isbn); //Method

            //Assert
            //Not interested in what this test returns, just that it behaves in the way we want. Want to verify the database reader had its read method quanitity called
            mockDatabaseReader.Verify(r => r.ReadQuantity(It.IsAny<string>()), Times.Once);

        }

        [TestMethod]
        public void TestNumberInStock_EnsureStock_IsGivingCorrectisbn_ToReadQuantity()
        {
            //Arrange
            Mock<IDatabaseReader> mockDatabaseReader = new Mock<IDatabaseReader>();
            string isbn = "ABC123"; //string isbn for act

            StockChecker stockChecker = new StockChecker(mockDatabaseReader.Object); //Object

            //Act
            stockChecker.NumberInStock(isbn); //Method

            //Assert
            //Not interested in what this test returns, just that it behaves in the way we want. Want to verify the database reader had its read method quanitity called
            mockDatabaseReader.Verify(r => r.ReadQuantity(isbn), Times.Once);

        }

        [TestMethod]
        public void Test_NumberInStock_returns3WhenThereAre3MatchingBooksInTheDatabase()
        {
            //Arrange
            string isbn = "ABC123";
            int expected = 3;
            Mock<IDatabaseReader> mockDatabaseReader = new Mock<IDatabaseReader>();
            mockDatabaseReader.Setup(r => r.ReadQuantity(isbn)).Returns(3); //this is called stubbing

            StockChecker stockChecker = new StockChecker(mockDatabaseReader.Object);

            //Act
            int actual = stockChecker.NumberInStock(isbn);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
