using KurtsMovieRental.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace KurtsMovieRental.Services
{
    public class MovieServices
    {
        const string ConnectionString = @"Server=localhost\SQLEXPRESS;Database=MovieRentalDatabase;Trusted_Connection=True;";


        public IEnumerable<Movie> GetAllMovies()
        {
            var rv = new List<Movie>();
            using (var connection = new SqlConnection(ConnectionString))
            {
                var query = "SELECT * FROM Movies JOIN Genres ON Movies.GenreId = Genres.Id;";

                var cmd = new SqlCommand(query, connection);

                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    rv.Add(new Movie(reader));
                }
                connection.Close();
            }
            return rv;
        }

        //Creates New Movie And Adds to Database
        public void CreateMovie(Movie movie)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                var query = "INSERT INTO Movies ([Name], [YearReleased], [Director], " +
                    "[GenreId]) VALUES(@Name, @YearReleased, @Director, @GenreId)";

                var cmd = new SqlCommand(query, connection);

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