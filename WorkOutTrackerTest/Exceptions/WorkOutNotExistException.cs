using System;
using System.Collections.Generic;
using System.Text;

namespace WorkOutTracker.Test.Exceptions
{
    class WorkOutNotExistException : Exception
    {
        public string Messages = "WorkOut not exist";

        public WorkOutNotExistException(string message)
        {
            Messages = message;
        }
    }
}
