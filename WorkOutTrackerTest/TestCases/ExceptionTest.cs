using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.DataLayer.NHibernate;
using WorkOutTracker.BusinessLayer.Services;
using WorkOutTracker.Entities;
using WorkOutTracker.Test.Exceptions;
using Xunit;

namespace WorkOutTrackerTest.TestCases
{
   public class ExceptionTest
    {
        private readonly UserServices _UserService;
        private readonly LoginServices _LoginService;
        private readonly IMapperSession _Session = Substitute.For<IMapperSession>();

        public ExceptionTest()
        {
            _UserService = new UserServices(_Session);
            _LoginService = new LoginServices(_Session);
        }

        User user = new User()
        {
            UserId = 100,
            UserName = "ABC",
            Email = "abc@gmail.com",
            Password = "123456"
        };
        
        [Fact]
        public void ExceptionTestFor_UserRegistration()
        {
            //Arrange
            
             //Action
             var ex = Assert.Throws<UserAlreadyExistException>(() => _LoginService.SignUp(user.UserName, user.Password));
            //Assert
            Assert.Equal("User already registered.. Please login", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_UserLogin()
        {
            //Arrange
            //Action
            var ex = Assert.Throws<UserNotFoundException>(() => _LoginService.SignIn(user.Email, user.Password));
            //Assert
            Assert.Equal("User not found", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_WorkOutAlreadyExistException()
        {
            //Arrange
            WorkOutCollection workOut = new WorkOutCollection()
            {
                WorkOutID = 10,
                WorkOutTitle = "MorningRun",
                Note = "Need to Achieve",
                CaloriesBurnPerMin = 15.03,
                CategoryID = 1
            };

            List<WorkOutCollection> workOutList = new List<WorkOutCollection>();
            workOutList.Add(workOut);

            //Action
            //Assert
            var ex = Assert.Throws<WorkOutAlreadyExistException>(() => _UserService.AddWorkOutCollection(workOutList));
            Assert.Equal("WorkOut Already exist", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_WorkOutNotExistException()
        {
            //Arrange
            WorkOutCollection workOut = new WorkOutCollection()
            {
                WorkOutID = 100,
                WorkOutTitle = " ",
                Note = "Need to Achieve",
                CaloriesBurnPerMin = 15.03,
                CategoryID = 1
            };

            //Action
            //Assert
            var ex = Assert.Throws<WorkOutNotExistException>(() => _UserService.SearchWorkOutCollections(workOut.WorkOutTitle ));
            Assert.Equal("WorkOut not exist", ex.Messages);
        }


        [Fact]
        public void ExceptionTestFor_WorkOutCategoryAlreadyExistException()
        {
            //Arrange
            WorkOutCategory workOutCategory = new WorkOutCategory()
            {
                CategoryId = 10,
                CategoryName = "Jogging"
            };

            List<WorkOutCategory> workOutCategoryList = new List<WorkOutCategory>();
            workOutCategoryList.Add(workOutCategory);

            //Action
            //Assert
            var ex = Assert.Throws<WorkOutCategoryAlreadyExistException>(() => _UserService.AddWorkOutCategory(workOutCategoryList));
            Assert.Equal("WorkOut Category Already exist", ex.Messages);
        }
    }
}
