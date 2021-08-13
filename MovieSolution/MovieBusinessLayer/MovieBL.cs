using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieEntityLayer;
using MovieDataAccessLayer;
namespace MovieBusinessLayer
{
    public class MovieBL 
    {
        //create method to get movie by DAL this method will be called by application layer.help of movie(for properties) class n moviedAL(for collection) class.
        public List<Movie> GetMoviesBL()
        {
            MovieDAL movieDAL = new MovieDAL();
            return movieDAL.GetMovies();
        }
        public Movie FindMovieBL(int id)
        {
            Movie movie = null;
            try
            {
                if (id <= 0)
                    throw new Exception("Id value cannot be 0 or negative");
                MovieDAL movieDAL = new MovieDAL();
                movie = movieDAL.FindMovieDAL(id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return movie;
        }

        public bool AddMovieBL(Movie movie)
        {
            // first perform validations
            //id shld be positive name shld not be blank year !> 2021 rating btwn 1 to 5.
            bool movieadd = false ;
            try
            {
                if (ValidateMovie(movie))
                {
                    MovieDAL movieDAL = new MovieDAL();
                    movieadd = movieDAL.AddMovie(movie);
                }
            }
            
            catch(Exception ex)
            {
                throw ex;
            }
            return movieadd;
        }

        public bool EditMovieBL(Movie movie)
        {
            bool movieedit = false;
            try
            {
                if (ValidateMovie(movie))
                {
                    MovieDAL movieDAL = new MovieDAL();
                    movieedit = movieDAL.EditMovie(movie);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return movieedit;
        } 

        public bool DeleteMovieBL(int id)
        {
            bool deletedmovie = false;
            try
            {
                if (id>0)
                {
                    MovieDAL movieDAL = new MovieDAL();
                    deletedmovie = movieDAL.DeleteMovie(id);
                    
                }
                else
                    throw new Exception ("Invalid id");
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return deletedmovie;
        }

        private bool ValidateMovie(Movie movie)
        {
            StringBuilder sb = new StringBuilder(); //sb object for error messages.
            bool validmovie = true;
            if (movie.Id < 0)
            {
                validmovie = false;
                sb.Append(Environment.NewLine + "Id cannot be -Ve");    //environment.newline does same thing as \n 
            }
            if(movie.Name == string.Empty)
            {
                validmovie = false;
                sb.Append(Environment.NewLine + "Name cannot be empty");
            }
            if (movie.Year > 2021)
            {
                validmovie = false;
                sb.Append(Environment.NewLine + "Movie Year should be within 2021");     
            }
            if (movie.Rating < 1 || movie.Rating>5)
            {
                validmovie = false;
                sb.Append(Environment.NewLine + "Movie Rating should be in range 1 to 5");    
            }
            if(validmovie == false)
            {
                throw new Exception(sb.ToString());
            }
            return validmovie;

        }
    }
}
