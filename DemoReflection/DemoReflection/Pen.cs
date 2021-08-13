using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoReflection; //as pen class is originally in seperate namespace.
namespace OopsDemo
{
    [Info(Name = "Tom", City = "Delhi", Age = 20)]
    [Info(Name = "Rita", City = "Goa", Age = 30)] //custom attributes.
    class Pen
    {
        private int rate;
        static int count;
        public int Rate
        {
            get { return rate; }
            set { rate = value; }
        }
        private string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public Pen()
        {
            count++;
            rate = 100;
            color = "blue";
        }
        public Pen(int rate, string color)
        {
            count++;
            this.rate = rate;
            this.color = color;
        }
        public static int ShowCount()
        {
            return count;
        }
        [Obsolete("this method is outdated")]
        public string ShowPen()
        {
            string oline = string.Format($"Color of pen is {color} and cost is {rate}");
            return oline;
        }
        static Pen()
        {
            count = 25;
            Console.WriteLine("Static constructor");
        }
    }
}
        
