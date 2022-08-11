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
    public partial class StudentInformation : Form
    {
        StudentService stdService;
        public StudentInformation()
        {
            InitializeComponent();
            stdService = new StudentService();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stdDataGridView.DataSource = stdService.GetAllData();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (idTxtBox.Text != "" && idTxtBox.Text != "Search By Id")
            {
                int result = stdService.UpdateStudent(nameTxtBox.Text, emailTxtBox.Text, contactTxtBox.Text, addressTxtBox.Text, genderTxtBox.Text, dateTxtBox.Text, statusTxtBox.Text, bloodTxtBox.Text);
                if (result > 0)
                {
                    MessageBox.Show("Update Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                stdDataGridView.DataSource = stdService.GetAllData();
                ClearText();
            }
            else
            {
                MessageBox.Show("Please enter a valid Id", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

       

        private void stdButton_Click(object sender, EventArgs e)
        {
            
            if(idTxtBox.Text != "" && idTxtBox.Text != "Search By Id")
            {
                stdService.Id = idTxtBox.Text;
                stdService.SearchSutdent();
                nameTxtBox.Text = stdService.GetStudent.Name;
                dateTxtBox.Text = stdService.GetStudent.DateOfReg;
                statusTxtBox.Text = stdService.GetStudent.Status;
                emailTxtBox.Text = stdService.GetStudent.Email;
                contactTxtBox.Text = stdService.GetStudent.Contact.ToString();
                addressTxtBox.Text = stdService.GetStudent.Address;
                bloodTxtBox.Text = stdService.GetStudent.BloodGroup;
                genderTxtBox.Text = stdService.GetStudent.Gender;
            }
            else
            {
                MessageBox.Show("Please enter a valid Id", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
        void ClearText()
        {
            idTxtBox.Text = nameTxtBox.Text = emailTxtBox.Text = contactTxtBox.Text = addressTxtBox.Text = genderTxtBox.Text = dateTxtBox.Text = statusTxtBox.Text = bloodTxtBox.Text = "";
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (idTxtBox.Text != "" && idTxtBox.Text != "Search By Id")
            {

                int result = stdService.RemoveStudent(idTxtBox.Text);
                if (result > 0)
                {
                    MessageBox.Show("Update Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                stdDataGridView.DataSource = stdService.GetAllData();
                ClearText();
            }
            else
            {
                MessageBox.Show("Please enter a valid Id", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void idTxtBox_MouseEnter(object sender, EventArgs e)
        {

        }

        private void idTxtBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (idTxtBox.Text == "Search By Id")
            {
                idTxtBox.Clear();
            }
        }
    }
}
