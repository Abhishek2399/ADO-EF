using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;

namespace FileDemo
{
    class TestBinarySerialization
    {
        static void Main()
        {
            //SerializeData();
            //DeserializeData();
            //SoapSerializeData();
            //SoapDeserializeData();
            //XmlSerializeData();
            XmlDeserializeData();
        }

        private static void XmlDeserializeData()
        {
            Movie movie = null;
            XmlSerializer xml = new XmlSerializer(typeof(Movie));
            FileStream fs = new FileStream("movie.xml", FileMode.Open, FileAccess.Read);
            movie = xml.Deserialize(fs) as Movie;
            fs.Close();
            Console.WriteLine($"{movie.Id},{movie.Name},{movie.Rating},{movie.Year}");
        }

        private static void XmlSerializeData()
        {
            Movie movie = new Movie { Id = 103,Name = "ABC",Year = 2019,Rating= 3 };
            XmlSerializer xml = new XmlSerializer(typeof(Movie));
            FileStream fs = new FileStream("movie.xml", FileMode.Create,FileAccess.Write);
            xml.Serialize(fs, movie);
            fs.Close();
            Console.WriteLine("Xml serialization is done");
        }

        private static void SoapDeserializeData()
        {
            Movie movie = null;
            FileStream fs = new FileStream("movie.soap", FileMode.Open, FileAccess.Read);
            SoapFormatter sf = new SoapFormatter();
            movie = sf.Deserialize(fs) as Movie;
            fs.Close();
            Console.WriteLine($"{movie.Id},{movie.Name},{movie.Rating},{movie.Year}");
        }

        private static void SoapSerializeData()
        {
            Movie movie = new Movie { Id = 102, Name = "Conjuring", Rating = 4, Year = 2018 };
            FileStream fs = new FileStream("movie.soap", FileMode.Create, FileAccess.Write);
            SoapFormatter sf = new SoapFormatter();
            sf.Serialize(fs, movie);
            fs.Close();
            Console.WriteLine("Soap serialization done");
        }

        //WE CAN USE LIST<MOVIE> AS ARRAY AND PERFORM SAME THING. INSTEAD OF JUST PASSING 1 MOVIE DETAILS.

        private static void DeserializeData()
        {
            Movie movie = null; //define the object movie not instantiate it.
            FileStream fs = new FileStream("movie.bin", FileMode.Open, FileAccess.Read); //instantiate the object in fs.
            BinaryFormatter bf = new BinaryFormatter();
            movie = bf.Deserialize(fs) as Movie; //deserialize from fs object and to store in movie obj.
            fs.Close();
            Console.WriteLine($"{movie.Id},{movie.Name},{movie.Rating},{movie.Year} ");
        }

        private static void SerializeData()
        {
            Movie movie = new Movie { Id = 101, Name = "Ludo", Year = 2020, Rating = 4 }; //creating movie obj
            FileStream fs = new FileStream("movie.bin", FileMode.Create, FileAccess.Write);//creating fs obj.
            BinaryFormatter bf = new BinaryFormatter();//binary serialization so binary formatter.
            bf.Serialize(fs, movie); //fs object is where we want to serialize , movie object is what we want to serialize.
            fs.Close();
            Console.WriteLine("binary serialization done");
        }
    }
}
