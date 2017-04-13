using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace KurtsMovieRental.Models
{
    public class RentalLog
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int MovieId { get; set; }
        public bool IsCheckedOut { get; set; }
        public DateTime DateCheckedOut { get; set; }
        public DateTime DueDate { get; set; }


        public RentalLog() { }

        public RentalLog(SqlDataReader reader)
        {
            this.Id = (int)reader["Id"];
            this.CustomerId = (int)reader["CustomerId"];
            this.MovieId = (int)reader["MovieId"];
            //this.IsCheckedOut = DateTime.Parse(reader["IsCheckedOut"]);
            //this.DateCheckedOut = DateTime.Parse(reader["DateCheckedOut"]);
            //this.DueDate = DateTime.Parse(reader["DueDate"]);

        }
    }
}