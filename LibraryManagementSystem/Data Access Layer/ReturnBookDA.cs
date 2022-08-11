using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Data_Access_Layer
{
    class ReturnBookDA
    {
        DataAccess da;
        public ReturnBookDA()
        {
            da = new DataAccess();
        }

        public List<IRBook> GetIssueBooks(string enroll)
        {
            string sql = "select * from IRBooks where std_enroll = '" + enroll + "'and book_return_date Is not NULL";
            SqlDataReader reader = da.GetData(sql);
            List<IRBook> list = new List<IRBook>();
            while(reader.Read())
            {
                IRBook irb = new IRBook();
                irb.Id = Convert.ToInt32(reader["id"]);
                irb.Enroll = reader["std_enroll"].ToString();
                irb.Name = reader["std_name"].ToString();
                irb.Department = reader["std_dep"].ToString();
                irb.Semester = reader["std_sem"].ToString();
                irb.Contact = Convert.ToInt32(reader["std_contact"]);
                irb.Email = reader["std_email"].ToString();
                irb.BookName = reader["book_name"].ToString();
                irb.BookIssueDate = reader["book_issue_date"].ToString();
                irb.BookReturnDate = reader["book_return_date"].ToString();
                list.Add(irb);
            }
            return list;
        }

        public int ReturnBook(string enroll,string date,int? rowid)
        {
            string sql = "update IRBooks set book_return_date = '" + date + "'where std_enroll = '" + enroll + "'and id = " + rowid + "";
            return da.ExecuteQuery(sql);
        }
    }
}
