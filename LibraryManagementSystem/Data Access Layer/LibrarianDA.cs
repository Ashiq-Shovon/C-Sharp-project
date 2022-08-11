using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Data_Access_Layer
{
    class LibrarianDA
    {
        DataAccess da;
        public LibrarianDA()
        {
            da = new DataAccess();
        }

        public List<Librarian> GetAllData()
        {
            string status = "Librarian";
            string sql = "select * from LibraryMembers where Member_Status='"+status+"'";

            List<Librarian> str = new List<Librarian>();
            SqlDataReader reader = da.GetData(sql);
            while(reader.Read())
            {
                Librarian lib = new Librarian();
                lib.UserId = (int)reader["UserId"];
                lib.Name = reader["Name"].ToString();
                lib.Status = reader["Member_Status"].ToString();
                lib.Gender= reader["Gender"].ToString();
                lib.DateOfReg= reader["Date_Of_Reg"].ToString();
                lib.BloodGroup = reader["Blood_Group"].ToString();
                lib.Email = reader["Email"].ToString();
                lib.Contact = reader["Contact"].ToString();
                lib.Address = reader["Address"].ToString();
                str.Add(lib);
            }
            return str;
        }
        public Librarian Search(string id)
        {
            string sql = "select * from LibraryMembers where UserId=" + id;
            Librarian lib = new Librarian();
            SqlDataReader reader = da.GetData(sql);
            while (reader.Read())
            {
                
                lib.UserId = (int)reader["UserId"];
                lib.Name = reader["Name"].ToString();
                lib.Status = reader["Member_Status"].ToString();
                lib.Gender = reader["Gender"].ToString();
                lib.DateOfReg = reader["Date_Of_Reg"].ToString();
                lib.BloodGroup = reader["Blood_Group"].ToString();
                lib.Email = reader["Email"].ToString();
                lib.Contact = reader["Contact"].ToString();
                lib.Address = reader["Address"].ToString();
                
            }
            return lib;
            
        }

        public int UpdateLibrarian(string id, Librarian lib)
        {
            //string Sql = "select UserId from LibraryMembers where Member_status='" + lib.Status + "'";
            //SqlDataReader reader = da.GetData(Sql);
            //reader.Read();
            //int UserId = (int)reader["UserId"];
            string sql = "update LibraryMembers set Name='"+lib.Name+"',Member_status='"+lib.Status+ "',Gender='" + lib.Gender + "',Date_Of_Reg='" + lib.DateOfReg + "',Blood_Group='" + lib.BloodGroup + "',Email='" + lib.Email + "',Contact='" + lib.Contact + "',Address='" + lib.Address + "' where UserId=" + id;
            return da.ExecuteQuery(sql);
        }

        public int DeleteLibrarian(string userId)
        {
            string Sql = "Select * from LibraryMembers where UserId=" + userId;
            SqlDataReader reader = da.GetData(Sql);
            reader.Read();
            string Username = reader["Username"].ToString();
            string Password = reader["Password"].ToString();

            string sql = "delete from LibraryMembers where UserId=" + userId;
            string sql1 = "delete Users where Username='" + Username + "' and Password='" + Password + "'";

            return da.ExecuteQuery(sql) + da.ExecuteQuery(sql1);
        }
    }
}
