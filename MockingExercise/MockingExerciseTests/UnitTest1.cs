using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MockingExerciseTests
{
    [TestClass]
    public class CatalogueTests
    {
        CatalogueTests myCatalogue
        public void Setup()
        {
            myCatalogue = new Catalogue();
        }

        [TestMethod]
        public void Test_GetAllBooks_ReturnsEmptyBookList_IfNoBooksAreInTheCatalogue()
        {
            //Arrange
            List<Book> expected = new List<Book>();
 
            //Act
            List<Book> actual = myCatalogue.GetAllBooks();

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_GetAllBooks_CallsReadDatabaseMethodOfDatabaseReader_WhenCalled()
        {
            //Arrange
            Mock<IDatabaseReader> mockDatabaseReader =  new Mock<IDatabaseReader>

            //Act
            myCatalogue.GetAllBooks();

            //Assert
            mockDatabaseReader.Verify(r => r.ReadDatabase(), Times.Once)
        }
}
