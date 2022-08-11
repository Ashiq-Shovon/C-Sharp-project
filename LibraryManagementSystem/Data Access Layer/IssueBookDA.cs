using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Data_Access_Layer
{
    
    class IssueBookDA
    {
        DataAccess da;
        public IssueBookDA()
        {
             da = new DataAccess();
        }
        public List<string> GetIssueBooks()
        {
            string sql = "select BookName from Books";
            SqlDataReader reader = da.GetData(sql);
            //SqlDataReader sdr = cmd.ExecuteReader();
            List<string> list = new List<string>();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    list.Add(reader.GetString(i));


                }
            }

            return list;
        }
        public DataSet GetStudent(string eid)
        {
            string sql = "select * from NewStudents where enroll='" + eid + "' ";
            return da.GetData1(sql);
        }
        public DataSet BookCount(string eid)
        {
            string sql = "select * from IRBooks where std_enroll='" + eid + "'";
            return da.GetData1(sql);
        }
        public int IssuedBooks(IRBook std)
        {
            string sql = "Insert into IRBooks(std_enroll,std_name,std_dep,std_sem,std_contact,std_email,book_name,book_issue_date,book_return_date)values('" + std.Enroll+"','"+std.Name+"','"+std.Department+"','"+std.Semester+"',"+std.Contact+",'"+std.Email+"','"+std.BookName+"','"+std.BookIssueDate+"','"+""+"')";

            return da.ExecuteQuery(sql);
        }
    }
}
