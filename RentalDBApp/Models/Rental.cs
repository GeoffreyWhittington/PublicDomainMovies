using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalDBApp.Models
{
    public class Rental
    {
        public int Movie_Number { get; set; }
        public int Member_Number { get; set; }
        public string Media_Checkout { get; set; }
        public string Media_Return_Date { get; set; }
    }
}
