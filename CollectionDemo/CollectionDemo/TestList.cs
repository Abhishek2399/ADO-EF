using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class TestList
    {
        static void Main()
        {
            try
            {
                List<string> names = new List<string>();
                names.Add("Tom");
                names.Add("Bob");
                names.Add("Sam");
                names.Add("Ram");
                names.Sort();
                foreach (var s in names)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("======================");
                names.RemoveAt(1);
                foreach (var s in names)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("=======================");
                List<Pen> pens = new List<Pen>()
            {
                new Pen{Rate=10,Color="green" }, //collection initializers.similarly we have object initializers.
            new Pen { Rate = 20, Color = "blue" },
            new Pen { Rate = 30, Color = "grey" },
            new Pen { Rate = 40, Color = "black" },
            new Pen { Rate = 50, Color = "red" },

            };
                foreach (var p in pens)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine("=========================");
                pens.Sort();
                //will show error as Sort is included with list but what to sort that we have to decide so we include Icomparable interface in Pen class. 
                foreach (var p in pens)
                {
                    Console.WriteLine(p);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("ArrayIndexOutofBounds");
            }

        }
    }
}
