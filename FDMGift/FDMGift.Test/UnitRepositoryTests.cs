using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FDMGift.EntityFramework;
using System.Collections.Generic;
using Moq;
using System.Linq;
using System.Data.Entity;

namespace FDMGift.Test
{
    [TestClass]
    public class UnitRepositoryTests
    {
        [TestMethod]
        public void Test_GetAllUsers_ReturnsAllUsers()
        {
            //Arrange
            var expected = new List<Users>
            {
                new Users { id = 1, fullName = "Suleman Khan", email = "s@g.com", password = "sk"},
                new Users { id = 2, fullName = "Humzah Khan", email = "h@g.com", password = "hk"},
                new Users { id = 3, fullName = "Ayesha Khan", email = "a@g.com", password = "ak"}
            };

            var testData = new List<Users>
            {
                new Users { id = 1, fullName = "Suleman Khan", email = "s@g.com", password = "sk"},
                new Users { id = 2, fullName = "Humzah Khan", email = "h@g.com", password = "hk"},
                new Users { id = 3, fullName = "Ayesha Khan", email = "a@g.com", password = "ak"}
            }.AsQueryable();

            var dbSetMock = new Mock<DbSet<Users>>();
            dbSetMock.As<IQueryable<Users>>().Setup(d => d.Provider).Returns(testData.Provider);
            dbSetMock.As<IQueryable<Users>>().Setup(d => d.Expression).Returns(testData.Expression);
            dbSetMock.As<IQueryable<Users>>().Setup(d => d.ElementType).Returns(testData.ElementType);
            dbSetMock.As<IQueryable<Users>>().Setup(d => d.GetEnumerator()).Returns(testData.GetEnumerator());

            Mock<EFramework> contextMock = new Mock<EFramework>();
            contextMock.Setup(c => c.users).Returns(dbSetMock.Object);

            UserRepository classUnderTest = new UserRepository(contextMock.Object);

            //Act
            var actual = classUnderTest.GetAllUsers();

            //Assert
            Assert.AreEqual(expected[0].id, actual[0].id);
            Assert.AreEqual(expected[1].id, actual[1].id);
            Assert.AreEqual(expected[2].id, actual[2].id);
        }
    }
}
