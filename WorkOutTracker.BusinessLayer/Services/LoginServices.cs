using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.DataLayer.NHibernate;
using WorkOutTracker.BusinessLayer.Interfaces;

namespace WorkOutTracker.BusinessLayer.Services
{
    public class LoginServices : ILoginServices
    {
        private readonly IMapperSession _session;

        public LoginServices(IMapperSession session)
        {
            _session = session;
        }

        public void ForgotPassword(string userEmail)
        {
           
        }

        public void LogOut(int userId)
        {
           
        }

        public void ResetPassword(string newPassword, string username)
        {
            
        }

        public bool SignIn(string userName, string password)
        {
            return true;
        }

        

        public void SignUp(string userName, string userPassword)
        {
            throw new NotImplementedException();
        }
    }
}
