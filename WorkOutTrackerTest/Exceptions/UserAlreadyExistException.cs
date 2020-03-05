using System;
using System.Collections.Generic;
using System.Text;

namespace WorkOutTracker.Test.Exceptions
{
 public class UserAlreadyExistException :Exception
    {
        public string Messages = "User aleardy exist please login";

        public UserAlreadyExistException(string message)
        {
            Messages = message;
        }
    }
}
