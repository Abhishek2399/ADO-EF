using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class TestGenerics
    {
        static void Main()
        {
            int a = 10, b = 20;
            string s1 = "Hello";
            string s2 = "World";
            Console.WriteLine($"a={a} , b={b}");
            Swap<int>(ref a, ref b);
            //Swap(ref a, ref b); both are valid.
            Console.WriteLine($"a={a} , b={b}");
            Console.WriteLine("============================");
            Console.WriteLine($"string 1={s1} , string 2={s2}");
            Swap<string>(ref s1, ref s2);
            Console.WriteLine($"string 1={s1} , string 2={s2}");
        }

        private static void Swap<T>(ref T a, ref T b)
        {
            T c;
            c = a;
            a = b;
            b = c;
        }
    }
}
