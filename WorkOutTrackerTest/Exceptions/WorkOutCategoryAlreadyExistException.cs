using System;
using System.Collections.Generic;
using System.Text;

namespace WorkOutTracker.Test.Exceptions
{
    class WorkOutCategoryAlreadyExistException : Exception
    {
        public string Messages = "WorkOut Category Already exist";

        public WorkOutCategoryAlreadyExistException(string message)
        {
            Messages = message;
        }
    }
}
