using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization; //for implementing ISerializable interface.This interface is used for custom serialization.
namespace FileDemo
{
    [Serializable]
    public class Movie:ISerializable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int Rating { get; set; }

        // BELOW METHODS ARE USED FOR CUSTOM SERIALIZATION.
        public void GetObjectData(SerializationInfo info, StreamingContext context) //this is called while serialization i.e writing
        {
            info.AddValue("a", Id);   ////a is the key with that key ID will be retrieved.
            info.AddValue("b", Name);
            info.AddValue("c", Rating);
            info.AddValue("d", Year);
        }
        public Movie(SerializationInfo info, StreamingContext context) //this is called while deserilization i.e. when reading from a file.
        {
            Id = info.GetInt32("a");  //a is the same key with that key ID will be retrieved back into file.
            Name = info.GetString("b");
            Rating = info.GetInt32("c");
            Year = info.GetInt32("d");
        }
        public Movie()
        {

        }
    }
}
