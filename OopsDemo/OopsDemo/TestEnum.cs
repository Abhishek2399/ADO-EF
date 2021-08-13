using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    class TestEnum
    {
        enum Colors { Red=600, Blue, Green=700,Yellow, Black}
        enum Days {  Sun=2, Mon,Tue, Wed,Thurs,Fri,Sat=5}
        static void Main()
        {
            Console.WriteLine($"The color is {Colors.Blue} and value is {(int)Colors.Blue}");
            Console.WriteLine($"The color is {Colors.Black} and value is {(int)Colors.Black}");
            Console.WriteLine($"The day is {Days.Sat} and value is {(int)Days.Sat}");

            //below codes:MyFunction.cs

            //EXTEBDING METHODS without modifying String class of System. 
            string msg = "Today is tuesday";
            Console.WriteLine($"words = {msg.MyWordCount()}");

            Console.WriteLine("enter the digit : : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"the number is : {num.OddEven()}");

            string phone = "123-456-7890";
            Console.WriteLine($"the phone number is {phone.ValidPhone()}");

            // using EXTEND METHOD but not using same class here we are using Pen class object inside TestEnum class.
            Pen p1 = new Pen { Color = "blue", Rate = 600 };
            Console.WriteLine($"The discount of pen is : { p1.PenDiscount(3)}");

            //ANONYMOUS types/classes
            var person = new { Name = "Tom", Age = 25, Colour = Colors.Black };
            Console.WriteLine($"Color : {person.Colour}, Name = {person.Name}");

            //PARTIAL CLASS
            //CODE:PartialProductDesign.cs and PartialProductCore.cs.
            PartialProduct pp = new PartialProduct { Id = 10, Name = "Laptop", Cost = 30000 };
            Console.WriteLine(pp.ShowProducts());
        }
    }
}
