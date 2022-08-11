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
    public partial class LibrarianInformation : Form
    {
        LibrarianService libService;
        
        public LibrarianInformation()
        {
            InitializeComponent();
            libService = new LibrarianService();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LibrarianInformation_Load(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            if (idTxtBox.Text != "" && idTxtBox.Text != "Search by Id" )
            {
                libService.Id = idTxtBox.Text;
                libService.Search();
                nameTxtBox.Text = libService.GetLibrarian.Name;
                emailTxtBox.Text = libService.GetLibrarian.Email;
                contactTxtBox.Text = libService.GetLibrarian.Contact;
                addressTxtBox.Text = libService.GetLibrarian.Address;
                genderTxtBox.Text = libService.GetLibrarian.Gender;
                dateTxtBox.Text = libService.GetLibrarian.DateOfReg;
                statusTxtBox.Text = libService.GetLibrarian.Status;
                bloodTxtBox.Text = libService.GetLibrarian.BloodGroup;
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

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = libService.GetAllData();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if(idTxtBox.Text != "" && idTxtBox.Text != "Search by Id")
            {
                int result = libService.UpdateLibrarian(idTxtBox.Text, nameTxtBox.Text, emailTxtBox.Text, contactTxtBox.Text, addressTxtBox.Text, genderTxtBox.Text, dateTxtBox.Text, statusTxtBox.Text, bloodTxtBox.Text);
                if (result > 0)
                {
                    MessageBox.Show("Update Successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                dataGridView.DataSource = libService.GetAllData();
                ClearText();
            }
            else
            {
                MessageBox.Show("Please enter a valid Id", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (idTxtBox.Text != "" && idTxtBox.Text != "Search by Id")
            {
                int result = libService.DeleteLibrarian(idTxtBox.Text);
                if (result == 2)
                {
                    MessageBox.Show("Delete Successfully","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dataGridView.DataSource = libService.GetAllData();
                ClearText();

            }
            else
            {
                MessageBox.Show("Please enter a valid Id", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        

        private void idTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void idTxtBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (idTxtBox.Text == "Search by Id")
            {
                idTxtBox.Clear();
            }
        }

        private void idTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            
        }
    }
}
