using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Website
{
    static class DalManager
    {
        private static string cs = @"Server=THOUGAARD;Database=MCU;Trusted_Connection=True;";

        public static List<Movie> GetMovies()
        {
            List<Movie> movieList = new List<Movie>();
            //Selects the data we want from database
            string getMovie = "SELECT FID, Title, Year, Show_time, Genre, Descr FROM Movies";

            using (SqlConnection connection = new SqlConnection(cs))
            {
                //Connects to the database
                connection.Open();
                //Get and request data from database.
                SqlCommand cmd = new SqlCommand(getMovie, connection);
                SqlDataReader rdr = cmd.ExecuteReader();
                //Loop through all data once
                while (rdr.Read())
                {
                    int id = (int)rdr["FID"];
                    string title = (string)rdr["Title"];
                    int year = (int)rdr["Year"];
                    string showTime = (string)rdr["Show_time"];
                    string genre = (string)rdr["Genre"];
                    string descr = (string)rdr["Descr"];

                    //Create a movie object with the following parameters with data from database
                    Movie movie = new Movie(id, title, year, showTime, genre, descr);
                    //Add the movie to the list of movieList
                    movieList.Add(movie);
                }
                return movieList;
            }
        }

        public static List<Actor> GetActors()
        {
            List<Actor> actorList = new List<Actor>();
            //Selects the data we want from database
            string getActor = "SELECT SID, FirstName, LastName FROM Actors";

            using (SqlConnection connection = new SqlConnection(cs))
            {
                //Connects to the database
                connection.Open();
                //Get and request data from database.
                SqlCommand cmd = new SqlCommand(getActor, connection);
                SqlDataReader rdr = cmd.ExecuteReader();
                //Loop through all data once
                while (rdr.Read())
                {
                    int id = (int)rdr["SID"];
                    string firstName = (string)rdr["FirstName"];
                    string lastName = (string)rdr["Lastname"];
                    //Create a actor object with the following parameters with data from database
                    Actor actor = new Actor(id, firstName, lastName);
                    //Add the actor to the list of actorList
                    actorList.Add(actor);
                }
            }
            return actorList;
        }

        public static List<Movie> GetMovieSearch(string search)
        {
            List<Movie> movieList = new List<Movie>();
            //Selects the data we want from database
            string getMovie = "SELECT FID, Title, Year, Show_time, Genre,  FROM Movies WHERE Title like @search";

            using (SqlConnection connection = new SqlConnection(cs))
            {
                //Connects to the database
                connection.Open();
                //Get and request data from database.
                SqlCommand cmd = new SqlCommand(getMovie, connection);
                SqlParameter sp = new SqlParameter();
                cmd.Parameters.AddWithValue("@search", search);
                SqlDataReader rdr = cmd.ExecuteReader();
                //Loop through all data once
                while (rdr.Read())
                {
                    int id = (int)rdr["FID"];
                    string title = (string)rdr["Title"];
                    int year = (int)rdr["Year"];
                    string showTime = (string)rdr["Show_time"];
                    string genre = (string)rdr["Genre"];
                    string descr = (string)rdr["Descr"];

                    //Create a movie object with the following parameters with data from database
                    Movie movie = new Movie(id, title, year, genre, showTime, descr);
                    //Add the movie to the list of movieList
                    movieList.Add(movie);
                }
                return movieList;
            }
        }
        public static List<Actor> GetActorsSearch(string search)
        {
            List<Actor> actorList = new List<Actor>();
            //Selects the data we want from database
            string getActor = "SELECT SID, FirstName, LastName FROM Actors WHERE FirstName like @search";

            using (SqlConnection connection = new SqlConnection(cs))
            {
                //Connects to the database
                connection.Open();
                //Get and request data from database.
                SqlCommand cmd = new SqlCommand(getActor, connection);
                SqlParameter sp = new SqlParameter();
                cmd.Parameters.AddWithValue("@search", search);
                SqlDataReader rdr = cmd.ExecuteReader();
                //Loop through all data once
                while (rdr.Read())
                {
                    int id = (int)rdr["SID"];
                    string firstName = (string)rdr["FirstName"];
                    string lastName = (string)rdr["Lastname"];
                    //Create a actor object with the following parameters with data from database
                    Actor actor = new Actor(id, firstName, lastName);
                    //Add the actor to the list of actorList
                    actorList.Add(actor);
                }
            }
            return actorList;
        }
        public static List<Movie> GetMovieGenreSearch(string search)
        {
            List<Movie> movieGenreList = new List<Movie>();
            //Selects the data where genre is like search parameter
            string getMovieGenre = "SELECT FID, Title, Year, Show_time, Genre FROM Movies WHERE Genre like @search";

            using (SqlConnection connection = new SqlConnection(cs))
            {
                //Connects to the database
                connection.Open();
                //Get and request data from database.
                SqlCommand cmd = new SqlCommand(getMovieGenre, connection);
                SqlParameter sp = new SqlParameter();
                cmd.Parameters.AddWithValue("@search", search);
                SqlDataReader rdr = cmd.ExecuteReader();
                //Loop through all data once
                while (rdr.Read())
                {
                    int id = (int)rdr["FID"];
                    string title = (string)rdr["Title"];
                    int year = (int)rdr["Year"];
                    string showTime = (string)rdr["Show_time"];
                    string genre = (string)rdr["Genre"];
                    string descr = (string)rdr["Descr"];


                    //Create a movie object with the following parameters with data from database
                    Movie movieGenre = new Movie(id, title, year, showTime, genre, descr);
                    //Add the movie to the list of movieList
                    movieGenreList.Add(movieGenre);
                }
                return movieGenreList;
            }
        }
    }
}
