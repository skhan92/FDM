using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using FDMGift.EntityFramework;
using FDMGift.Logic;

namespace FDMGift.Test
{
    [TestClass]
    public class LogicTests
    {
        [TestMethod]
        public void Test_ConfirmUserToAddEmailExists_DontAllowAccountWithSameEmail()
        {
            //Arrange
            Mock<Users> existingUser = new Mock<Users>();

            List<Users> userList = new List<Users>();
            userList = new List<Users> { existingUser.Object };

            existingUser.Setup(p => p.email).Returns("s@g.com");
            existingUser.Setup(p => p.password).Returns("a");

            Mock<EFramework> contextMock = new Mock<EFramework>();
            Mock<UserRepository> userRepo = new Mock<UserRepository>(contextMock.Object);
            UserLogic classUnderTest = new UserLogic(userRepo.Object);

            userRepo.Setup(p => p.checkUserExists("s@g.com")).Returns(true);
            userRepo.Setup(p => p.addUsers(existingUser.Object)).Verifiable();

            //Act

            bool actual = classUnderTest.RegisterUser(existingUser.Object);

            //Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void Test_ConfirmUserToAddEmailDoesntExist_AllowAccountToBeAdded()
        {
            //Arrange
            Mock<Users> userChecked = new Mock<Users>();

            List<Users> userList = new List<Users>();
            userList = new List<Users> { userChecked.Object };

            userChecked.Setup(p => p.email).Returns("s@g.com");

            Mock<EFramework> contextMock = new Mock<EFramework>();
            Mock<UserRepository> userRepo = new Mock<UserRepository>(contextMock.Object);
            UserLogic classUnderTest = new UserLogic(userRepo.Object);

            userRepo.Setup(p => p.checkUserExists("s@g.com")).Returns(false);
            userRepo.Setup(p => p.addUsers(userChecked.Object)).Verifiable();

            //Act

            bool actual = classUnderTest.RegisterUser(userChecked.Object);

            //Assert
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void Test_ConfirmCharityNameToAddExists_DontAllowToAdd()
        {
            //Arrange
            Mock<Charities> existingCharity = new Mock<Charities>();

            List<Charities> charitiesList = new List<Charities>();
            charitiesList = new List<Charities> { existingCharity.Object };

            existingCharity.Setup(p => p.charityName).Returns("a");
            existingCharity.Setup(p => p.targetAmount).Returns(10);

            Mock<EFramework> contextMock = new Mock<EFramework>();
            Mock<CharitiesRepository> charityRepo = new Mock<CharitiesRepository>(contextMock.Object);
            CharityLogic classUnderTest = new CharityLogic(charityRepo.Object);

            charityRepo.Setup(p => p.checkCharityExists("a")).Returns(true);
            charityRepo.Setup(p => p.addCharities(existingCharity.Object)).Verifiable();

            //Act

            bool actual = classUnderTest.RegisterCharity(existingCharity.Object);

            //Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void Test_ConfirmCharityNameToAddDoesntExist_AllowToAdd()
        {
            //Arrange
            Mock<Charities> charityChecked = new Mock<Charities>();

            List<Charities> charitiesList = new List<Charities>();
            charitiesList = new List<Charities> { charityChecked.Object };

            charityChecked.Setup(p => p.charityName).Returns("a");

            Mock<EFramework> contextMock = new Mock<EFramework>();
            Mock<CharitiesRepository> charityRepo = new Mock<CharitiesRepository>(contextMock.Object);
            CharityLogic classUnderTest = new CharityLogic(charityRepo.Object);

            charityRepo.Setup(p => p.checkCharityExists("a")).Returns(false);
            charityRepo.Setup(p => p.addCharities(charityChecked.Object)).Verifiable();

            //Act

            bool actual = classUnderTest.RegisterCharity(charityChecked.Object);

            //Assert
            Assert.AreEqual(false, actual);
        }
    }
}

