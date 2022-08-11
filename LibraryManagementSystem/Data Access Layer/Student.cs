using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Data_Access_Layer
{
    class Student
    {
        public int UserId { get; set; }
        public string Sname { get; set; }
        public string Enroll { get; set; }
        public string Sdep { get; set; }
        public string Sem { get; set; }
        public int Contact { get; set; }
        public string Email { get; set; }
    }
}
