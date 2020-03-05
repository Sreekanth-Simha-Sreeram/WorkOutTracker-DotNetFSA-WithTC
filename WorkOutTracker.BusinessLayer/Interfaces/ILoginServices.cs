using System;
using System.Collections.Generic;
using System.Text;

namespace WorkOutTracker.BusinessLayer.Interfaces
{
    public interface ILoginServices
    {
        void SignUp(string userName, string userPassword);
        bool SignIn(string userName, string password);
        void ForgotPassword(string userEmail);
        void ResetPassword(string newPassword, string username);
        void LogOut(int userId);

    }
}
