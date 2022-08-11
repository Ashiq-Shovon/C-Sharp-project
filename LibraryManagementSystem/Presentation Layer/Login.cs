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
    public partial class Login : Form
    {
        LoginService loginService;
        //public string userName;
        string status;
        public Login()
        {
            InitializeComponent();
            loginService = new LoginService();
        }
        public static string Status { get; set; }
        public static string  UserName { get; set; }
        public static byte[] Img { get; set; }
        public static string Userdb { get; set; }
        //public string  Path { get; set; }


        private void loginButton_Click_1(object sender, EventArgs e)
        {
            string password;
            UserName = usernameTxt.Text;
            password = passTxt.Text;
            loginService = new LoginService();
            string[] str = loginService.LoginInfo(UserName, password);
            Userdb = str[0];
            Status = str[2];
            Img = loginService.GetPic(UserName,password);

            status = str[2];
            if ( UserName == str[0] && password == str[1] && str[2] == "Admin")
            {
                DashBoard dash = new DashBoard();
                dash.AdminMenuStrip.Visible = true;
                dash.AdminPanel.Visible = true;
                dash.LibrarianMenuStrip.Visible = false;
                dash.StudentMenuStrip.Visible = false;
                dash.StudentPanel.Visible = false;
                dash.LibrarinPanel.Visible = false;
                dash.Show();
                this.Hide();
            }
            else if (UserName == str[0] && password == str[1] && str[2] == "Librarian")
            {
                DashBoard dash = new DashBoard();
                dash.LibrarianMenuStrip.Visible = true;
                dash.AdminMenuStrip.Visible = false;
                dash.StudentMenuStrip.Visible = false;
                dash.AdminPanel.Visible = false;
                dash.StudentPanel.Visible = false;
                dash.Show();
                this.Hide();
            }
            else if(UserName == str[0] && password == str[1] && str[2] == "Student")
            {
                DashBoard dash = new DashBoard();
                dash.StudentMenuStrip.Visible = true;
                dash.AdminMenuStrip.Visible = false;
                dash.LibrarianMenuStrip.Visible = false;
                dash.AdminPanel.Visible = false;
                dash.LibrarinPanel.Visible = false;
                dash.Show();
                this.Hide();
            }
        }

        private void usernameTxt_MouseClick(object sender, MouseEventArgs e)
        {
            if (usernameTxt.Text == "Username")
            {
                usernameTxt.Clear();
            }
        }

        private void passTxt_MouseClick(object sender, MouseEventArgs e)
        {
            if(passTxt.Text == "Password")
            {
                passTxt.Clear();
                passTxt.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            this.Hide();
            reg.Show();
        }
    }
}
