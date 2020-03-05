using System;
using System.Collections.Generic;
using System.Text;

namespace WorkOutTracker.Test.Exceptions
{
  public  class UserNotFoundException :Exception
    {
        public string Messages = "User not found";

        public UserNotFoundException(string message)
        {
            Messages = message;
        }
    }
}

