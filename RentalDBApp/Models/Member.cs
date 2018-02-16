using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalDBApp.Models
{
   public class Member
    {
        public int Number { get; set; }
        public string Join_Date { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip_Code { get; set; }
        public string Phone { get; set; }
        public char Member_Status { get; set; }
        public string Login_Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Contact_Method { get; set; }
        public int Subscription_Id { get; set; }
        public string Photo { get; set; }
    }
}
