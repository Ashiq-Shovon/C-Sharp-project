using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Presentation_Layer
{
    class Validation
    {
        AddBooks abs;
        public Validation(AddBooks ab)
        {
            abs = ab;
        }
        public void ValidBookName()
        {

            abs.BnPicBox.Image = Properties.Resources.Valid;
            abs.BnLab.ForeColor = Color.Green;
            abs.BnLab.Text = "Valid name";
        }
        public void InvalidBookName()
        {
            abs.BnPicBox.Image = Properties.Resources.Invalid;
            abs.BnLab.ForeColor = Color.Red;
            abs.BnLab.Text = "Please enter book name";
        }
        public void ValidBookAuthorName()
        {
            abs.BanPicBox.Image = Properties.Resources.Valid;
            abs.BanLab.ForeColor = Color.Green;
            abs.BanLab.Text = "Valid name";
        }
        public void InvalidBookAuthorName()
        {
            abs.BanPicBox.Image = Properties.Resources.Invalid;
            abs.BanLab.ForeColor = Color.Red;
            abs.BanLab.Text = "Please enter book author name";
        }

        public void ValidBookPub()
        {
            abs.BpPicBox.Image = Properties.Resources.Valid;
            abs.BpLab.ForeColor = Color.Green;
            abs.BpLab.Text = "Valid Publication";
        }

        public void InvalidBookPub()
        {
            abs.BpPicBox.Image = Properties.Resources.Invalid;
            abs.BpLab.ForeColor = Color.Red;
            abs.BpLab.Text = "Please enter book publication";
        }


        public void ValidDateTime()
        {
            abs.BpdPicBox.Image = Properties.Resources.Valid;
            abs.BpdLab.ForeColor = Color.Green;
            abs.BpdLab.Text = "Valid Date";
        }

        public void InvalidDateTime()
        {
            abs.BpdPicBox.Image = Properties.Resources.Invalid;
            abs.BpdLab.ForeColor = Color.Red;
            abs.BpdLab.Text = "Please enter Date";
        }




        public void ValidPrice()
        {
            abs.BPricePicBox.Image = Properties.Resources.Valid;
            abs.BPriceLab.ForeColor = Color.Green;
            abs.BPriceLab.Text = "Valid number";
        }
        public  void InvalidPrice()
        {
            
            abs.BPricePicBox.Image = Properties.Resources.Invalid;
            abs.BPriceLab.ForeColor = Color.Red;
            abs.BPriceLab.Text = "Please Enter a Number";
        }
        public void ValidQuantity()
        {
            
            abs.BqPicBox.Image = Properties.Resources.Valid;
            abs.BqLab.ForeColor = Color.Green;
            abs.BqLab.Text = "Valid number";
        }
        public void InvalidQuantity()
        {
            abs.BqPicBox.Image = Properties.Resources.Invalid;
            abs.BqLab.ForeColor = Color.Red;
            abs.BqLab.Text = "Please enter Valid Number";
        
        }
    }
}
