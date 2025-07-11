using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDAL;
using LibraryModels;

namespace LibraryBLL
{
    public class BookManagerBLL
    {
        LibraryDAL.BookManagerDAL bookManagerDAL;

        public BookManagerBLL()
        {
            bookManagerDAL = new LibraryDAL.BookManagerDAL();
        }

        public List<Book> GetBooks()
        {
            var books = bookManagerDAL.GetBooks();
            return books;
        }

        public int AddBook(int UserId, int BookId)
        {
            return bookManagerDAL.AddBook(UserId, BookId);
        }
    }
}
