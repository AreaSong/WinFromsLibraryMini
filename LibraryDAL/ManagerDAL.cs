using LibraryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDAL
{
    public class ManagerDAL
    {
        LibraryModels.BorrowRecord borrowRecord;
        WinFromsLibraryMiniEntities _DbContext;
        LibraryModels.Book _book;

        public ManagerDAL()
        {
            borrowRecord = new LibraryModels.BorrowRecord();
            _DbContext = new WinFromsLibraryMiniEntities();
        }

        public List<BorrowRecord> Manager(int i)
        {
            var manager = _DbContext.BorrowRecords.Where(u => u.UserId == i).ToList();
            return manager;
        }

        public int ReturnBook(int RecordId)
        {
            try
            {
                borrowRecord = _DbContext.BorrowRecords.FirstOrDefault(b => b.RecordId == RecordId);
                borrowRecord.ReturnDate = DateTime.Now;
                AddStock(borrowRecord.BookId);
                _DbContext.SaveChanges();
                return 1;
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
           
        }

        private void AddStock(int BookId)
        {
            _book = _DbContext.Books.FirstOrDefault(b => b.BookId == BookId);
            _book.Stock++;
        }

    }
}
