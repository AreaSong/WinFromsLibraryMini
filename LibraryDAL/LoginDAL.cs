using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryModels;
using System.Data.Entity;


namespace LibraryDAL
{
    
    public class LoginDAL
    {
        LibraryModels.User users;
        WinFromsLibraryMiniEntities _DbContext;
        public LoginDAL()
        {
            users = new LibraryModels.User();
            _DbContext = new WinFromsLibraryMiniEntities();
        }

        public User Login(string email,string password)
        {
           users =  _DbContext.Users.FirstOrDefault(u=>u.Email == email && u.Password==password);
            return users == null ? null : users;
        }
    }
}
