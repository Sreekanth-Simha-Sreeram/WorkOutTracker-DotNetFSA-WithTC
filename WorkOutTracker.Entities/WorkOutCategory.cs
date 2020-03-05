using System;
using System.Collections.Generic;
using System.Text;

namespace WorkOutTracker.Entities
{
    public class WorkOutCategory
    {
        public virtual long CategoryId { get; set; }
        public virtual string CategoryName { get; set; }
    }
}
