using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntitiyFrameworkDemo.CodeFirst;
using System.Collections.Generic;
using Moq;
using System.Data.Entity;

namespace EntityFrameworkDemo.Tests
{
    [TestClass]
    public class BrokerRepositoryTests
    {
        [TestMethod]
        public void Test_GetAllBrokers_ReturnsAllBrokers()
        {
            //Arrange
            var expected = new List<Broker>
            {
                new Broker { id = 1, name = "Batman", companyId = 1},
                new Broker { id = 2, name = "Robin", companyId = 1},
                new Broker { id = 3, name = "Mr Freeze", companyId = 1}
            };

            var testData = new List<Broker>
            {
                new Broker { id = 1, name = "Batman", companyId = 1},
                new Broker { id = 2, name = "Robin", companyId = 1},
                new Broker { id = 3, name = "Mr Freeze", companyId = 1} //deleting previous 3 lines should make test, fail, then you can make it pass by re-inserting.
            }.AsQueryable();

            var dbSetMock = new Mock<DbSet<Broker>>();
            //These 4 lines are always the same, they set up the dbset mock so that it acts like a dbset
            dbSetMock.As<IQueryable<Broker>>().Setup(d => d.Provider).Returns(testData.Provider);
            dbSetMock.As<IQueryable<Broker>>().Setup(d => d.Expression).Returns(testData.Expression);
            dbSetMock.As<IQueryable<Broker>>().Setup(d => d.ElementType).Returns(testData.ElementType);
            dbSetMock.As<IQueryable<Broker>>().Setup(d => d.GetEnumerator()).Returns(testData.GetEnumerator());

            Mock<CodeFirstModel> contextMock = new Mock<CodeFirstModel>();
            contextMock.Setup(c => c.brokers).Returns(dbSetMock.Object);

            BrokerRepository classUnderTest = new BrokerRepository(contextMock.Object); //called classundertest as so many moqs lying around and Im aware which class is being tested

            //Act
            var actual = classUnderTest.GetAllBrokers();

            //Assert
            Assert.AreEqual(expected[0].id, actual[0].id);
            Assert.AreEqual(expected[1].id, actual[1].id);
            Assert.AreEqual(expected[2].id, actual[2].id);
        }
    }
}
