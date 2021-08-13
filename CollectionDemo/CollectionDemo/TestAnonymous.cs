using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class TestAnonymous
    {
        delegate void ShowName(string name);
        delegate int ShowSum(int x, int y);
        static void Main()
        {
            string name1 = "tom";
            ShowName show = delegate(string name) { //no return so no parameters.
                Console.WriteLine("Today is sat");
                Console.WriteLine($"Hello {name}");
                Console.WriteLine("======================");
            };
            show(name1);
            show("Bob");
            ShowSum sum = delegate(int x,int y) //to return back we are writing parameters 
            {
                return x + y;
            };
            Console.WriteLine($"Sum = {sum(30,40)}");
            ShowSum add = (int x,int y) => x + y; //shortcut for above showsum 
            Console.WriteLine($"Add = {add(12,12)}");

            ShowName display = (string name) =>
            {
                Console.WriteLine($"Hello {name}");
                Console.WriteLine("Month is august");
            };
            display(name1);
        }
    }
}
