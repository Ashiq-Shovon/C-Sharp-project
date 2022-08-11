using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Data_Access_Layer
{
    class LoginDA
    {
        DataAccess dataAccess;
        public LoginDA()
        {
            dataAccess = new DataAccess();
        }
        public string[] LoginIfo(string userName, string password)
        {
            string[] str = new string[3];
            string sql = "SELECT * FROM Users WHERE Username='" + userName + "' and Password ='" + password + "'";

            SqlDataReader reader = dataAccess.GetData(sql);
            while (reader.Read())
            {
                str[0] = reader["Username"].ToString();
                str[1] = reader["Password"].ToString();
                str[2] = reader["Status"].ToString();
            }
            return str;
        }
        public string GetPicPath(string name, string pass)
        {
            string sql = "select Picture from LibraryMembers Where UserName='" + name + "' and Password='" + pass + "'";
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();
            string pic = reader["Picture"].ToString();
            return pic;
        }

        public byte[] GetImg(string name)
        {
            string sql = "select Picture from LibraryMembers where UserName='" + name + "'";
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();
            byte[] img = (byte[])reader["Picture"];
            return img;
        }
        public byte[] GetPic(string name,string pass)
        {
            string sql = "select * from LibraryMembers where Username='" + name + "' and Password='"+pass+"'";
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();
            byte[] pic = (byte[])reader["Picture"];
            return pic;
        }
    }
}
