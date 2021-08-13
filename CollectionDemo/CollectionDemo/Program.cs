using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCalender mc = new MyCalender(); //this object is not array type but when Ienumerator method loops through array and returnns it then we can loop through collection of objects used by for loop.


            foreach (string day in mc)
            {
                Console.WriteLine(day);
            }
            Console.WriteLine("==========================================");
            foreach (string months in mc.GetMonths())
            {
                Console.WriteLine(months);
            }
            int[] num = { 1, 2, 3, 4, 5 };
            foreach (int n in num)  //it means in System.array Ienumerable interface is internally implemented. one ex is with pens given.
            {
                Console.WriteLine(n); ;
            }

            Pen[] pens = new Pen[2];
            pens[0] = new Pen { Rate = 100, Color = "Blue" };
            pens[1] = new Pen { Rate = 150, Color = "Red" };
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"{pens[i].Color},{pens[i].Rate}");
            }
            foreach (Pen p in pens)  //pens is collection of object of Pen type sp p slhd be of pen type.
                                     // to avoid confusion we can write foreach(var p in pens).
            {
                Console.WriteLine($"{p.Color},{p.Rate}");
            }
        }
    }
}
