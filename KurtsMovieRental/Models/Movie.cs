using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KurtsMovieRental.Models
{
    public class Movie
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int YearReleased { get; set; }
        public string Director { get; set; }
        public int GenreId { get; set; }


        public Movie () { }



    }
}