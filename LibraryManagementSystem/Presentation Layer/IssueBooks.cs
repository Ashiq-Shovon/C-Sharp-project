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

namespace managemant
{
    public partial class IssueBooks : Form
    {
        BookService bookService;
        public IssueBooks()
        {
            InitializeComponent();
            bookService = new BookService();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            List<string> str = bookService.GetIssueBooks();
            
            for (int i = 0; i < str.Count; i++)
               {
                  comboBoxBooks.Items.Add(str[i]);
                }
        }
        int count;
        string eid;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtEnrollement.Text != "")
            {
                eid = txtEnrollement.Text;
               
                DataSet DS = bookService.GetStudent(eid);
                
                count = int.Parse(DS.Tables[0].Rows[0][0].ToString());


                //'''''''''''''''''''''''''''''''''''''''''''''''''''

                if (DS.Tables[0].Rows.Count!=0)
                {
                    txtName.Text = DS.Tables[0].Rows[0][1].ToString();
                    txtDep.Text = DS.Tables[0].Rows[0][3].ToString();
                    txtSem.Text = DS.Tables[0].Rows[0][4].ToString();
                    txtContact.Text = DS.Tables[0].Rows[0][5].ToString();
                    txtEmail.Text = DS.Tables[0].Rows[0][6].ToString();
                }
                else
                {
                    ClearText();
                    MessageBox.Show("Invalid Enrollement No","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                   

                }
            }
            else
            {
                MessageBox.Show("Invalid Enrollement No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ClearText()
        {
            txtName.Text = txtEmail.Text = txtDep.Text = txtEnrollement.Text = txtSem.Text = txtContact.Text =  string.Empty;
            comboBoxBooks.ResetText();
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {

            if (txtName.Text!= "")
            {
                DataSet ds = bookService.BookCount(eid);
                int Count = ds.Tables[0].Rows.Count;
                if (comboBoxBooks.SelectedIndex != -1 && Count<=2)
                {
                    
                    int contact = int.Parse(txtContact.Text);
                    
                  
                    
                    int result = bookService.IssuedBooks(txtEnrollement.Text, txtName.Text, txtDep.Text, txtSem.Text, contact, txtEmail.Text, comboBoxBooks.Text, dateTimePicker.Text);
                    if (result > 0)
                    {
                        MessageBox.Show("Book Issued.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearText();
                    }

                }

                else
                {
                    MessageBox.Show("Select Book. OR Maximum number of book has been Issued", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }

            }
            else
            {
                MessageBox.Show("Enter valid Enrollement No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txtEnrollement_TextChanged(object sender, EventArgs e)
        {
            if(txtEnrollement.Text==" ")
            {
                ClearText();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtEnrollement.Clear();
            comboBoxBooks.ResetText();
            comboBoxBooks.Items.Clear();
            ClearText();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure?", "Conformation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }   
        }
    }
}
