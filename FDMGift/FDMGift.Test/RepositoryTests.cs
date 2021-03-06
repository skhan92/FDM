﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FDMGift.EntityFramework;
using System.Collections.Generic;
using Moq;
using System.Linq;
using System.Data.Entity;

namespace FDMGift.Test
{
    [TestClass]
    public class RepositoryTests
    {
        //USER REPOSITORY
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
            Mock<Users> user = new Mock<Users>();
            //Arrange
            
            var mockDbSet = new Mock<DbSet<Users>>();
            var mockContext = new Mock<EFramework>();

            mockContext.Setup(p => p.users).Returns(mockDbSet.Object);

            var classUnderTest = new UserRepository(mockContext.Object);

            //Act
            classUnderTest.addUsers(user.Object );

            //Assert
            mockDbSet.Verify(p => p.Add(user.Object), Times.Once);
            mockContext.Verify(p => p.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void Test_UpdateUser_CallsUpdateOnDbSetAndSaveChangesOnContext()
        {
            Mock<Users> user = new Mock<Users>();
            //Arrange
            var mockContext = new Mock<EFramework>();
            string EmailToChange = "s@g.com";
            string WhatToChange = "fullName";
            string changeTo = "A";

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
            classUnderTest.updateUser(EmailToChange, WhatToChange, changeTo);
            
            //Assert
            Assert.AreEqual(changeTo, dbSetMock.Object.First().fullName);
            contextMock.Verify(p => p.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void Test_RemoveUser_RemoveUserFromDatabase()
        {
            Mock<Users> userRemoved = new Mock<Users>();
           
            //Arrange
            List<Users> userList = new List<Users>();
            userList = new List<Users> { userRemoved.Object };

            userRemoved.Setup(p => p.id).Returns(1);

            var testData = new List<Users>()
            {
                userRemoved.Object
            }.AsQueryable();

            var dbSetMock = new Mock<DbSet<Users>>();
            dbSetMock.As<IQueryable<Users>>().Setup(d => d.Provider).Returns(testData.Provider);
            dbSetMock.As<IQueryable<Users>>().Setup(d => d.Expression).Returns(testData.Expression);
            dbSetMock.As<IQueryable<Users>>().Setup(d => d.ElementType).Returns(testData.ElementType);
            dbSetMock.As<IQueryable<Users>>().Setup(d => d.GetEnumerator()).Returns(testData.GetEnumerator());

            Mock<EFramework> contextMock = new Mock<EFramework>();
            contextMock.Setup(c => c.users).Returns(dbSetMock.Object);

            UserRepository classUnderTest = new UserRepository(contextMock.Object);
            dbSetMock.Setup(s => s.Remove(userRemoved.Object)).Verifiable();

            //Act
            classUnderTest.removeUsers(userRemoved.Object.id);

            //Assert
            dbSetMock.Verify(p => p.Remove(userRemoved.Object), Times.Once);
            contextMock.Verify(p => p.SaveChanges(), Times.Once);
        }

        //CHARITY REPOSITORY
        [TestMethod]
        public void Test_GetAllCharities_ReturnsAllCharities()
        {
            //Arrange
            var expected = new List<Charities>
            {
                new Charities { id = 1, charityName = "Suleman Khan", targetAmount = 10},
                new Charities { id = 2, charityName = "Humzah Khan", targetAmount = 20},
                new Charities { id = 3, charityName = "Ayesha Khan", targetAmount = 30}
            };

            var testData = new List<Charities>
            {
                new Charities { id = 1, charityName = "Suleman Khan", targetAmount = 10},
                new Charities { id = 2, charityName = "Humzah Khan", targetAmount = 20},
                new Charities { id = 3, charityName = "Ayesha Khan", targetAmount = 30}
            }.AsQueryable();

            var dbSetMock = new Mock<DbSet<Charities>>();
            dbSetMock.As<IQueryable<Charities>>().Setup(d => d.Provider).Returns(testData.Provider);
            dbSetMock.As<IQueryable<Charities>>().Setup(d => d.Expression).Returns(testData.Expression);
            dbSetMock.As<IQueryable<Charities>>().Setup(d => d.ElementType).Returns(testData.ElementType);
            dbSetMock.As<IQueryable<Charities>>().Setup(d => d.GetEnumerator()).Returns(testData.GetEnumerator());

            Mock<EFramework> contextMock = new Mock<EFramework>();
            contextMock.Setup(c => c.charities).Returns(dbSetMock.Object);

            CharitiesRepository classUnderTest = new CharitiesRepository(contextMock.Object);

            //Act
            var actual = classUnderTest.GetAllCharities();

            //Assert
            Assert.AreEqual(expected[0].id, actual[0].id);
            Assert.AreEqual(expected[1].id, actual[1].id);
            Assert.AreEqual(expected[2].id, actual[2].id);
        }

        [TestMethod]
        public void Test_CheckCharityExists_ConfirmCharityNameMatchDatabase()
        {
            //Arrange
            bool expected = true;

            string charityName = "H";

            var testData = new List<Charities>
            {
                new Charities { id = 1, charityName = "H", targetAmount = 10},
            }.AsQueryable();

            var dbSetMock = new Mock<DbSet<Charities>>();
            dbSetMock.As<IQueryable<Charities>>().Setup(d => d.Provider).Returns(testData.Provider);
            dbSetMock.As<IQueryable<Charities>>().Setup(d => d.Expression).Returns(testData.Expression);
            dbSetMock.As<IQueryable<Charities>>().Setup(d => d.ElementType).Returns(testData.ElementType);
            dbSetMock.As<IQueryable<Charities>>().Setup(d => d.GetEnumerator()).Returns(testData.GetEnumerator());

            Mock<EFramework> contextMock = new Mock<EFramework>();
            contextMock.Setup(c => c.charities).Returns(dbSetMock.Object);

            CharitiesRepository classUnderTest = new CharitiesRepository(contextMock.Object);

            //Act
            var actual = classUnderTest.checkCharityExists(charityName);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_CheckCharityExists_ConfirmCharityNameDoesntMatchDatabase()
        {
            //Arrange
            bool expected = false;

            string charityName = "S";

            var testData = new List<Charities>
            {
                new Charities { id = 1, charityName = "H", targetAmount = 10},
            }.AsQueryable();

            var dbSetMock = new Mock<DbSet<Charities>>();
            dbSetMock.As<IQueryable<Charities>>().Setup(d => d.Provider).Returns(testData.Provider);
            dbSetMock.As<IQueryable<Charities>>().Setup(d => d.Expression).Returns(testData.Expression);
            dbSetMock.As<IQueryable<Charities>>().Setup(d => d.ElementType).Returns(testData.ElementType);
            dbSetMock.As<IQueryable<Charities>>().Setup(d => d.GetEnumerator()).Returns(testData.GetEnumerator());

            Mock<EFramework> contextMock = new Mock<EFramework>();
            contextMock.Setup(c => c.charities).Returns(dbSetMock.Object);

            CharitiesRepository classUnderTest = new CharitiesRepository(contextMock.Object);

            //Act
            var actual = classUnderTest.checkCharityExists(charityName);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_AddCharity_CallsAddOnDbSetAndSaveChangesOnContext()
        {
            Mock<Charities> charities = new Mock<Charities>();
            //Arrange

            var mockDbSet = new Mock<DbSet<Charities>>();
            var mockContext = new Mock<EFramework>();

            mockContext.Setup(p => p.charities).Returns(mockDbSet.Object);

            var classUnderTest = new CharitiesRepository(mockContext.Object);

            //Act
            classUnderTest.addCharities(charities.Object);

            //Assert
            mockDbSet.Verify(p => p.Add(charities.Object), Times.Once);
            mockContext.Verify(p => p.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void Test_UpdateCharity_CallsUpdateOnDbSetAndSaveChangesOnContext()
        {
            Mock<Charities> charities = new Mock<Charities>();
            //Arrange
            var mockContext = new Mock<EFramework>();
            int IdToChange = 1;
            string WhatToChange = "targetAmount";
            int changeTo = 50;

            var testData = new List<Charities>
            {
                new Charities { id = 1, charityName = "abc", targetAmount = 50 }
            }.AsQueryable();

            var dbSetMock = new Mock<DbSet<Charities>>();
            dbSetMock.As<IQueryable<Charities>>().Setup(d => d.Provider).Returns(testData.Provider);
            dbSetMock.As<IQueryable<Charities>>().Setup(d => d.Expression).Returns(testData.Expression);
            dbSetMock.As<IQueryable<Charities>>().Setup(d => d.ElementType).Returns(testData.ElementType);
            dbSetMock.As<IQueryable<Charities>>().Setup(d => d.GetEnumerator()).Returns(testData.GetEnumerator());

            Mock<EFramework> contextMock = new Mock<EFramework>();
            contextMock.Setup(c => c.charities).Returns(dbSetMock.Object);

            CharitiesRepository classUnderTest = new CharitiesRepository(contextMock.Object);

            //Act
            classUnderTest.updateCharities(IdToChange, WhatToChange, changeTo);

            //Assert
            Assert.AreEqual(changeTo, dbSetMock.Object.First().targetAmount);
            contextMock.Verify(p => p.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void Test_RemoveCharity_RemoveCharityFromDatabase()
        {
            Mock<Charities> charityRemoved = new Mock<Charities>();

            //Arrange
            List<Charities> charityList = new List<Charities>();
            charityList = new List<Charities> { charityRemoved.Object };

            charityRemoved.Setup(p => p.id).Returns(1);

            var testData = new List<Charities>()
            {
                charityRemoved.Object
            }.AsQueryable();

            var dbSetMock = new Mock<DbSet<Charities>>();
            dbSetMock.As<IQueryable<Charities>>().Setup(d => d.Provider).Returns(testData.Provider);
            dbSetMock.As<IQueryable<Charities>>().Setup(d => d.Expression).Returns(testData.Expression);
            dbSetMock.As<IQueryable<Charities>>().Setup(d => d.ElementType).Returns(testData.ElementType);
            dbSetMock.As<IQueryable<Charities>>().Setup(d => d.GetEnumerator()).Returns(testData.GetEnumerator());

            Mock<EFramework> contextMock = new Mock<EFramework>();
            contextMock.Setup(c => c.charities).Returns(dbSetMock.Object);

            CharitiesRepository classUnderTest = new CharitiesRepository(contextMock.Object);
            dbSetMock.Setup(s => s.Remove(charityRemoved.Object)).Verifiable();

            //Act
            classUnderTest.removeCharities(charityRemoved.Object.id);

            //Assert
            dbSetMock.Verify(p => p.Remove(charityRemoved.Object), Times.Once);
            contextMock.Verify(p => p.SaveChanges(), Times.Once);
        }

        //BASKET REPOSITORY
        [TestMethod]
        public void Test_GetAllBasket_ReturnsAllDonations()
        {
            //Arrange
            var expected = new List<Basket>
            {
                new Basket { basketId = 1, userId = 1, charityId = 1, amountDonated = 10},
                new Basket { basketId = 2, userId = 2, charityId = 2, amountDonated = 20},
            };

            var testData = new List<Basket>
            {
                new Basket { basketId = 1, userId = 1, charityId = 1, amountDonated = 10},
                new Basket { basketId = 2, userId = 2, charityId = 2, amountDonated = 20},
            }.AsQueryable();

            var dbSetMock = new Mock<DbSet<Basket>>();
            dbSetMock.As<IQueryable<Basket>>().Setup(d => d.Provider).Returns(testData.Provider);
            dbSetMock.As<IQueryable<Basket>>().Setup(d => d.Expression).Returns(testData.Expression);
            dbSetMock.As<IQueryable<Basket>>().Setup(d => d.ElementType).Returns(testData.ElementType);
            dbSetMock.As<IQueryable<Basket>>().Setup(d => d.GetEnumerator()).Returns(testData.GetEnumerator());

            Mock<EFramework> contextMock = new Mock<EFramework>();
            contextMock.Setup(c => c.basket).Returns(dbSetMock.Object);

            BasketRepository classUnderTest = new BasketRepository(contextMock.Object);

            //Act
            var actual = classUnderTest.GetBasket();

            //Assert
            Assert.AreEqual(expected[0].basketId, actual[0].basketId);
            Assert.AreEqual(expected[1].basketId, actual[1].basketId);
        }

        [TestMethod]
        public void Test_AddDonation_CallsAddOnDbSetAndSaveChangesOnContext()
        {
            Mock<Basket> basket = new Mock<Basket>();
            //Arrange

            var mockDbSet = new Mock<DbSet<Basket>>();
            var mockContext = new Mock<EFramework>();

            mockContext.Setup(p => p.basket).Returns(mockDbSet.Object);

            var classUnderTest = new BasketRepository(mockContext.Object);

            //Act
            classUnderTest.addBasket(basket.Object);

            //Assert
            mockDbSet.Verify(p => p.Add(basket.Object), Times.Once);
            mockContext.Verify(p => p.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void Test_UpdateBasket_CallsUpdateOnDbSetAndSaveChangesOnContext()
        {
            Mock<Basket> basket = new Mock<Basket>();
            //Arrange
            var mockContext = new Mock<EFramework>();
            int IdToChange = 1;
            string WhatToChange = "amountDonated";
            int changeTo = 50;

            var testData = new List<Basket>
            {
                new Basket { basketId = 1, userId = 1, charityId = 1, amountDonated = 50  }
            }.AsQueryable();

            var dbSetMock = new Mock<DbSet<Basket>>();
            dbSetMock.As<IQueryable<Basket>>().Setup(d => d.Provider).Returns(testData.Provider);
            dbSetMock.As<IQueryable<Basket>>().Setup(d => d.Expression).Returns(testData.Expression);
            dbSetMock.As<IQueryable<Basket>>().Setup(d => d.ElementType).Returns(testData.ElementType);
            dbSetMock.As<IQueryable<Basket>>().Setup(d => d.GetEnumerator()).Returns(testData.GetEnumerator());

            Mock<EFramework> contextMock = new Mock<EFramework>();
            contextMock.Setup(c => c.basket).Returns(dbSetMock.Object);

            BasketRepository classUnderTest = new BasketRepository(contextMock.Object);

            //Act
            classUnderTest.updateBasket(IdToChange, WhatToChange, changeTo);

            //Assert
            Assert.AreEqual(changeTo, dbSetMock.Object.First().amountDonated);
            contextMock.Verify(p => p.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void Test_RemoveBasket_RemoveBasketFromDatabase()
        {
            Mock<Basket> basketRemoved = new Mock<Basket>();

            //Arrange
            List<Basket> basketList = new List<Basket>();
            basketList = new List<Basket> { basketRemoved.Object };

            basketRemoved.Setup(p => p.basketId).Returns(1);

            var testData = new List<Basket>()
            {
                basketRemoved.Object
            }.AsQueryable();

            var dbSetMock = new Mock<DbSet<Basket>>();
            dbSetMock.As<IQueryable<Basket>>().Setup(d => d.Provider).Returns(testData.Provider);
            dbSetMock.As<IQueryable<Basket>>().Setup(d => d.Expression).Returns(testData.Expression);
            dbSetMock.As<IQueryable<Basket>>().Setup(d => d.ElementType).Returns(testData.ElementType);
            dbSetMock.As<IQueryable<Basket>>().Setup(d => d.GetEnumerator()).Returns(testData.GetEnumerator());

            Mock<EFramework> contextMock = new Mock<EFramework>();
            contextMock.Setup(c => c.basket).Returns(dbSetMock.Object);

            BasketRepository classUnderTest = new BasketRepository(contextMock.Object);
            dbSetMock.Setup(s => s.Remove(basketRemoved.Object)).Verifiable();

            //Act
            classUnderTest.removeBasket(basketRemoved.Object.basketId);

            //Assert
            dbSetMock.Verify(p => p.Remove(basketRemoved.Object), Times.Once);
            contextMock.Verify(p => p.SaveChanges(), Times.Once);
        }

        //ADMIN REPOSITORY
        [TestMethod]
        public void Test_GetAllAdmins_ReturnsAllAdmins()
        {
            //Arrange
            var expected = new List<Admins>
            {
                new Admins { id = 1, email = "s@g.com", fullName = "abc", password = "a" },
                new Admins { id = 2, email = "s@h.com", fullName = "def", password = "b" },
            };

            var testData = new List<Admins>
            {
                new Admins { id = 1, email = "s@g.com", fullName = "abc", password = "a" },
                new Admins { id = 2, email = "s@h.com", fullName = "def", password = "b" },
            }.AsQueryable();

            var dbSetMock = new Mock<DbSet<Admins>>();
            dbSetMock.As<IQueryable<Admins>>().Setup(d => d.Provider).Returns(testData.Provider);
            dbSetMock.As<IQueryable<Admins>>().Setup(d => d.Expression).Returns(testData.Expression);
            dbSetMock.As<IQueryable<Admins>>().Setup(d => d.ElementType).Returns(testData.ElementType);
            dbSetMock.As<IQueryable<Admins>>().Setup(d => d.GetEnumerator()).Returns(testData.GetEnumerator());

            Mock<EFramework> contextMock = new Mock<EFramework>();
            contextMock.Setup(c => c.admins).Returns(dbSetMock.Object);

            AdminRepository classUnderTest = new AdminRepository(contextMock.Object);

            //Act
            var actual = classUnderTest.GetAllAdmins();

            //Assert
            Assert.AreEqual(expected[0].id, actual[0].id);
            Assert.AreEqual(expected[1].id, actual[1].id);
        }

        [TestMethod]
        public void Test_CheckAdminDetails_ConfirmEmailAndPasswordMatchEntry()
        {
            //Arrange
            bool expected = true;

            string email = "s@g.com";
            string password = "sk";

            var testData = new List<Admins>
            {
                new Admins { id = 1, fullName = "Suleman Khan", email = "s@g.com", password = "sk"},
                new Admins { id = 2, fullName = "Humzah Khan", email = "h@g.com", password = "hk"},
                new Admins { id = 3, fullName = "Ayesha Khan", email = "a@g.com", password = "ak"}
            }.AsQueryable();

            var dbSetMock = new Mock<DbSet<Admins>>();
            dbSetMock.As<IQueryable<Admins>>().Setup(d => d.Provider).Returns(testData.Provider);
            dbSetMock.As<IQueryable<Admins>>().Setup(d => d.Expression).Returns(testData.Expression);
            dbSetMock.As<IQueryable<Admins>>().Setup(d => d.ElementType).Returns(testData.ElementType);
            dbSetMock.As<IQueryable<Admins>>().Setup(d => d.GetEnumerator()).Returns(testData.GetEnumerator());

            Mock<EFramework> contextMock = new Mock<EFramework>();
            contextMock.Setup(c => c.admins).Returns(dbSetMock.Object);

            AdminRepository classUnderTest = new AdminRepository(contextMock.Object);

            //Act
            var actual = classUnderTest.checkAdminDetails(email, password);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_CheckAdminDetails_ConfirmEmailAndPasswordDontMatchEntry()
        {
            //Arrange
            bool expected = false;

            string email = "s@g.com";
            string password = "ak";

            var testData = new List<Admins>
            {
                new Admins { id = 1, fullName = "Suleman Khan", email = "s@g.com", password = "sk"},
                new Admins { id = 2, fullName = "Humzah Khan", email = "h@g.com", password = "hk"},
                new Admins { id = 3, fullName = "Ayesha Khan", email = "a@g.com", password = "ak"}
            }.AsQueryable();

            var dbSetMock = new Mock<DbSet<Admins>>();
            dbSetMock.As<IQueryable<Admins>>().Setup(d => d.Provider).Returns(testData.Provider);
            dbSetMock.As<IQueryable<Admins>>().Setup(d => d.Expression).Returns(testData.Expression);
            dbSetMock.As<IQueryable<Admins>>().Setup(d => d.ElementType).Returns(testData.ElementType);
            dbSetMock.As<IQueryable<Admins>>().Setup(d => d.GetEnumerator()).Returns(testData.GetEnumerator());

            Mock<EFramework> contextMock = new Mock<EFramework>();
            contextMock.Setup(c => c.admins).Returns(dbSetMock.Object);

            AdminRepository classUnderTest = new AdminRepository(contextMock.Object);

            //Act
            var actual = classUnderTest.checkAdminDetails(email, password);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_UpdateAdmin_CallsUpdateOnDbSetAndSaveChangesOnContext()
        {
            Mock<Admins> user = new Mock<Admins>();
            //Arrange
            var mockContext = new Mock<EFramework>();
            int IdToChange = 1;
            string WhatToChange = "fullName";
            string changeTo = "A";

            var testData = new List<Admins>
            {
                new Admins { id = 1, fullName = "Suleman Khan", email = "s@g.com", password = "sk"},
                new Admins { id = 2, fullName = "Humzah Khan", email = "h@g.com", password = "hk"},
                new Admins { id = 3, fullName = "Ayesha Khan", email = "a@g.com", password = "ak"}
            }.AsQueryable();

            var dbSetMock = new Mock<DbSet<Admins>>();
            dbSetMock.As<IQueryable<Admins>>().Setup(d => d.Provider).Returns(testData.Provider);
            dbSetMock.As<IQueryable<Admins>>().Setup(d => d.Expression).Returns(testData.Expression);
            dbSetMock.As<IQueryable<Admins>>().Setup(d => d.ElementType).Returns(testData.ElementType);
            dbSetMock.As<IQueryable<Admins>>().Setup(d => d.GetEnumerator()).Returns(testData.GetEnumerator());

            Mock<EFramework> contextMock = new Mock<EFramework>();
            contextMock.Setup(c => c.admins).Returns(dbSetMock.Object);

            AdminRepository classUnderTest = new AdminRepository(contextMock.Object);

            //Act
            classUnderTest.updateAdmins(IdToChange, WhatToChange, changeTo);

            //Assert
            Assert.AreEqual(changeTo, dbSetMock.Object.First().fullName);
            contextMock.Verify(p => p.SaveChanges(), Times.Once);
        }

    }
}
