using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Data_Access_Layer
{
    public class DataAccess : IDisposable
    {
        SqlConnection con;
        SqlCommand command;
        public DataAccess()
        {
           con = new SqlConnection(ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString);
            con.Open();
        }

        public SqlDataReader GetData(string sql)
        {
            command = new SqlCommand(sql, con);
            return command.ExecuteReader();
        }

        public DataSet GetData1(string sql)
        {
            
            command = new SqlCommand(sql, con);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        public int ExecuteQuery(string sql)
        {
            command = new SqlCommand(sql, con);
            return command.ExecuteNonQuery();
        }
        public int ExecuteQuery1(string sql,byte[] img)
        {
            command = new SqlCommand();
            command.CommandText = sql;
            command.Connection = con;
            command.Parameters.AddWithValue("@img", img);
            return command.ExecuteNonQuery();
        }

        public void Dispose()
        {
            con.Close();
        }
     

    }
}
