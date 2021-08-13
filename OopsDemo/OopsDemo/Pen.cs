using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
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
        
