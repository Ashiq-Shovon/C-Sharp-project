using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Data_Access_Layer
{
    class IRBookDetail
    {
        
        public int UserId { get; set; }
        public string Sname { get; set; }
        public string Enroll { get; set; }
        public string Sdep { get; set; }
        public string Sem { get; set; }
        public int Contact{ get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string BookName { get; set; }
        public string BookIssueDate { get; set; }
        public string BookReturnDate { get; set; }

        //txtEnrollement.Text,txtName.Text,txtDep.Text,txtSem.Text,contact,txtEmail.Text,comboBoxBooks.Text,dateTimePicker.Text

    }
}
