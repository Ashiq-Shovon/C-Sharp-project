using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Data_Access_Layer
{
    class StudentDA
    {
        DataAccess da;
        public StudentDA()
        {
            da = new DataAccess();
        }
        public List<UserStudent> GetAllData()
        {
            string status = "Student";
            string sql = "select * from LibraryMembers Where Member_status='" + status + "'";
            SqlDataReader reader = da.GetData(sql);
            List<UserStudent> str = new List<UserStudent>();

            while (reader.Read())
            {
                UserStudent std = new UserStudent();
                std.UserId = (int)reader["UserId"];
                std.Name = reader["Name"].ToString();
                std.DateOfReg = reader["Date_Of_Reg"].ToString();
                std.Status = reader["Member_status"].ToString();
                std.BloodGroup = reader["Blood_Group"].ToString();
                std.Email = reader["Email"].ToString();
                std.Contact = Convert.ToInt32(reader["Contact"]);
                std.Address = reader["Address"].ToString();
                std.Gender = reader["Gender"].ToString();
                str.Add(std);
            }
            return str;
        }

        public UserStudent SearchStudent(string id)
        {
            string sql = "select * from LibraryMembers where UserId=" + id;
            SqlDataReader reader = da.GetData(sql);
            reader.Read();
            UserStudent std = new UserStudent();
            std.Name = reader["Name"].ToString();
            std.DateOfReg = reader["Date_Of_Reg"].ToString();
            std.Status = reader["Member_status"].ToString();
            std.BloodGroup = reader["Blood_Group"].ToString();
            std.Email = reader["Email"].ToString();
            std.Contact = Convert.ToInt32(reader["Contact"]);
            std.Address = reader["Address"].ToString();
            std.Gender = reader["Gender"].ToString();

            return std;
        }

        public List<Student> GetStudentData()
        {
            string sql = "select * from NewStudents";
            SqlDataReader reader = da.GetData(sql);
            List<Student> list = new List<Student>();
            while(reader.Read())
            {
                Student std = new Student();
                std.UserId = (int)reader["stuid"];
                std.Sname = reader["sname"].ToString();
                std.Enroll = reader["enroll"].ToString();
                std.Sdep = reader["dep"].ToString();
                std.Sem = reader["sem"].ToString();
                std.Contact = (int)reader["contact"];
                std.Email = reader["email"].ToString();
                list.Add(std);

            }
            return list;
        }
        public List<Student> SearchByEnroll(string enroll)
        {
            string sql = "select * from NewStudents where enroll like '"+ enroll+"%'";
            SqlDataReader reader = da.GetData(sql);
            List<Student> list = new List<Student>();
            while(reader.Read())
            {
                Student std = new Student();
                std.UserId = (int)reader["stuid"];
                std.Sdep = reader["dep"].ToString();
                std.Sem = reader["sem"].ToString();
                std.Email = reader["email"].ToString();
                std.Enroll = reader["enroll"].ToString();
                std.Sname = reader["sname"].ToString();
                std.Contact = (int)reader["contact"];
                list.Add(std);
            }

            return list;
        }
        public int AddStudent(Student std)
        {
            string sql = "insert into NewStudents(sname,enroll,dep,sem,contact,email) values('" + std.Sname + "','" + std.Enroll + "','" + std.Sdep + "','" + std.Sem + "','" + std.Contact + "','" + std.Email + "')";
            return da.ExecuteQuery(sql);
        }
        public int EditStudent(Student std)
        {
            string sql = "update NewStudents set sname ='" + std.Sname + "',enroll='" + std.Enroll + "',dep='" + std.Sdep + "',sem = '" + std.Sem + "',contact = '" + std.Contact + "',email='" + std.Email + "' where stuid="+ std.UserId;
            return da.ExecuteQuery(sql);
        }

        public int UpdateStudent(UserStudent std, string UserId)
        {
            
              string sql =  "update LibraryMembers set Name='" + std.Name+ "',Member_status='" +std.Status + "', Date_Of_Reg='" + std.DateOfReg + "',Blood_Group='" + std.BloodGroup + "',Email='" + std.Email + "',Contact='" + std.Contact + "',Address='" + std.Address + "' where UserId=" + UserId;
            return da.ExecuteQuery(sql);
        }
        public int DeleteStudent(int rowid)
        {
            string sql = "delete NewStudents from NewStudents where stuid=" + rowid;
            return da.ExecuteQuery(sql);
        }
        public int RemoveStudent(string userId)
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
