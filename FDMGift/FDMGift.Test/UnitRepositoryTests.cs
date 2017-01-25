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

        [TestMethod]
        public void Test_CheckUserDetails_ConfirmEmailAndPasswordMatchEntry()
        {
            //Arrange
            bool expected = true;

            string email = "s@g.com";
            string password = "sk";

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
            var actual = classUnderTest.checkUserDetails(email, password);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_CheckUserDetails_ConfirmEmailAndPasswordDontMatchEntry()
        {
            //Arrange
            bool expected = false;

            string email = "s@g.com";
            string password = "ak";

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
            var actual = classUnderTest.checkUserDetails(email, password);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_CheckUserExists_ConfirmEmailAndPasswordMatchDatabase()
        {
            //Arrange
            bool expected = true;

            string email = "s@g.com";

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
            var actual = classUnderTest.checkUserExists(email);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_CheckUserExists_ConfirmEmailAndPasswordDontMatchDatabase()
        {
            //Arrange
            bool expected = false;

            string email = "m@r.com";

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
            var actual = classUnderTest.checkUserExists(email);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_AddUser_CallsAddOnDbSetAndSaveChangesOnContext()
        {
            //Arrange
            var mockDbSet = new Mock<DbSet<Users>>();
            var mockContext = new Mock<UsersContext>();

            mockContext.Setup(p => p.users).Returns(mockDbSet.Object);

            var classUnderTest = new UserRepository(mockContext.Object);

            //Act
            classUnderTest.addUsers(new Users { fullName = "S K" });

            //Assert
            mockDbSet.Verify(p => p.Add(It.IsAny<Broker>()), Times.Once);
            mockContext.Verify(p => p.SaveChanges(), Times.Once);
        }


        

    }
}
