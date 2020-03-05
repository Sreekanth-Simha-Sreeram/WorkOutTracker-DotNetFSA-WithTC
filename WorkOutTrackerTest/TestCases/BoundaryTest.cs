using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.DataLayer.NHibernate;
using WorkOutTracker.BusinessLayer.Services;
using WorkOutTracker.Entities;
using Xunit;

namespace WorkOutTrackerTest.TestCases
{
    public class BoundaryTest
    {
        private readonly UserServices _UserService;
        private readonly LoginServices _LoginService;
        private readonly IMapperSession _Session = Substitute.For<IMapperSession>();

        public BoundaryTest()
        {
            _UserService = new UserServices(_Session);
            _LoginService = new LoginServices(_Session);
        }

        User user = new User()
        {
            UserId = 1,
            UserName = "John",
            Email = "John@gmail.com",
            Password = "123456"
        };
        WorkOutCollection workOut = new WorkOutCollection()
        {
            WorkOutID = 10,
            WorkOutTitle = "MorningRun",
            Note = "Need to Achieve",
            CaloriesBurnPerMin = 15.03,
            CategoryID = 1
        };

        [Fact]
        public void BoundaryTestFor_ValidEmailFormat()
        {
            var emailRegex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            Assert.DoesNotMatch(emailRegex, user.Email);
        }

        [Fact]
        public void BoundaryTestFor_ValidPassword_Length()
        {
            var minLength = 6;
            var maxLength = 20;
            Assert.InRange(user.Password.Length, minLength, maxLength);
        }

        [Fact]
        public void BoundaryTestForr_CaloriesBurnPerMin()
        {
            var calory = workOut.CaloriesBurnPerMin.ToString();
            Assert.NotNull(calory);
        }

    }
}
