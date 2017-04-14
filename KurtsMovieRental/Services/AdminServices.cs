using KurtsMovieRental.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace KurtsMovieRental.Services
{
    public class AdminServices
    {
        const string ConnectionString = @"Server=localhost\SQLEXPRESS;Database=MovieRentalDatabase;Trusted_Connection=True;";


        //Creates New Movie And Adds to Database
        public void CreateMovie(Movie movie)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                var query = @"INSERT INTO Movie 
                            ([Name],[YearReleased],[Director],[GenreId])                         
                            VALUES (@Name, @YearReleased, @Director, @GenreId)";

                var cmd = new SqlCommand(query, connection);

                //cmd.Parameters.AddWithValue("@Id", movie.Id);
                cmd.Parameters.AddWithValue("@Name", movie.Name);
                cmd.Parameters.AddWithValue("@YearReleased", movie.YearReleased);
                cmd.Parameters.AddWithValue("@Director", movie.Director);
                cmd.Parameters.AddWithValue("@GenreId", movie.GenreId);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}