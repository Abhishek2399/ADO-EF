using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Greetings;
using MyMaths;
namespace DemoLanguage
{
    class Dllcalling
    {
        static void Main()
        {
            Hello hello = new Hello();
            Console.WriteLine(hello.Welcome("Tom"));
            Console.WriteLine(hello.Goodbye());

            Mycalci mycal = new Mycalci();
            Console.WriteLine(mycal.Add(4, 5));
            Console.WriteLine(mycal.Multiply(4, 5));
            Console.ReadLine();
        }
    }
}
