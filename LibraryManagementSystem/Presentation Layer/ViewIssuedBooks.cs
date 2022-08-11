using AddStudent;
using LibraryManagementSystem.Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Presentation_Layer
{
    public partial class ViewIssuedBooks : Form
    {
        IssuedBookService issue;
        public ViewIssuedBooks()
        {
            InitializeComponent();
            issue = new IssuedBookService();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void an1_Click(object sender, EventArgs e)
        {

        }

        private void ViewIssuedBooks_Load(object sender, EventArgs e)
        {
            
            
            issue.GetBooks(Login.UserName);
            //int book1= issue.Book[0].BookId;
            //int book2 = issue.Book[1].BookId;
            //int book3 = issue.Book[2].BookId;

            
                bn1.Text += issue.Book[0].BookName;
                issued1.Text += issue.Book[0].BookIssueDate;
           
                bn2.Text += issue.Book[1].BookName;
                issued2.Text += issue.Book[1].BookIssueDate;

            
                bn3.Text += issue.Book[2].BookName;
                issued3.Text += issue.Book[2].BookIssueDate;
           
                







        }

        private void an2_Click(object sender, EventArgs e)
        {

        }
    }
}
