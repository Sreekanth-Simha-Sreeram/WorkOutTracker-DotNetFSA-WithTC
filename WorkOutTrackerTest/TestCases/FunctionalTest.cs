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
    public class FunctionalTest
    {

        private readonly UserServices _UserService;
        private readonly LoginServices _LoginService;
        private readonly IMapperSession _Session = Substitute.For<IMapperSession>();

        public FunctionalTest()
        {
            _UserService = new UserServices(_Session);
            _LoginService = new LoginServices(_Session);
        }

        [Fact]
        public void TestFor_AddWorkOutCollection()
        {
            //Arrange - Create some test products
            WorkOutCollection ObjWorkOutCollection = new WorkOutCollection()
            {
                WorkOutID = 1,
                WorkOutTitle = "aaa",
                Note = "abc",
                CaloriesBurnPerMin = 1,
                CategoryID = 1,
            };

            //Action
            List<WorkOutCollection> Worklist = new List<WorkOutCollection>();
            Worklist.Add(ObjWorkOutCollection);
            var result = _UserService.AddWorkOutCollection(Worklist);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void TestFor_EditWorkOutCollection()
        {
            WorkOutCollection ObjWorkOutCollection = new WorkOutCollection()
            {
                WorkOutID = 1,
                WorkOutTitle = "aaa",
                Note = "abc",
                CaloriesBurnPerMin = 1,
                CategoryID = 1,
            };

            //Action
            var result = _UserService.EditWorkOutCollection(ObjWorkOutCollection.WorkOutID);

            var GetWorkOutCollection = _UserService.GetWorkOutCollection(ObjWorkOutCollection.WorkOutID);
            //Assert
            Assert.Equal(GetWorkOutCollection, result);
        }

        [Fact]
        public void TestFor_DeleteWorkOutCollection()
        {
            WorkOutCollection ObjWorkOutCollection = new WorkOutCollection()
            {
                WorkOutID = 1,
                WorkOutTitle = "aaa",
                Note = "abc",
                CaloriesBurnPerMin = 1,
                CategoryID = 1,
            };
            var result = _UserService.DeleteWorkOutCollection(ObjWorkOutCollection.WorkOutID);
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void TestFor_AddWorkOutCategory()
        {
            WorkOutCategory ObjWorkOutCategory = new WorkOutCategory()
            {
                CategoryId = 1,
                CategoryName = "aaa",
            };

            List<WorkOutCategory> WorkCategoryList = new List<WorkOutCategory>();
            WorkCategoryList.Add(ObjWorkOutCategory);
            var result = _UserService.AddWorkOutCategory(WorkCategoryList);
            Assert.True(result);
        }


        [Fact]
        public void TestFor_DeleteWorkOutCategory()
        {
            WorkOutCategory ObjWorkOutCategory = new WorkOutCategory()
            {
                CategoryId = 1,
                CategoryName = "aaa",
            };
            var result = _UserService.DeleteWorkOutCategory(ObjWorkOutCategory.CategoryId);
            Assert.True(result);
        }


        [Fact]
        public void TestFor_EndWorkOut()
        {
            WorkOutActive ObjWorkOutActive = new WorkOutActive()
            {
                EndTime = DateTime.Now.ToShortTimeString(),
                // EndDate = DateTime.Now,
                EndDate = DateTime.Now,
                userId = 1
            };
            List<WorkOutActive> WorkActiveList = new List<WorkOutActive>();
            WorkActiveList.Add(ObjWorkOutActive);
            var result = _UserService.EndWorkOut(WorkActiveList);
            Assert.True(result);
        }


        [Fact]
        public void TestFor_StartWorkOut()
        {
            WorkOutActive ObjWorkOutActive = new WorkOutActive()
            {
                StartTime = DateTime.Now.ToShortTimeString(),
                StartDate = DateTime.Now,
                userId = 1
            };
            List<WorkOutActive> WorkActiveList = new List<WorkOutActive>();
            WorkActiveList.Add(ObjWorkOutActive);
            var result = _UserService.StartWorkOut(WorkActiveList);
            Assert.True(result);
        }
    }
}