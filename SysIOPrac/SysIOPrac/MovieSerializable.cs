using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysIOPrac
{
    [Serializable]
    public class MovieSerializable
    {
        public string Name { get; set; }
        public string Director { get; set; }
        public int Rating { get; set; }

        public override string ToString()
        {
            string info = $"------------------------------\nName : {Name}\nDirector : {Director}\nRating : {Rating}\n------------------------------";
            return info;
        }

    }
}
