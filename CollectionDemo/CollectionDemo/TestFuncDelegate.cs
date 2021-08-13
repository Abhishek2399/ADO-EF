using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class TestFuncDelegate //inbuilt delegate.can point to method or anonymous method.
    {
        static void Main()
        {
            Func<string> show = Display; //show is pointing to display.func used to have return value and last parameter as return value.
            Console.WriteLine($"{show()}");

            Func<int, int, int> add = delegate (int x, int y) { return x + y; };      //last int is used for return type
            //add is pointing to anonymous method.
            Console.WriteLine($"Add = {add(9, 8)}");
            Action<string> ChangeCase = ShowStr; //Action used for processing purpose of delegates. no return value. checks delegates from database.
            ChangeCase("net core");
            Predicate<string> strdel = string.IsNullOrWhiteSpace; //Predicates use only to return boolean values
            Console.WriteLine($"{strdel("Mumai")} -------- {strdel("  ")}");
            Predicate<char> chardel = (char c) => { return char.IsDigit(c); };
            Console.WriteLine($"{chardel('A')}=============={chardel('4')}");
        }

        private static void ShowStr(string obj)
        {
            Console.WriteLine($"The upper case id is {obj.ToUpper()}");
        }

        private static string Display()
        {
            return "This is Func<> delegate which is in system namespace";
        }
    }
}
