using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLanguage
{
    class RefInOutKeyword
    {
        static void Main()
        {
            int a = 10, b = 20;
            Console.WriteLine($"a={a} b={b}");

            //reference value to use it as pass by reference.
            Swap(ref a, ref b);
            Console.WriteLine($"a={a} b={b}");
            int[] num = { 20, 30, 40, 50, 60 };
            Change(num);
            for(int i=0; i<num.Length;i++)
            {
                Console.WriteLine($"{num[i]}");
            }

            // in out variables for returning multiple values from a method.
            int c, d;
            Calc(a, b, out c, out d);
            Console.WriteLine($"c={c} d={d}");

        }

        private static void Calc(int l, int m, out int n, out int p)
        {
            n = l + m;
            p = l * m;
        }

        private static void Change(int[] num)
        {
            for(int i=0;i<num.Length;i++)
            {
                num[i] += 5;
            }
        }

        private static void Swap(ref int a, ref int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
        }
    }
}
