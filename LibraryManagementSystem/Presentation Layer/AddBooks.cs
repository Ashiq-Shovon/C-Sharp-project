using LibraryManagementSystem.Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Presentation_Layer
{
    public partial class AddBooks : Form
    {
        Validation vd;
        public AddBooks()
        {
            InitializeComponent();
            vd = new Validation(this);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            BookService bookService = new BookService();
            if (bNameTxtBox.Text.Equals(string.Empty))
            {

                vd.InvalidBookName();

            }
            else
            {
                vd.ValidBookName();

                if (bAuthorNameTxtBox.Text.Equals(string.Empty))
                {
                    vd.InvalidBookAuthorName();
                }
                else
                {
                    vd.ValidBookAuthorName();
                    if (bPublicationTxtBox.Text.Equals(string.Empty))
                    {
                        vd.InvalidBookPub();


                    }
                    else
                    {
                        vd.ValidBookPub();
                        if (pDateTime.Value > DateTime.Now.Date && pDateTime.Value == DateTime.Now.Date)
                        {

                            vd.InvalidDateTime();
                        }

                        else
                        {
                            pDateTime.Focus();
                            vd.ValidDateTime();
                            if (bPriceTxtBox.Text.Equals(string.Empty))
                            {
                                vd.InvalidPrice();
                            }
                            else
                            {
                                vd.ValidPrice();
                                if (bQuantityTxtBox.Text.Equals(string.Empty))
                                {
                                    vd.InvalidQuantity();
                                }
                                else
                                {
                                    vd.ValidQuantity();
                                    int result = bookService.AddBook(bNameTxtBox.Text, bAuthorNameTxtBox.Text, bPublicationTxtBox.Text, pDateTime.Text, float.Parse(bPriceTxtBox.Text), int.Parse(bQuantityTxtBox.Text));
                                    if (result != 0)
                                    {
                                        MessageBox.Show("Book Added Successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    ClearText();
                                }
                            }
                        }

                    }
                }
            }

        }
        void ClearText()
        {

            bNameTxtBox.Text = bAuthorNameTxtBox.Text = bPublicationTxtBox.Text = pDateTime.Text = bPriceTxtBox.Text = bQuantityTxtBox.Text = string.Empty;
            bnLab.Hide(); banLab.Hide(); bpdLab.Hide(); bPriceLab.Hide(); bqLab.Hide(); bpLab.Hide();
            bnPicBox.Hide(); banPicBox.Hide(); bpdPicBox.Hide(); bPricePicBox.Hide(); bqPicBox.Hide(); bpPicBox.Hide();
        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will delete the unsaved data", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }



        private void bPriceTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (Char.IsDigit(chr) || e.KeyChar == 8)

            { vd.ValidPrice(); }

            else
            {
                e.Handled = true;
                vd.InvalidPrice();
            }
        }



        private void bPriceTxtBox_Leave(object sender, EventArgs e)
        {

            if (bPriceTxtBox.Text.Equals(string.Empty))
                vd.InvalidPrice();

        }




        private void bNameTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (Char.IsLetterOrDigit(chr) || Char.IsWhiteSpace(chr) || e.KeyChar == 8)

            { vd.ValidBookName(); }

            else
            {
                e.Handled = true;
                vd.InvalidBookName();
            }
        }

        private void bNameTxtBox_Leave(object sender, EventArgs e)
        {
            if (bNameTxtBox.Text.Equals(string.Empty))
                vd.InvalidBookName();

        }
        public PictureBox BnPicBox { get { return bnPicBox; } }
        public Label BnLab { get { return bnLab; } }
        public PictureBox BanPicBox { get { return banPicBox; } }
        public Label BanLab { get { return banLab; } }
        public PictureBox BpPicBox { get { return bpPicBox; } }
        public Label BpLab { get { return bpLab; } }
        public PictureBox BPricePicBox { get { return bPricePicBox; } }
        public Label BPriceLab { get { return bPriceLab; } }
        public PictureBox BqPicBox { get { return bqPicBox; } }
        public Label BqLab { get { return bqLab; } }
        public PictureBox BpdPicBox { get { return bpdPicBox; } }
        public Label BpdLab { get { return bpdLab; } }

        private void bAuthorNameTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (Char.IsLetterOrDigit(chr) || Char.IsWhiteSpace(chr) || e.KeyChar == 8)

            { vd.ValidBookAuthorName(); }

            else
            {
                e.Handled = true;
                vd.InvalidBookAuthorName();
            }
        }

        private void bAuthorNameTxtBox_Leave(object sender, EventArgs e)
        {
            if (bAuthorNameTxtBox.Text.Equals(string.Empty))
                vd.InvalidBookAuthorName();
        }

        private void bPublicationTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (Char.IsLetterOrDigit(chr) || Char.IsWhiteSpace(chr) || e.KeyChar == 8  )

            { vd.ValidBookPub(); }

            else
            {
                e.Handled = true;
                vd.InvalidBookPub();
            }
        }

        private void bPublicationTxtBox_Leave(object sender, EventArgs e)
        {
            if (bPublicationTxtBox.Text.Equals(string.Empty))
                vd.InvalidBookPub();
        }

        private void bQuantityTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (Char.IsDigit(chr) || e.KeyChar == 8)

            { vd.ValidQuantity(); }

            else
            {
                e.Handled = true;
                vd.InvalidQuantity();
            }
        }

        private void bQuantityTxtBox_Leave(object sender, EventArgs e)
        {
            if (bQuantityTxtBox.Text.Equals(string.Empty))
                vd.InvalidQuantity();
        }

        

        private void pDateTime_ValueChanged(object sender, EventArgs e)
        {
            if (pDateTime.Value.Date <= DateTime.Now.Date)
            {

                vd.ValidDateTime();
            }

            else
            {
                vd.InvalidDateTime();
            }
        }

        
    }
 }

