using LibraryManagementSystem.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Business_Layer
{
    
    class LoginService
    {
        LoginDA loginDataAccess;
        public LoginService()
        {
            loginDataAccess = new LoginDA();
        }

        public string[] LoginInfo(string userName, string password)
        {
            return loginDataAccess.LoginIfo(userName, password);
        }
        public string GetPicPath(string name,string pass)
        {
            return loginDataAccess.GetPicPath(name, pass);
        }
        public byte[] GetImg(string name)
        {
            return loginDataAccess.GetImg(name);
        }
        public byte[] GetPic(string name,string pass)
        {
            return loginDataAccess.GetPic(name,pass);
        }
    }
}
