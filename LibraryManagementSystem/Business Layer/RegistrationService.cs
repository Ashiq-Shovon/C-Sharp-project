using LibraryManagementSystem.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Business_Layer
{
    class RegistrationService
    {
        RegistrationDA regDA;
        public RegistrationService()
        {
            regDA = new RegistrationDA();
        }

        public int AddMember( params object[] a)
        {

            return regDA.AddMember(a);
        }
        
    }
}
