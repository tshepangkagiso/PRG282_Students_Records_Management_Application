using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Students_Records_Management_Application.Data.Models
{
    internal class Admin
    {
        private string AdminName { get; set; }
        private string Password { get; set; }
        private string ConfirmPassword { get; set; }

        public Admin()
        {
            
        }

        private Admin(string adminName, string password, string confirmPassword)
        {
            this.AdminName = adminName;
            this.Password = password;
            this.ConfirmPassword = confirmPassword;
        }

        //returns null if admin details are wrong, else return the admin object
        public static bool GetAdmin(string name, string password, string confirmPassword)
        {
            Admin admin = new Admin("lecturer", "bclecturer", "bclecturer");
            if (name == admin.AdminName && password == admin.Password && confirmPassword == admin.ConfirmPassword)
            {
                return true;
            }
            else
            {
               
                return false;
            }
        }

        public static bool GetAdmin(string name, string password)
        {
            Admin admin = new Admin("lecturer", "bclecturer", "bclecturer");
            if (name == admin.AdminName && password == admin.Password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
