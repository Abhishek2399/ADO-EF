using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;
namespace FileDemo
{
    class CollectionSerialization
    {
        static List<Movie> movies = new List<Movie>()
        {
            new Movie{Id = 101,Name = "Abc",Year = 2019,Rating=5},
            new Movie{Id = 102,Name = "Xyz",Year = 2020,Rating=4},
            new Movie{Id = 103,Name = "Efg",Year = 2015,Rating=2},
            new Movie{Id = 104,Name = "Mno",Year = 2014,Rating=3},
            new Movie{Id = 105,Name = "Pqr",Year = 2021,Rating=1},
            new Movie{Id = 106,Name = "Jkl",Year = 2010,Rating=4},
        };
        static void Main()
        {
            //BinarySerialization();
            //BinaryDeserialization();
            JsonSerialization();
            JsonDeserialization();
        }

        private static void JsonDeserialization()
        {
            StreamReader sr = new StreamReader("Jsonmovies.txt");
            string data = sr.ReadToEnd();//data stored as single line will be read as it is till end. 
            List<Movie> movies = JsonConvert.DeserializeObject<List<Movie>>(data); //we are converting data that is in string format to the object movie in a list format so that we can loop through it.
            sr.Close();
            foreach(var m in movies)
            {
                Console.WriteLine($"{m.Id} , {m.Name} , {m.Rating} , {m.Year}");
            }
        }

        private static void JsonSerialization()
        {
            StreamWriter sw = new StreamWriter("Jsonmovies.txt");
            string data = JsonConvert.SerializeObject(movies); //another type is by jsonreader. open jsonserializer.cs to see that.there are 2 methods of converting into json format.
            //here data is stored as text format in single line.

            sw.WriteLine(data); 
            sw.Close();
            Console.WriteLine("Json serialization done");
        }

        private static void BinaryDeserialization()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("movielist.bin", FileMode.Open, FileAccess.Read);
            List<Movie> movie  = bf.Deserialize(fs) as List<Movie>;
            fs.Close();
            foreach(var m in movie)
            {
                Console.WriteLine($"{m.Id} , {m.Name} , {m.Rating} , {m.Year}");
            }
        }

        private static void BinarySerialization()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("movielist.bin", FileMode.Create, FileAccess.Write);
            bf.Serialize(fs, movies);
            Console.WriteLine("binary serialization done");
            fs.Close();
        }
    }
}
