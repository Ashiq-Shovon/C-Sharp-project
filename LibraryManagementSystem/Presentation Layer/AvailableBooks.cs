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
    public partial class AvailableBooks : Form
    {
        BookService bookService;
        public AvailableBooks()
        {
            InitializeComponent();
            bookService = new BookService();
        }

        

        private void viewButton_Click(object sender, EventArgs e)
        {
            bookDataGridView.DataSource = bookService.GetAvailableBooks();
        }
    }
}
