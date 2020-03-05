using System;
using System.Collections.Generic;
using System.Text;
using WorkOutTracker.Entities;

namespace WorkOutTracker.BusinessLayer.Interfaces
{
   public  interface IUserServices
    {
        bool AddWorkOutCollection(List<WorkOutCollection> workOut);
        bool DeleteWorkOutCollection(long workOutId);
        WorkOutCollection EditWorkOutCollection(long workOutId);
        List<WorkOutCollection> ViewWorkOutCollections(int userId);
        List<WorkOutCollection> SearchWorkOutCollections(string WorkOutName);


        bool AddWorkOutCategory(List<WorkOutCategory> workOut);
        bool DeleteWorkOutCategory(long categoryId);
        WorkOutCategory EditWorkOutCategory(long categoryId);
        List<WorkOutCategory> ViewWorkOutCategory(long CategoryId);

        bool EndWorkOut(List<WorkOutActive> workoutactive);
        bool StartWorkOut(List<WorkOutActive> workoutactive);

        void CreateReportOnWorkOut(WorkOutActive active, int userID);

    }
}
