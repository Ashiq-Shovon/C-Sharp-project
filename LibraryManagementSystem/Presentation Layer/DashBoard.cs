using AddStudent;
using LibraryManagementSystem.Business_Layer;
using LibraryVideo;
using managemant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Presentation_Layer
{
    public partial class DashBoard : Form
    {
        RegistrationService regService; 
        public DashBoard()
        {
            InitializeComponent();
            regService = new RegistrationService();
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBooks addBook = new AddBooks();
            addBook.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

          
                Login log = new Login();
                this.Hide();
                log.Show();
           
                
        }

        private void viewBookInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBooks vb = new ViewBooks();
            vb.Show();
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBooks isb = new IssueBooks();
            isb.Show();
        }

       
        
        
        
        public MenuStrip LibrarianMenuStrip { get { return librarianMenuStrip; } }
        public MenuStrip AdminMenuStrip { get { return adminMenuStrip; } }
        public MenuStrip StudentMenuStrip { get { return studentMenuStrip; } }
        public Panel AdminPanel { get { return adminPanel; } }
        public Panel StudentPanel { get { return stdPanel; } }
        public Panel LibrarinPanel { get { return libPanel; } }
        

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void librarianMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void addLibrarianToolStripMenuItem_Click(object sender, EventArgs e)
        {

            LibrarianInformation libInfo = new LibrarianInformation();
            libInfo.Show();

    
          
        }

        private void viewLibrarianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "LibrarianInformation")
                {
                    isOpen = true;
                    break;
                }
            }
            if (isOpen == false)
            {
                StudentInformation si = new StudentInformation();
                si.Show();
            }
            
        }

        private void viewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewIssuedBooks books = new ViewIssuedBooks();
            books.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void searchBookToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AvailableBooks ab = new AvailableBooks();
            ab.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void studentMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            //byte[] img = regService.GetPic(Login.UserName);
            
            MemoryStream ms = new MemoryStream(Login.Img);
            if(Login.UserName == Login.Userdb && Login.Status == "Admin")
            {
                adminPicBox.Image = Image.FromStream(ms);
            }
            else if(Login.UserName == Login.Userdb && Login.Status == "Librarian")
            {
                libPicBox.Image = Image.FromStream(ms);
            }
            else
            {
                stdPicBox.Image = Image.FromStream(ms);
            }
            
            
           
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBook rb = new ReturnBook();
            rb.Show();
        }

        private void viewStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudentInformation vbi = new ViewStudentInformation();
            vbi.Show();
        }

        private void viewLibrarianToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            StudentInformation stdInfo = new StudentInformation();
            stdInfo.Show();
        }

        private void libPicBox_Click(object sender, EventArgs e)
        {
            
        }
    }
}
