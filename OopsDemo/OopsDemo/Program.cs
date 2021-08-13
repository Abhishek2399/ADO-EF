using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"total of pens {Pen.ShowCount()}");
            Pen p1 = new Pen();
            Pen p2 = new Pen(200, "Red");
            Console.WriteLine(p1.ShowPen());
            Console.WriteLine(p2.ShowPen());
            p1.Color = "green";
            Console.WriteLine(p1.ShowPen());
            Console.WriteLine($"total of pens {Pen.ShowCount()}");

            Pen[] pens = new Pen[3];
            pens[0] = new Pen(100, "black");
            pens[1] = new Pen(120, "blue");
            pens[2] = new Pen(130, "pink");
            for (int i = 0; i < pens.Length; i++)
            {
                Console.WriteLine(pens[i]);
            }
            pens[2].Rate = 200;
        }
    }
}
