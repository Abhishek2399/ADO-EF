using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieEntityLayer;
using MovieBusinessLayer;
namespace MovieConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                DisplayMenu();
                choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:GetAllMovies();
                        break;
                    case 2:FindMovie();
                        break;
                    case 3:AddMovie();
                        break;
                    case 4:EditMovie();
                        break;
                    case 5:DeleteMovie();
                        break;
                    default: Console.WriteLine("Invalid Choice");
                        break;
                }

            } while (choice != 0);
        }

        private static void DeleteMovie()
        {
            int id;
            try
            {
                Console.WriteLine("Enter the movie id to be deleted");
                id = Convert.ToInt32(Console.ReadLine());
                MovieBL movieBL = new MovieBL();
                Movie movie = movieBL.FindMovieBL(id);
                if (movie != null)
                {
                    Console.WriteLine($"Name = {movie.Name} \t Rating = {movie.Rating} \t Year = {movie.Year}");
                    Console.WriteLine("are you sure you want to delete this item? : Yes/No");
                    string ch = Console.ReadLine();
                    if(ch.CompareTo("Yes") == 0)
                    {
                        bool moviedeleted = movieBL.DeleteMovieBL(id);
                        if(moviedeleted)
                            Console.WriteLine("Record deleted!");
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void EditMovie()
        {
            int id;
            try
            {
                Console.WriteLine("enter the movie id which you want to update");
                id = Convert.ToInt32(Console.ReadLine());
                MovieBL movieBL = new MovieBL();
                Movie movie = movieBL.FindMovieBL(id); //return type of findmoviebl() is object only so need to store it in object type. no need to create instance of thaat movie object class.
                if (movie != null)
                {
                    Console.WriteLine($"Name is {movie.Name}");
                    Console.WriteLine("Enter Year");
                    movie.Year = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Rating");
                    movie.Rating = Convert.ToInt32(Console.ReadLine());
                    bool movieupdated = movieBL.EditMovieBL(movie);
                    if(movieupdated)
                        Console.WriteLine("Record updated !");
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private static void AddMovie()
        {
            Movie movie = new Movie();
            try
            {
                Console.WriteLine("enter the movie id");
                movie.Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the movie name");
                movie.Name = Console.ReadLine();
                Console.WriteLine("Enter the Year");
                movie.Year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Rating");
                movie.Rating = Convert.ToInt32(Console.ReadLine());

                MovieBL movieBL = new MovieBL();
                bool movieadd = movieBL.AddMovieBL(movie);
                if(movieadd)
                    Console.WriteLine("Movie added successfully");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message); ;
            }
        }

        private static void FindMovie()
        {
            try
            {
                Console.WriteLine("Enter movie id");
                int id = Convert.ToInt32(Console.ReadLine());
                MovieBL movieBL = new MovieBL();
                Movie movie = movieBL.FindMovieBL(id);
                if (movie != null)
                {
                    Console.WriteLine("============================================================================");
                    Console.WriteLine($"{movie.Id} \t {movie.Name}\t\t\t {movie.Year} \t {movie.Rating} ");
                    Console.WriteLine("\n");
                    Console.WriteLine("=============================================================================");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void GetAllMovies() //we will call the business layer method from application.
        {
            MovieBL movieBL = new MovieBL();
            List<Movie> movies = movieBL.GetMoviesBL(); 
            if(movies != null)
            {
                foreach(var m in movies)
                {
                    Console.WriteLine($"{m.Id} \t {m.Name} \t\t\t\t\t\t\t {m.Year} \t {m.Rating} ");
                }
            }
            else
                Console.WriteLine("no movies present");
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("\n\n\n");
            //Console.Clear();
            Console.WriteLine("************Movie Application***************");
            Console.WriteLine("1. List All Movies");
            Console.WriteLine("2. Find Movie");
            Console.WriteLine("3. Add Movie");
            Console.WriteLine("4. Edit Movie");
            Console.WriteLine("5. Delete Movie");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Enter choice");

        }
    }
}
