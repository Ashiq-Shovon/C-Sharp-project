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

namespace LibraryVideo
{
    public partial class ReturnBook : Form
    {
        ReturnBookService rbService;
        public ReturnBook()
        {
            InitializeComponent();
            rbService = new ReturnBookService();
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "data source = DESKTOP-T55DEEO;database = library ; integrated security=True";
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = con;

            //cmd.CommandText = "select * from IRBook where std_enroll = '" + txtEnterEnroll.Text + "'and book_return_date Is NULL";
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();


            //da.Fill(ds);

            //if (ds.Tables[0].Rows.Count !=0)
            //{
            dataGridView1.DataSource = rbService.GetIssueBooks(txtEnterEnroll.Text);
            //}
            //else
            //{
            //    MessageBox.Show("Invalid ID or No Book Issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}




        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            txtEnterEnroll.Clear();
        }

        string bname;
        string bdate;
        int? rowid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value !=null);
            {
                rowid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                bname = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                bdate = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            txtBookName.Text = bname;
            txtBookIssueDate.Text = bdate;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            
            int result = rbService.ReturnBook(txtEnterEnroll.Text, dateTimePicker1.Text, rowid);
            if(result > 0)
            {
                MessageBox.Show("Return date updated successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //if(rowid != null)
            //{

            //}
            

        }

        private void txtEnterEnroll_TextChanged(object sender, EventArgs e)
        {
            if (txtEnterEnroll.Text == "")
            {
                panel2.Visible = false;
                dataGridView1.DataSource = null;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtEnterEnroll.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
    }
}
