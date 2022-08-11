using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Data_Access_Layer
{
    class RegistrationDA
    {

        DataAccess da;
        public RegistrationDA()
        {
            da = new DataAccess();
        }

        public int AddMember( params object[] a)
        {
            string sql = "insert into LibraryMembers(Name, Username, Password, Member_status, Gender, Date_Of_Reg, Blood_Group, Picture, Email, Contact, Address) values('"+ a[0] + "','" + a[1] + "','" + a[2] + "','" + a[3] + "','" + a[4] + "','" + a[5] + "','" + a[6] + "', @img ,'" + a[8] + "','" + a[9] + "','" + a[10] + "')";
            string Sql = "insert into Users(Username,Password,Status) values('" + a[1] + "','" + a[2] + "','" + a[3] + "')";

            return da.ExecuteQuery(Sql) + da.ExecuteQuery1(sql,(byte[])a[7]);
        }
        
    }
}
