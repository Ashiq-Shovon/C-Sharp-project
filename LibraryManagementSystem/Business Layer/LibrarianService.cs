using LibraryManagementSystem.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Business_Layer
{
    class LibrarianService
    {
        LibrarianDA libDA;
        Librarian lib;
        public LibrarianService()
        {
            libDA = new LibrarianDA();
            lib = new Librarian();
        }
        public string Id { get; set; }
        public Librarian GetLibrarian { get { return lib; } }
        public List<Librarian> GetAllData()
        {
            return libDA.GetAllData();
        }
        public void Search()
        {
            lib = libDA.Search(Id);
        }
        public int UpdateLibrarian(string id, params string[] a)
        {
          
            lib.Name = a[0];
            lib.Email = a[1];
            lib.Contact = a[2];
            lib.Address = a[3];
            lib.Gender = a[4];
            lib.DateOfReg = a[5];
            lib.Status = a[6];
            lib.BloodGroup = a[7];

            return libDA.UpdateLibrarian(id,lib);
        }
        public int DeleteLibrarian(string userid)
        {
            return libDA.DeleteLibrarian(userid);
        }
    }
}
