using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store;

namespace TDDAgain2
{
    [TestClass]
    public class CheckoutTest
    {
        Basket myBasket;
        Checkout myCheckout;
        Book myBook;

        [TestInitialize]
        public void Setup()
        {
            myBasket = new Basket();
            myCheckout = new Checkout();
            myBook = new Book();
        }

        [TestMethod]
        public void test_CalculatePrice_ReturnsZeroWhenPassedAnEmptyBasket()
        {
            //Arrange


            //Act
            double cost = myCheckout.calculatePrice(myBasket);

            //Assert
            Assert.AreEqual(0.0, cost);
        }

        [TestMethod]
        public void test_CalculatePrice_ReturnsPriceOfBookInBasket_WhenPassedBasketWithOneBook()
        {
            //Arrange

            myBook.price = 10;

            //Act
            myBasket.addBook(myBook);
            double cost = myCheckout.calculatePrice(myBasket);

            //Assert
            Assert.AreEqual(10.0, cost);
        }

        [TestMethod]
        public void test_CalculatePrice_ReturnsPriceOfTwoBookInBasket_WhenPassedBasketWithTwoBook()
        {
            //Arrange

            myBook.price = 10;

            //Act
            myBasket.addBook(myBook);
            myBasket.addBook(myBook);
            double cost = myCheckout.calculatePrice(myBasket);

            //Assert
            Assert.AreEqual(20.0, cost);
        }

        [TestMethod]
        public void test_CalculatePrice_ReturnsPriceOf3BookInBasket_WhenPassedBasketWith3Book()
        {
            //Arrange

            myBook.price = 10;

            //Act
            myBasket.addBook(myBook);
            myBasket.addBook(myBook);
            myBasket.addBook(myBook);

            double cost = myCheckout.calculatePrice(myBasket);

            //Assert
            Assert.AreEqual(29.7, cost);
        }
    }
}
