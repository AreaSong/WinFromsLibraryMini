using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDAL;
using LibraryModels;

namespace LibraryBLL
{
    public class LoginBLL
    {
        LibraryDAL.LoginDAL libraryDAL;

        public LoginBLL()
        {
            libraryDAL = new LoginDAL();
        }

        public User Login(string email, string password)
        {
            return libraryDAL.Login(email, password);
        }
    }
}
