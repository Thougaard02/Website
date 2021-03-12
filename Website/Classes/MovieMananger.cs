using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Website
{
    static class MovieMananger
    {
        public static List<Movie> GetMovies()
        {
            return DalManager.GetMovies();
        }
        public static List<Actor> GetActor()
        {
            return DalManager.GetActors();
        }
        public static List<Movie> GetMovieSearch(string search)
        {
            return DalManager.GetMovieSearch(search);
        }
        public static List<Actor> GetActorSearch(string search)
        {
            return DalManager.GetActorsSearch(search);
        }
        public static List<Movie> GetMovieGenre(string search)
        {
            return DalManager.GetMovieGenreSearch(search);
        }
    }
}
