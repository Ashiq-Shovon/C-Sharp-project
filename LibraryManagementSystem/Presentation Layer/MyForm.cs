
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

namespace First_WF_App_G_
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
            //this.Text = "Hello";
        }

        private void clickButton_Click(object sender, EventArgs e)
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
                    if((maleRadioButton.Checked==false)&&(femaleRadioButton.Checked==false))
                    {
                        MessageBox.Show("Please select gender");
                    }
                    else if(dateOfBirthPicker.Value.Date==DateTime.Now.Date)
                    {
                        MessageBox.Show("Please select date of birth");
                    }
                    else if (bloodGroupComboBox.SelectedItem==null)
                    {
                        MessageBox.Show("Please select blood group");
                    }
                    else if (conditionCheckBox.Checked == false)
                    {
                        MessageBox.Show("Please select the agreement");
                    }
                    else
                    {
                        string name, username, password, gender, dob, bg, pic;
                        name = nameTextBox.Text;
                        username = usernameTextBox.Text;
                        password = passwordTextBox.Text;
                        if (maleRadioButton.Checked)
                            gender = "Male";
                        else
                            gender = "Female";
                        dob = dateOfBirthPicker.Value.Date.ToString();
                        bg = bloodGroupComboBox.SelectedItem.ToString();
                        pic = path;

                        //int i=db.AddUser(name,username,password,gender,dob,bg,pic);
                        int i = 0;
                        if (i == 1)
                        {
                            MessageBox.Show("User added successfully");
                        }
                       
                    }
                }
            }
            

             
           
        }

        public TextBox PersonName
        {
            get { return nameTextBox; }
        }
        public DateTimePicker DateofBirth
        {
            get { return dateOfBirthPicker; }
        }
        public ComboBox BloodGroup
        {
            get { return bloodGroupComboBox; }
        }

        private void MyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        string path;
        static int count = 0;
        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                count++;
                pictureBox1.Image = new Bitmap(fd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                path = @"F:\Pictures\Cadet College pic\"+count+".jpg";
                File.Copy(fd.FileName, path, true);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                count++;
                pictureBox1.Image = new Bitmap(fd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                path = @"F:\Pictures\Cadet College pic\" + count + ".jpg";
                File.Copy(fd.FileName, path, true);
            }
        }
    }
}
