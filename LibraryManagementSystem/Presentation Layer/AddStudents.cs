using LibraryManagementSystem.Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddStudent
{
    public partial class Form1 : Form
    {

        StudentService stdService;
        string enroll;
        public Form1()
        {
            InitializeComponent();
            stdService = new StudentService();
        }
        public string Enroll { get { return enroll; } }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            textName.Clear();
            textEnrollNo.Clear();
            textDept.Clear();
            textSemester.Clear();
            textContact.Clear();
            textEmail.Clear();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String name = textName.Text;
            enroll = textEnrollNo.Text;
            String dept = textDept.Text;
            String sem = textSemester.Text;
            int mobile = int.Parse(textContact.Text);
            string email = textEmail.Text;
            int result = stdService.AddStudent(name, enroll, dept, sem, mobile, email);
            
            if(result > 0)
            {
                MessageBox.Show("Data Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
