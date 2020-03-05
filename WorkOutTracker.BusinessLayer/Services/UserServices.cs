using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.DataLayer.NHibernate;
using WorkOutTracker.BusinessLayer.Interfaces;
using WorkOutTracker.Entities;

namespace WorkOutTracker.BusinessLayer.Services
{
   public  class UserServices : IUserServices
    {
        private readonly IMapperSession _session;

        public UserServices(IMapperSession session)
        {
            _session = session;
        }

        public bool AddWorkOutCollection(List<WorkOutCollection> workOut)
        {
            return true;
        }

        public WorkOutCollection EditWorkOutCollection(long workOutId)
        {
            throw new NotImplementedException();
        }


        public WorkOutCollection GetWorkOutCollection(long workOutId)
        {
            WorkOutCollection workOut = new WorkOutCollection();

            return workOut;
        }


        public List<WorkOutCollection> ViewWorkOutCollections(int userId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteWorkOutCollection(long workOutId)
        {
            return true;
        }

        public bool AddWorkOutCategory(List<WorkOutCategory> workOut)
        {
            return true;
        }
               
        public WorkOutCategory EditWorkOutCategory(long categoryId)
        {
            WorkOutCategory category = new WorkOutCategory();
            return category;
        }
                
        public WorkOutCategory GetWorkOutCategory(long categoryId)
        {
            WorkOutCategory category = new WorkOutCategory();
            return category;
        }
        
        public List<WorkOutCategory> ViewWorkOutCategory(long CategoryId)
        {
            throw new NotImplementedException();
        }
         
        public bool DeleteWorkOutCategory(long categoryId)
        {
            return true;
        }

        public bool EndWorkOut(List<WorkOutActive> workoutactive)
        {
            return true;
        }

        public bool StartWorkOut(List<WorkOutActive> workoutactive)
        {
            return true;
        }


        public void CreateReportOnWorkOut(WorkOutActive active, int userID)
        {

        }

        public List<WorkOutCollection> SearchWorkOutCollections(string WorkOutName)
        {
            throw new NotImplementedException();

        }
    }
}
