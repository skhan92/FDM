using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDBookShop;

namespace TDDBookShopTests
{
    [TestClass]
    public class CatalogueTests
    {
        Catalogue myCatalogue; //Variable at class level means everything inside the class can see it, if this was inside the method, only the things inside that method can see it
        Book myBook;

        [TestInitialize]  //RUN THIS TEST BEFORE RUNNING ANY OTHER INDIIVIDUAL TEST
        public void Setup()
        {
            //Arrange
            myCatalogue = new Catalogue(); //making a new catalogue as that is the condition, runs the constructor
            myBook = new Book (); //put the book into the catalogue
        }

        [TestCleanup]
        public void Clean()
        {
            //anything that needs to be done after the code
        }

        [TestMethod]
        public void Test_GetAllBooks_ReturnsAListOfZeroLength_WhenTheCatalogueHasNoBooks()
        {
            //Act
            List<Book> books = myCatalogue.GetAllBooks();

            //Assert
            Assert.AreEqual(0, books.Count);

        }

        [TestMethod]
        public void Test_GetAllBooks_ReturnsAListOfOneLength_WhenTheCatalogueHasOneBook()
        {
            //Arrange
            myCatalogue.books.Add(myBook);

            //Act 
            List<Book> books = myCatalogue.GetAllBooks();


            //Assert 
            Assert.AreEqual(1, books.Count);
        }

        [TestMethod]
        public void Test_GetAllBooks_ReturnsTheSameBookThatWasAdded_WhenTheCatalogueHasOneBook()
        {
            //Arrange
            myBook.title = "Lord Of The Rings";
            myCatalogue.books.Add(myBook);

            //Act
            List<Book> books = myCatalogue.GetAllBooks();

            //Assert
            Assert.AreEqual(myBook.title, books[0].title);
            //testing that my book has got the same name as the first book that we get back from the catalogue. Then we can know if it is the same book that has been passed back.
        }

        [TestMethod]
        public void Test_GetAllBooks_RemovesTheBook_IfAValidISBNIsGiven()
        {
            //Arrange
            myBook.ISBN = "ABC123";
            myCatalogue.books.Add(myBook);

            //Act
            //List<Book> books = myCatalogue.GetAllBooks();
            Book removedBook = myCatalogue.RemoveBook("ABC123");

            //Assert
            Assert.AreEqual("ABC123", removedBook.ISBN);

        }
    }
}