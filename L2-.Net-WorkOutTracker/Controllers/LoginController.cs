using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WorkOutTracker.Web.Controllers
{
    public class LoginController : Controller
    {
        public void ForgotPassword(string userEmail)
        {
            //code here to forgot password for user
        }

        public void LogOut(int userId)
        {
            //
        }

        public void ResetPassword(string newPassword, string username)
        {
            //code here to reset password
        }

        public bool SignIn(string userName, string password)
        {
            // code here to login
            return true;
        }

        public void SignUp(string userName, string userPassword, string userEmail)
        {
           //code here for registration
        }
        
    }
}