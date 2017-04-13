using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace KurtsMovieRental.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public Genre() { }


        public Genre(SqlDataReader reader)
        {
            this.Id = (int)reader["Id"];
            this.Name = reader["Name"].ToString();
        }

    }


}