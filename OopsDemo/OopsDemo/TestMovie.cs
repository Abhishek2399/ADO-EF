using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entertainment;

namespace OopsDemo
{
    class TestMovie
    {
        static void Main()
        {
            Movie[] movie = new Movie[3];
            try
            {
                for (int i = 0; i < 3; i++)
                {
                    movie[i] = new Movie();
                    Console.WriteLine($"Enter the name of the Movie{i + 1} : ");
                    movie[i].Name = Console.ReadLine();
                    Console.WriteLine("Give some description about the Movie : ");
                    movie[i].Description = Console.ReadLine();
                    Console.WriteLine("Enter Movie ID : ");
                    movie[i].Id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Give Rating : ");
                    movie[i].Rating = Convert.ToInt32(Console.ReadLine());
                    if (movie[i].Rating > 5 || movie[i].Rating <= 0)
                    {
                        throw new Exception("Rating should be in range 1 to 5");
                    }
                    Console.WriteLine("Year Movie of Release : ");
                    movie[i].Year = Convert.ToInt32(Console.ReadLine());
                    if(movie[i].Year > 2021)
                    {
                        throw new Exception("Year should be less than 2021");
                    }
                }
                /*for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(movie[i].MovieInfo());
                }*/
            }


            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return; // omit this return if including for loop within the try block. Return statement stops the program entirely.
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(movie[i].MovieInfo());
            }


        }
    }
}
