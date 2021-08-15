using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;



namespace SysIOPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            string binPath = @"D:\capgemini\training\technical\SysIOPrac\SysIOPrac\Movie.bin";
            
            string soapPath = @"D:\capgemini\training\technical\SysIOPrac\SysIOPrac\Movie.soap";

            MovieSerializable mv = new MovieSerializable() { Director = "Wes Anderson", Name = "Bottle Rocket", Rating = 5};

            #region Binary Serialization 
            using (FileStream fs = new FileStream(binPath, FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, mv);
            }
            Console.WriteLine("File Serialized");

            MovieSerializable mv2;
            using (FileStream fs = new FileStream(binPath, FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                mv2 = bf.Deserialize(fs) as MovieSerializable;
            }
            Console.WriteLine("File De-Serialized");
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


            #endregion

            #region JSON Serialization 



            #endregion

        }
    }
}
