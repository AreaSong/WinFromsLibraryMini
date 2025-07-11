using LibraryModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDAL
{
    public class BookManagerDAL
    {
        WinFromsLibraryMiniEntities _DbContext;
        LibraryModels.BorrowRecord _BorrowRecord;
        LibraryModels.Book _book;

        public BookManagerDAL()
        {
            _DbContext = new WinFromsLibraryMiniEntities();
            _BorrowRecord = new LibraryModels.BorrowRecord();
            _book = new Book();
        }

        public List<Book> GetBooks()
        {
            var books = _DbContext.Books.ToList();
            return books;
        }

        public int AddBook(int UserId, int BookId)
        {
            try
            {
                _BorrowRecord.UserId = UserId;
                _BorrowRecord.BookId = BookId;
                _BorrowRecord.BorrowDate = DateTime.Now;
                _BorrowRecord.ReturnDate = null;
                _DbContext.BorrowRecords.Add(_BorrowRecord);
                ReduceStock(BookId);
                int i = _DbContext.SaveChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }

        }

        private void ReduceStock(int BookId)
        {
            _book = _DbContext.Books.FirstOrDefault(b => b.BookId == BookId);
            _book.Stock--;
        }
    }
}
