using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieEntityLayer;
namespace MovieDataAccessLayer
{
    public class MovieDAL   
    {
        public static List<Movie> movies = new List<Movie>() { //creting static collection of movies.bcoz currently we dont have database.
        new Movie{Id=1,Name="Abx",Rating = 4,Year=2020 },
        new Movie{Id=2,Name="Bcz",Rating = 3,Year=2002 },
        new Movie{Id=3,Name="Pqr",Rating = 2,Year=2014 },
        new Movie{Id=4,Name="Xyz",Rating = 1,Year=2018 },
        new Movie{Id=5,Name="Mno",Rating = 5,Year=2021 },
        } ;
        public List<Movie> GetMovies()
        {
            return movies;
        }
        public Movie FindMovieDAL(int id) //return movie object after searching in the list
        {
            Movie movie = null;
            try
            {
                movie = movies.Where(m => m.Id == id).FirstOrDefault();  //in system.Linq all extension method is defined.
                //"where" is inbuilt generic extension method. "where" returns ienumerable(it is collection type) movie type.
                //firstordefault = whichever is the first or default value that will be returned.used only when we want single object.

                if (movie == null)
                    throw new Exception("Movie not found");

            }
            catch(Exception ex)
            {
                throw ex ;
            }
            return movie;
        }

        public bool AddMovie(Movie movie) //returns true or false depending on records successfully entered or not.
        {
            Boolean movieadd = false;
            try
            {
                movies.Add(movie);
                movieadd = true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return movieadd;
        }

        public bool EditMovie(Movie movie)
        {
            bool editmovie = false;
            
            for(int i = 0; i < movies.Count; i++)
            {
                if(movies[i].Id == movie.Id)
                {
                    movies[i].Name = movie.Name;
                    movies[i].Year = movie.Year;
                    movies[i].Rating = movie.Rating;
                    editmovie = true;
                    break;
                }
            }   //for directly accessing in case of database then we can use "where" clause.
            return editmovie;
        }

        public bool DeleteMovie(int id)
        {
            bool moviedeleted = false;
            try
            {
                Movie movie = movies.Where(m => m.Id == id).FirstOrDefault();
                if (movie != null)
                {
                    movies.Remove(movie);
                    moviedeleted = true;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return moviedeleted;
        }
    }
}
