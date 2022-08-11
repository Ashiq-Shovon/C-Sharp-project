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

namespace AddStudent
{
    public partial class ViewStudentInformation : Form
    {
        StudentService stdService;
        public ViewStudentInformation()
        {
            InitializeComponent();
            stdService = new StudentService();
        }

        private void txtSearchInrollment_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchInrollment.Text != "")
            {
                label1.Visible = false;
                //Image image = Image.FromFile("C:/Users/User/Desktop/Liberay Management System/search1.gif");
                   // pictureBox1.Image = image;

                    //SqlConnection con = new SqlConnection();
                    //con.ConnectionString = "Data Source=.;Initial Catalog=NewStudent;Integrated Security=True";
                    //SqlCommand cmd = new SqlCommand();
                    //cmd.Connection = con;

                    //cmd.CommandText = "select * from Students where enroll like '"+ txtSearchInrollment.Text+"%'";
                    //SqlDataAdapter DA = new SqlDataAdapter(cmd);
                    //DataSet DS = new DataSet();
                    dataGridView1.DataSource = stdService.SearchByEnroll(txtSearchInrollment.Text);
                    //DA.Fill(DS);

                    //        dataGridView1.DataSource = DS.Tables[0];


            }
            else
            {
                label1.Visible = true;
                //Image image = Image.FromFile("C:/Users/User/Desktop/Liberay Management System/search.gif");
                //pictureBox1.Image = image;

                //SqlConnection con = new SqlConnection();
                //con.ConnectionString = "Data Source=.;Initial Catalog=NewStudent;Integrated Security=True";
                //SqlCommand cmd = new SqlCommand();
                //cmd.Connection = con;

                //cmd.CommandText = "select * from Students";
                //SqlDataAdapter DA = new SqlDataAdapter(cmd);
                //DataSet DS = new DataSet();
                //DA.Fill(DS);
                dataGridView1.DataSource = stdService.GetStudentData();
                //dataGridView1.DataSource = DS.Tables[0];
            }
        }

        private void ViewStudentInformation_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=.;Initial Catalog=NewStudent;Integrated Security=True";
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = con;

            //cmd.CommandText = "select * from Students";
            //SqlDataAdapter DA = new SqlDataAdapter(cmd);
            //DataSet DS = new DataSet();
            dataGridView1.DataSource = stdService.GetStudentData();
            //DA.Fill(DS);

            //dataGridView1.DataSource = DS.Tables[0];
        }

        int bid;
        int rowid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;

            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=.;Initial Catalog=NewStudent;Integrated Security=True";
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = con;

            //cmd.CommandText = "select * from Students where studentid = "+bid+"";
            //SqlDataAdapter DA = new SqlDataAdapter(cmd);
            //DataSet DS = new DataSet();
            //DA.Fill(DS);

            rowid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

            txtSName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEnrollment.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDepartment.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSemester.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtContact.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

        }
        void ClearText()
        {
            txtSName.Text = txtEnrollment.Text = txtDepartment.Text = txtSemester.Text = txtContact.Text = txtEmail.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String sname = txtSName.Text;
            String enroll = txtEnrollment.Text;
            String dep = txtDepartment.Text;
            String sem = txtSemester.Text;
            int contact = int.Parse(txtContact.Text);
            String email = txtEmail.Text;

            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=.;Initial Catalog=NewStudent;Integrated Security=True";
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = con;
            int result = stdService.EditStudent(rowid,sname, enroll, dep, sem, contact, email);
            if(result > 0)
            {
                MessageBox.Show("Student Edited Successfully");
            }
            ClearText();
            //cmd.CommandText = "update students set sname ='"+sname+"',enroll='" +enroll+"',dept='"+dep+"',semester = '"+sem+"',contact = '"+contact+"',email='"+email+"' where studentid = "+rowid+"  ";
            //SqlDataAdapter DA = new SqlDataAdapter(cmd);
            //DataSet DS = new DataSet();
            //DA.Fill(DS);
            dataGridView1.DataSource = stdService.GetStudentData();


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int result = stdService.DeleteStudent(rowid);

            if(result > 0)
            {
                MessageBox.Show("Student Deleted Successfully");
            }
            ClearText();
            dataGridView1.DataSource = stdService.GetStudentData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
    }
}
