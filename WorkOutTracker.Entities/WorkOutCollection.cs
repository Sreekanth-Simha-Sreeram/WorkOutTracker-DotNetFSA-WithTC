using System;
using System.Collections.Generic;
using System.Text;

namespace WorkOutTracker.Entities
{
  public  class WorkOutCollection
    {
        public virtual int WorkOutID { get; set; }
        public virtual string WorkOutTitle { get; set; }
        public virtual string Note { get; set; }
        public virtual double CaloriesBurnPerMin { get; set; }
        public virtual int CategoryID { get; set; }
    }
}
