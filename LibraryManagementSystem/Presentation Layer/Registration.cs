using LibraryManagementSystem.Business_Layer;
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
    public partial class Registration : Form
    {
        RegistrationService regService;
        public Registration()
        {
            InitializeComponent();
            regService = new RegistrationService();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Equals(string.Empty) || usernameTextBox.Text.Equals(string.Empty) || passwordTextBox.Text.Equals(string.Empty) || confirmPasswordTextBox.Text.Equals(string.Empty))
            {
                MessageBox.Show("Field can not be empty");
            }
            else
            {
                if (passwordTextBox.Text != confirmPasswordTextBox.Text)
                {
                    MessageBox.Show("Password and confirm password must match");
                }
                else
                {
                    if(emailtxtBox.Text.Equals(string.Empty))
                    {
                        MessageBox.Show("Please enter email");
                    }
                    else if(contactTxtBox.Text.Equals(string.Empty))
                    {
                        MessageBox.Show("Please enter contact");
                    }
                    else if(addressTextBox.Text.Equals(string.Empty))
                    {
                        MessageBox.Show("Please enter address");
                    }
                    else if (statusComboBox.SelectedItem == null)
                    {
                        MessageBox.Show("Please select status");
                    }
                    else if ((maleRadioButton.Checked == false) && (femaleRadioButton.Checked == false))
                    {
                        MessageBox.Show("Please select gender");
                    }
                    else if (dateOfBirthPicker.Value.Date != DateTime.Now.Date)
                    {
                        MessageBox.Show("Please select date of birth");
                    }
                    else if (bloodGroupComboBox.SelectedItem == null)
                    {
                        MessageBox.Show("Please select blood group");
                    }
                    else if (conditionCheckBox.Checked == false)
                    {
                        MessageBox.Show("Please select the agreement");
                    }
                    else
                    {
                        string name, username, password, status, gender, doreg, bg, pic, email, contact, address;
                        name = nameTextBox.Text;
                        username = usernameTextBox.Text;
                        password = passwordTextBox.Text;
                        status = statusComboBox.Text;
                        email = emailtxtBox.Text;
                        contact = contactTxtBox.Text;
                        address = addressTextBox.Text;
                        if (maleRadioButton.Checked)
                            gender = "Male";
                        else
                            gender = "Female";
                        doreg = dateOfBirthPicker.Value.Date.ToString();
                        bg = bloodGroupComboBox.SelectedItem.ToString();
                        ImageConverter imgc = new ImageConverter();
                        byte[] img = (byte[])imgc.ConvertTo(pictureBox1.Image,Type.GetType("System.Byte[]"));


                        int i = regService.AddMember(name, username, password, status, gender, doreg, bg,img, email, contact, address);
                        
                        if (i == 2)
                        {
                            MessageBox.Show("User added successfully");
                        }

                    }
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        string path;
        static int count = 0;
        private void browseButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fd = new OpenFileDialog() { Filter = "JPEG|*.jpg",Multiselect=false})
            {
                if(fd.ShowDialog()==DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(fd.FileName);
                }
            }

          
        }
    }
}
