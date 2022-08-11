using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Data_Access_Layer
{
    class Librarian
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string DateOfReg { get; set; }
        public string BloodGroup { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
    }
}
