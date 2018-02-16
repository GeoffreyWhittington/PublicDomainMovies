using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalDBApp.Models
{
    public class Movie
    {
        public string Movie_Title_Link { get; set; }
        public int Movie_Number { get; set; }
        public string Movie_Title { get; set; }
        public string Description { get; set; }
        public int Movie_Year_Made { get; set; }
        public int Genre_Id { get; set; }
        public string Movie_Rating { get; set; }
        
    }
}

