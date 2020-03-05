using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using WorkOutTracker.Entities;

namespace EMart.BusinessLayer
{
    public class MapWorkOutCollection : ClassMap<WorkOutCollection>
    {
        public MapWorkOutCollection()
        {

            Id(x => x.WorkOutID);
            Map(x => x.WorkOutTitle);
            Map(x => x.Note);
            Map(x => x.CaloriesBurnPerMin);
            Map(x => x.CategoryID);
            Table("workOutCollection");

        }
    }


}
