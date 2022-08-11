using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Data_Access_Layer
{
    class BookDA
    {
        DataAccess da;
        public BookDA()
        {
            da = new DataAccess();
        }

        public int AddBook(Book book)
        {
            string sql = "INSERT INTO Books(BookName, BookAuthor, BookPublication, BookPurchaseDate, BookPrice, BookQuantity) VALUES('" + book.BookName + "','" + book.BookAuthorName + "','" + book.BookPublication + "','" + book.BookPurchaseDate + "'," + book.BookPrice + "," + book.BookQuantity + ")";
            return da.ExecuteQuery(sql);
        }

        public List<Book> GetAllData()
        {
            string sql = "SELECT * FROM Books";
            SqlDataReader reader = da.GetData(sql);

            List<Book> list = new List<Book>();
            while(reader.Read())
            {
                Book b = new Book();
                b.BookId = (int)reader["BookId"];
                b.BookName = reader["BookName"].ToString();
                b.BookAuthorName = reader["BookAuthor"].ToString();
                b.BookPublication = reader["BookPublication"].ToString();
                b.BookPurchaseDate = reader["BookPurchaseDate"].ToString();
                double price = Convert.ToDouble(reader["BookPrice"]);
                b.BookPrice = (float)price;
                b.BookQuantity = (int)reader["BookQuantity"];
               
                list.Add(b);
            }

            return list;
        }
        public List<AvailableBooks> GetAvailableBooks()
        {
            string sql = "select BookId, BookName, BookAuthor, BookPublication from Books";
            SqlDataReader reader = da.GetData(sql);
            List<AvailableBooks> str = new List<AvailableBooks>();
            while(reader.Read())
            {
                AvailableBooks b = new AvailableBooks();
                b.BookId = Convert.ToInt32(reader["BookId"]);
                b.BookName = reader["BookName"].ToString();
                b.BookAuthorName = reader["BookAuthor"].ToString();
                b.BookPublication = reader["BookPublication"].ToString();
                str.Add(b);
            }
            return str;
        }
        public DataSet GetAllData1()
        {
            string sql = "SELECT * FROM Books";
            return da.GetData1(sql);
        }

        public DataSet GetSearchData(string bookName)
        {
            string sql = "SELECT * FROM Books WHERE BookName LIKE'" + bookName +"%'";
            return da.GetData1(sql);
        }
        public int EditBook(Book b)
        {
            string sql = "UPDATE Books SET BookName='" + b.BookName + "',BookAuthor='" + b.BookAuthorName + "',BookPublication='" + b.BookPublication + "',BookPurchaseDate='" + b.BookPurchaseDate + "',BookPrice=" + b.BookPrice + ",BookQuantity=" + b.BookQuantity + " WHERE BookId="+b.BookId;
            return da.ExecuteQuery(sql);
        }

        public int DeleteBook(int bookId)
        {
            string sql = "DELETE Books FROM Books WHERE BookId=" + bookId;
            return da.ExecuteQuery(sql);
        }
    }
}
