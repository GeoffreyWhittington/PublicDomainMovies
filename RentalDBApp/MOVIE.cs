//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentalDBApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class MOVIE
    {
        public int movie_number { get; set; }
        public string movie_title { get; set; }
        public string description { get; set; }
        public short movie_year_made { get; set; }
        public short genre_id { get; set; }
        public string movie_rating { get; set; }
        public string movie_title_link { get; set; }
    
        public virtual GENRE GENRE { get; set; }
    }
}
