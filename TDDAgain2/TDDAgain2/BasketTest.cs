using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store;
using System.Collections.Generic;

namespace TDDAgain2
{
    [TestClass]
    public class BasketTest
    {
        [TestMethod]
        public void test_GetBooksInBasket_ReturnsEmptyBookList_IfNoBooksHaveBeenAdded()
        {
            //Arrange
            Basket myBasket = new Basket();
            Book myBook = new Book();

            //Act
            List<Book> myList = myBasket.getBooksInBasket();

            //Assert
            Assert.AreEqual(0, myList.Count);

        }

        [TestMethod]
        public void test_AddBook_ReturnsArrayOfLengthOne_AfterAddBookMethodIsCalledWithOneBook()
        {
            //Arrange
            Basket myBasket = new Basket();
            Book myBook = new Book();

            //Act
            myBasket.addBook(myBook);
            
            //Assert
            List<Book> myList = myBasket.getBooksInBasket();
            Assert.AreEqual(1, myList.Count);

        }
    }
}
