using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDAL;
using LibraryModels;

namespace LibraryBLL
{
    public class UsersBLL
    {
        LibraryDAL.UsersDAL usersDAL;

        public UsersBLL()
        {
            usersDAL=new LibraryDAL.UsersDAL();
        }

        public List<User> GetUsers()
        {
            return usersDAL.GetUsers();
        }

        public int DeleteUser(int UserId)
        {
            return usersDAL.DeleteUser(UserId);
        }
    }
}
