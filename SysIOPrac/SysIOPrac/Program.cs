using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;

using System.Xml.Serialization;

using Newtonsoft.Json;// nugget pkgs 
// Project -> Manage NuGet Packages -> Browse -> Search{Newton}

namespace SysIOPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            string binPath = @"D:\capgemini\training\technical\SysIOPrac\SysIOPrac\Movie.bin";
            
            string soapPath = @"D:\capgemini\training\technical\SysIOPrac\SysIOPrac\Movie.soap";
            
            string xmlPath = @"D:\capgemini\training\technical\SysIOPrac\SysIOPrac\Movie.xml";
            
            string jsonPath = @"D:\capgemini\training\technical\SysIOPrac\SysIOPrac\Movie.json";
            string jsonPath2 = @"D:\capgemini\training\technical\SysIOPrac\SysIOPrac\Movie.txt";


            MovieSerializable mv = new MovieSerializable() { Director = "Wes Anderson", Name = "Bottle Rocket", Rating = 5};

            #region Binary Serialization 
            using (FileStream fs = new FileStream(binPath, FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, mv);
            }
            Console.WriteLine("Bin File Serialized");

            MovieSerializable mv2;
            using (FileStream fs = new FileStream(binPath, FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                mv2 = bf.Deserialize(fs) as MovieSerializable;
            }
            Console.WriteLine("Bin File De-Serialized");
            Console.WriteLine(mv2);

            #endregion

            #region SOAP Serialization
            using (FileStream fs = new FileStream(soapPath, FileMode.Create, FileAccess.Write))
            {
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, mv);
            }
            Console.WriteLine("Soap File Serialized");

            using (FileStream fs = new FileStream(soapPath, FileMode.Open, FileAccess.Read))
            {
                SoapFormatter sf = new SoapFormatter();
                mv2 = sf.Deserialize(fs) as MovieSerializable;
            }
            Console.WriteLine("Soap File De-Serialized");
            Console.WriteLine(mv2);

            #endregion

            #region XML Serialization
            // formatter / serializer needs the meta data of the class
            // class has to be public
            using (FileStream fs = new FileStream(xmlPath, FileMode.Create, FileAccess.Write))
            {
                XmlSerializer xs = new XmlSerializer(typeof(MovieSerializable));
                xs.Serialize(fs, mv);
            }
            Console.WriteLine("XML File Serialized");

            using (FileStream fs = new FileStream(xmlPath, FileMode.Open, FileAccess.Read))
            {
                XmlSerializer xs = new XmlSerializer(typeof(MovieSerializable));
                mv = (MovieSerializable)xs.Deserialize(fs);
            }
            Console.WriteLine("XML File De-Serialized");
            Console.WriteLine(mv);
            #endregion

            #region JSON Serialization -> .json
            using (StreamWriter sw = new StreamWriter(jsonPath))
            {
                using (JsonWriter jWriter = new JsonTextWriter(sw))
                {
                    JsonSerializer js = new JsonSerializer();
                    js.Serialize(jWriter, mv);
                }
            }
            Console.WriteLine("JSON File Serialized to .json");

            using (StreamReader sr = new StreamReader(jsonPath))
            {
                using (JsonReader jReader = new JsonTextReader(sr))
                {
                    JsonSerializer js = new JsonSerializer();
                    mv = js.Deserialize<MovieSerializable>(jReader);
                }
            }
            Console.WriteLine("JSON File De-Serialized from .json");
            Console.WriteLine(mv);
            #endregion

            #region JSON Serialization -> .txt
            using (StreamWriter sw = new StreamWriter(jsonPath2))
            {
                using (JsonWriter jWriter = new JsonTextWriter(sw))
                {
                    JsonSerializer js = new JsonSerializer();
                    js.Serialize(jWriter, mv);
                }
            }
            Console.WriteLine("JSON File Serialized to .txt");

            using (StreamReader sr = new StreamReader(jsonPath2))
            {
                using (JsonReader jReader = new JsonTextReader(sr))
                {
                    try
                    {
                        JsonSerializer js = new JsonSerializer();
                        mv = js.Deserialize<MovieSerializable>(jReader);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            Console.WriteLine("JSON File De-Serialized from .txt");
            Console.WriteLine(mv);
            #endregion
        }
    }
}
