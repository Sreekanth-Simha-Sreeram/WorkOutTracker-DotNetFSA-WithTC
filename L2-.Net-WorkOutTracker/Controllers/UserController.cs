using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorkOutTracker.Entities;

namespace WorkOutTracker.Web.Controllers
{
    public class UserController : Controller
    {
        public bool AddWorkOutCollection(List<WorkOutCollection> workOut)
        {
            // code here to add workout collection
            return true;
        }

        public IActionResult EditWorkOutCollection(long workOutId)
        {
            // code here to update workout tracker
            return View();
        }


        public IActionResult GetWorkOutCollection(long workOutId)
        {
            //code here to get workout collection by id
            return View();
        }


        public IActionResult ViewWorkOutCollections(int userId)
        {
            // code here to view workout collection
            return View();
        }

        public bool DeleteWorkOutCollection(long workOutId)
        {
            //code here to delete workout from collection
            return true;
        }

        public bool AddWorkOutCategory(List<WorkOutCategory> workOut)
        {
            // code here to add workout category
            return true;
        }

        public IActionResult EditWorkOutCategory(long categoryId)
        {
            //code here to update workout categoty by id
            return View();
        }

        public IActionResult GetWorkOutCategory(long categoryId)
        {
            // code here to get workout tracker by id
            return View();
        }

        public IActionResult ViewWorkOutCategory(long CategoryId)
        {
            // code here to view workout category
            return View();
        }

        public bool DeleteWorkOutCategory(long categoryId)
        {
            // code here to delete workout category
            return true;
        }

        public bool EndWorkOut(List<WorkOutActive> workoutactive)
        {
            // code here to end workout
            return true;
        }

        public bool StartWorkOut(List<WorkOutActive> workoutactive)
        {
            //code here to start workout
            return true;
        }


        public void CreateReportOnWorkOut(WorkOutActive active, int userID)
        {
            // code here create report on workout
        }

       
    }
}