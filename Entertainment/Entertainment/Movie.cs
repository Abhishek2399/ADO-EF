using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entertainment
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
        public string MovieInfo()
        {
            return string.Format($"Movie id {Id}, Name : {Name} , Year = {Year} , Rating = {Rating} , Description : {Description}");
        }
    }
}
