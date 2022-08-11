using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Data_Access_Layer
{
    class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookAuthorName { get; set; }
        public string BookPublication { get; set; }
        public string BookPurchaseDate { get; set; }
        public float BookPrice { get; set; }
        public int  BookQuantity { get; set; }
    }
}
