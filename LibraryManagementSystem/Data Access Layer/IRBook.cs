using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Data_Access_Layer
{
    class IRBook
    {
        public int Id { get; set; }
        public string Enroll { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Semester { get; set; }
        public int Contact { get; set; }
        public string Email { get; set; }
        public string BookName { get; set; }
        public string BookIssueDate { get; set; }
        public string BookReturnDate { get; set; }
    }
}
