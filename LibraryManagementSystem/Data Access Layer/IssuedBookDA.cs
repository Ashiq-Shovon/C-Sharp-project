using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Data_Access_Layer
{
    class IssuedBookDA
    {
        DataAccess da;
        public IssuedBookDA()
        {
            da = new DataAccess();
        }

        public List<IssuedBook> GetBooks(string name)
        {
           
            string sql = "select id, book_name, book_issue_date from IRBooks where std_name='" + name + "'";
            SqlDataReader reader = da.GetData(sql);
            List<IssuedBook> str = new List<IssuedBook>();
            while (reader.Read())
            {
                IssuedBook ib = new IssuedBook();
                ib.BookId = Convert.ToInt32(reader["id"]);
                ib.BookName = reader["book_name"].ToString();
                ib.BookIssueDate = reader["book_issue_date"].ToString();
                str.Add(ib);
            }
            return str;
        }
    }
}
