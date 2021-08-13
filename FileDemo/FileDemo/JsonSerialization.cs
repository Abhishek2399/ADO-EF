using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
namespace FileDemo
{
    class JsonSerialization
    {
        static void Main()
        {
            SerializedData();
            DeserializeData();
        }

        private static void DeserializeData()
        {
            Movie movie = null;
            using(StreamReader sr = new StreamReader("moviejson.txt"))
            {
                using(JsonReader reader = new JsonTextReader(sr))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    movie = serializer.Deserialize<Movie>(reader) as Movie;
                }
            }
            Console.WriteLine($"{movie.Id},{movie.Name},{movie.Rating},{movie.Year}");
        }

        private static void SerializedData()
        {
            Movie movie = new Movie { Id = 10, Name = "Inception", Rating = 5, Year = 2014 };
            using(StreamWriter sw = new StreamWriter("moviejson.txt")) //creating a file 
            {
                using(JsonWriter writer = new JsonTextWriter(sw)) //converting into json file.
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(writer, movie);
                }
            } //using block automatically nullifies the resources. we dont have to write seperately sw.close()/writer.close()
            Console.WriteLine("Json serializer done");
        }
    }
}
