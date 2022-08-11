using LibraryManagementSystem.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Business_Layer
{
    class BookService
    {
        BookDA bookAccess;
        IssueBookDA issueBook;
        public BookService()
        {
            bookAccess = new BookDA();
            issueBook = new IssueBookDA();
        }
        //AddBook
        public int AddBook( params object[] a)
        {
            Book book = new Book()
            {
                BookName = a[0].ToString(),
                BookAuthorName = a[1].ToString(),
                BookPublication = a[2].ToString(),
                BookPurchaseDate = a[3].ToString(),
                BookPrice = (float)a[4],
                BookQuantity = (int)a[5]
            };
                return bookAccess.AddBook(book);
        }
        public DataSet GetAllData1()
        {
            return bookAccess.GetAllData1();
        }
        public DataSet GetSearchData(string bookName)
        {
            return bookAccess.GetSearchData(bookName);
        }

        public List<Book> GetAllData()
        {
            return bookAccess.GetAllData();
        }
        public List<AvailableBooks> GetAvailableBooks()
        {
            return bookAccess.GetAvailableBooks();
        }

        public int EditBook(params object[] a)
        {
            Book b = new Book() { BookId = (int)a[0], BookName = a[1].ToString(), BookAuthorName = a[2].ToString(), BookPublication = a[3].ToString(), BookPurchaseDate = a[4].ToString(), BookPrice = (float)a[5], BookQuantity = (int)a[6] };
            return bookAccess.EditBook(b);
        }
        
        public int DeleteBook(int bookId)
        {
            return bookAccess.DeleteBook(bookId);
        }

        //Issue book
        public List<string> GetIssueBooks()
        {
            return issueBook.GetIssueBooks();
        }
        public DataSet GetStudent(string eid)
        {
            return issueBook.GetStudent(eid);
        }
        public int IssuedBooks(params object[] a)
        {
            IRBook std = new IRBook() {
                Enroll = a[0].ToString(),
                Name = a[1].ToString(),
                Department = a[2].ToString(),
                Semester = a[3].ToString(),
                Contact = (int)a[4],
                Email = a[5].ToString(),
                BookName = a[6].ToString(),
                BookIssueDate = a[7].ToString()
            };

            return issueBook.IssuedBooks(std);
        }

        public DataSet BookCount(string eid)
        {
            return issueBook.BookCount(eid);
        }
        
       
    }
}
