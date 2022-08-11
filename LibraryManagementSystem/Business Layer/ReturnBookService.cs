using LibraryManagementSystem.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Business_Layer
{
    class ReturnBookService
    {
        ReturnBookDA rbDA;
        public ReturnBookService()
        {
            rbDA = new ReturnBookDA();
        }
        public List<IRBook> GetIssueBooks(string enroll)
        {
            return rbDA.GetIssueBooks(enroll);
        }
        public int ReturnBook(string enroll,string date,int? rowid)
        {
            return rbDA.ReturnBook(enroll,date,rowid);
        }
    }
}
