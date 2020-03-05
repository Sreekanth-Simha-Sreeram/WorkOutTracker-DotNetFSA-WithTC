using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkOutTracker.Entities;

namespace TaskManager.DataLayer.NHibernate
{
    public interface IMapperSession
    {
        void BeginTransaction();
        System.Threading.Tasks.Task Commit();
        System.Threading.Tasks.Task Rollback();
        void CloseTransaction();
        System.Threading.Tasks.Task Save(List<WorkOutCollection> entity);
        System.Threading.Tasks.Task Delete(WorkOutCollection entity);
        IQueryable<WorkOutCollection> products { get; }
    }
}

