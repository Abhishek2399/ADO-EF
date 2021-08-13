using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionDemo
{
    class TestArrayList
    {
        static void Main()
        {
            ArrayList arraylist = new ArrayList();
            arraylist.Add(10);
            arraylist.Add("tom");
            arraylist.Add(new Pen { Color = "black", Rate = 100 });
            //storing pen object  //new pen object so internally it calls tostring() of pen class.

            Pen pp = new Pen { Color = "red", Rate = 200 };
            Console.WriteLine(pp);
            //object of pen class calls tostring of pen class and displays the results we want instead of default result Collections.Pen.

            for (int i = 0; i < arraylist.Count; i++)
            {
                //Console.WriteLine(arraylist[i]);
                if (arraylist[i] is int)
                {
                    // first unbox to integer to do processing.
                    int n = Convert.ToInt32(arraylist[i]);
                    Console.WriteLine($"{n * n}");

                }
                if (arraylist[i] is string)
                {
                    string name = arraylist[i].ToString(); //unboxing to string.
                    Console.WriteLine($"Hello {name}");
                }
                if (arraylist[i] is Pen)
                {
                    Pen pen = arraylist[i] as Pen; //unboxing to an object.
                    string msg;
                    if (pen.Rate > 500)
                    {
                        msg = "Pen is expensive";
                    }
                    else
                        msg = "Pen is not expensive";
                    Console.WriteLine(msg);
                }
            }
        }
    }
}
