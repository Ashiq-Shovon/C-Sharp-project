using LibraryManagementSystem.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Business_Layer
{
    class StudentService
    {
        StudentDA stdDA;
        UserStudent uStd;
        Student std;
        public StudentService()
        {
            stdDA = new StudentDA();
            uStd = new UserStudent();
            std = new Student();
        }
        public UserStudent GetStudent { get { return uStd; } }
        public Student GetStd { get { return std; } }
        public string Id { get; set; }
        public List<UserStudent> GetAllData()
        {
            return stdDA.GetAllData();
        }
        public int UpdateStudent(params object[] a)
        {



            uStd.Name = a[0].ToString();
            uStd.Email = a[1].ToString();
            uStd.Contact = Convert.ToInt32(a[2]);
            uStd.Address = a[3].ToString();
            uStd.Gender = a[4].ToString();
            uStd.DateOfReg = a[5].ToString();
            uStd.Status = a[6].ToString();
            uStd.BloodGroup = a[7].ToString();


            return stdDA.UpdateStudent(uStd, Id);
        }
        public int EditStudent(int id, string name, string enroll, string dep, string sem, int contact, string email)
        {

            std.UserId = id;
            std.Sname = name;
            std.Enroll = enroll;
            std.Sdep = dep;
            std.Sem = sem;
            std.Contact = contact;
            std.Email = email;

            return stdDA.EditStudent(std);
        }
        

    
        public void SearchSutdent()
        {
            uStd = stdDA.SearchStudent(Id);
        }
        public int RemoveStudent(string id)
        {
            return stdDA.RemoveStudent(id);
        }
        public int AddStudent(params object[] a)
        {
            std.Sname = a[0].ToString();
            std.Enroll = a[1].ToString();
            std.Sdep = a[2].ToString();
            std.Sem = a[3].ToString();
            std.Contact = (int)a[4];
            std.Email = a[5].ToString();

            return stdDA.AddStudent(std);
        }

        public List<Student> GetStudentData()
        {
            return stdDA.GetStudentData();
        }
        public List<Student> SearchByEnroll(string enroll)
        {
            return stdDA.SearchByEnroll(enroll);
        }
        public int DeleteStudent(int rowid)
        {
            return stdDA.DeleteStudent(rowid);
        }
    }
}
