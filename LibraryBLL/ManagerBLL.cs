using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDAL;
using LibraryModels;


namespace LibraryBLL
{
    public class ManagerBLL
    {
        LibraryDAL.ManagerDAL managerDAL;

        public ManagerBLL()
        {
            managerDAL = new LibraryDAL.ManagerDAL();
        }

        public List<BorrowRecord> Manager(int i)
        {
            return managerDAL.Manager(i);
        }

        public int ReturnBook(int RecordId)
        {
            return managerDAL.ReturnBook(RecordId);
        }
    }
}
