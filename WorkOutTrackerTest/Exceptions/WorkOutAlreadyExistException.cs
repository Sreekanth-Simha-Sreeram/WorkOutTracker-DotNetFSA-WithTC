using System;
using System.Collections.Generic;
using System.Text;

namespace WorkOutTracker.Test.Exceptions
{
   public class WorkOutAlreadyExistException :Exception
    {
        public string Messages = "WorkOut Already exist";

        public WorkOutAlreadyExistException(string message)
        {
            Messages = message;

        }
    }
}
