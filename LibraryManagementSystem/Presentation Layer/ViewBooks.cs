using LibraryManagementSystem.Business_Layer;
using LibraryManagementSystem.Data_Access_Layer;
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
    public partial class ViewBooks : Form
    {
        BookService bookService;
        public ViewBooks()
        {
            InitializeComponent();
            bookService = new BookService();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            textBox1.Clear();
            BookService bookService = new BookService();
            dataGridView.DataSource = bookService.GetAllData1().Tables[0];
        }

         void ClearText()
        {
            bNameTxtBox.Text = bAuthorTxtBox.Text = bPriceTxtBox.Text = bPurchaseDateTxtBox.Text = bPubTxtBox.Text = bQuantityTxtBox.Text = string.Empty;
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewBooks_Load(object sender, EventArgs e)
        {
            bookService = new BookService();
            panel1.Visible = false;
            //dataGridView.DataSource = bookService.GetAllData();
           
           dataGridView.DataSource = bookService.GetAllData1().Tables[0];

        }
        int bookId;
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            panel1.Visible = true;
            bookId = (int)dataGridView.Rows[e.RowIndex].Cells[0].Value;
            bNameTxtBox.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            bAuthorTxtBox.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            bPubTxtBox.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            bPurchaseDateTxtBox.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            bPriceTxtBox.Text = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            bQuantityTxtBox.Text = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
         }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be updated", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bookService = new BookService();
                double price = Convert.ToDouble(bPriceTxtBox.Text);
                float pri = (float)price;
                int result = bookService.EditBook(bookId, bNameTxtBox.Text, bAuthorTxtBox.Text, bPubTxtBox.Text, bPurchaseDateTxtBox.Text, pri, Convert.ToInt32(bQuantityTxtBox.Text));
                ClearText();
                bookService.GetAllData1();
                //AddBookService bookService = new AddBookService();
                dataGridView.DataSource = bookService.GetAllData1().Tables[0];
                //if (result > 0)
                //{
                //    MessageBox.Show("Book Updated successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            bookService = new BookService();
            int result = bookService.DeleteBook(bookId);
            ClearText();
            if(result > 0)
            {
                MessageBox.Show("Book deleted successfully", "confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridView.DataSource = bookService.GetAllData1().Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
               
                BookService bookService = new BookService();
                dataGridView.DataSource = bookService.GetSearchData(bNameTxtBox.Text).Tables[0];
            }
            else
            {
                BookService bookService = new BookService();
                dataGridView.DataSource = bookService.GetAllData1().Tables[0];
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
