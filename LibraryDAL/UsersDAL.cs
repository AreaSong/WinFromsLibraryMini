using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryModels;

namespace LibraryDAL
{
    public class UsersDAL
    {
        LibraryModels.User user;
      WinFromsLibraryMiniEntities _DbContext;

        public UsersDAL()
        {
            user = new LibraryModels.User();
            _DbContext = new WinFromsLibraryMiniEntities();
        }

        public List<User> GetUsers()
        {
            return _DbContext.Users.ToList();
        }

        public int DeleteUser(int UserId)
        {
            try
            {
                var _DeleteborrowRecords = _DbContext.BorrowRecords.Where(b=>b.UserId == UserId).ToList();
                user = _DbContext.Users.First(u => u.UserId == UserId);
                _DbContext.BorrowRecords.RemoveRange(_DeleteborrowRecords);
                _DbContext.Users.Remove(user);
                _DbContext.SaveChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
