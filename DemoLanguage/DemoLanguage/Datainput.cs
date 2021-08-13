using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLanguage
{
    class Datainput
    {
        static void Main()
        {
            String name;
            int age;
            double number;
            Console.WriteLine("Enter the name");
            name = Console.ReadLine();
            Console.WriteLine("ENter the age");
            age = Convert.ToInt32(Console.ReadLine());
            number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Name is : {name} \nAge is {age}. Marks is {number}");
            Console.ReadLine();
        }
    }
}
