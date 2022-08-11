using LibraryManagementSystem.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Business_Layer
{
    class IssuedBookService
    {
        IssuedBookDA books;
        public IssuedBookService()
        {
            books = new IssuedBookDA();

        }
        public List<IssuedBook> Book { get; set; }
        public void GetBooks(string name)
        {
            Book = books.GetBooks(name);
        }
    }
}
