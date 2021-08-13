using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OopsDemo;
using System.Reflection;
namespace DemoReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //REFLECTION
            Type type = typeof(Pen); //using type we can find out all information.
            MemberInfo[] members = type.GetMembers();
            foreach (MemberInfo mi in members)
            {
                Console.WriteLine($"{mi.Name}-----------{mi.MemberType}");
            }

            //details using pen object / instance of class.
            Pen p = new Pen();
            Console.WriteLine($"Name is {p.GetType().Name}"); //name of class
            Console.WriteLine($"Full name is {p.GetType().FullName}"); //name of class along with namespace.
            Console.WriteLine($"Assembly info is {p.GetType().Assembly.ToString()}"); //this class belongs to which assembly of which version

            //  WITHOUT INSTANCE OF P HOW WE GET INFORMATION? solution below.
            Console.WriteLine($"Name is {type.Name}");
            Console.WriteLine($"Full name is {type.FullName}");
            Console.WriteLine($"Assembly info is {type.Assembly.ToString()}");


        }
    }
}
