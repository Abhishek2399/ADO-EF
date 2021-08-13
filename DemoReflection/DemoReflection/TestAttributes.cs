using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using OopsDemo;
namespace DemoReflection
{
    class TestAttributes //involves Pen.cs and Info.cs
    {
        static void Main()
        {
            Attribute[] attr = Attribute.GetCustomAttributes(typeof(OopsDemo.Pen));
            foreach(Attribute at in attr) //for printing all attributes defined.
            {
                Info info = (Info)at;
                Console.WriteLine($"Name = {info.Name} , Age = {info.Age}, City = {info.City}");
            }
            //for single attribute:
            //Info info = (Info)attr[0];
            //Console.WriteLine($"Name = {info.Name} , Age = {info.Age}, City = {info.City}");
        }
    }
}
