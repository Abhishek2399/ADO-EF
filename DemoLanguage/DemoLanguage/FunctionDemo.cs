using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLanguage
{
    class FunctionDemo
    {
        static void Main()
        {
            string name = "Tom" , city="Mumbai";
            int age = 29;
            Show(name, age,city);
            //OPTIONAL PARAMETERS : : default setting of parameters- always shld start from right. It goes position wise. Show(name,city) will not take.
            Show(name,age);
            Show(name);

            //POSITIONAL PARAMETERS : : anything can be given in anny position.no order required.
            Show(city:"Pune", name :"Jerry");
            Show(age: 30, name:"Bob", city:"Bangalore");

            //null check
            int ? salary = null;
            Nullable<int> total = null;
            float? avg = 32.50f;
            //avg = null;
            if(avg.HasValue)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        private static void Show(string name, int age=25, string city="Chennai")
        {
            Console.WriteLine($"Name is {name}, Age is {age}, City is {city}");
        }
    }
}
