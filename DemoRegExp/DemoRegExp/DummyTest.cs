using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRegExp
{
    class DummyTest
    {
        //nameof Exception
        static void Main()
        {
            int? x = null;  //? is nullable types.
            if (x == null)
            {
                throw new Exception(nameof(x) + "is null");
            }
            Account acc = null;

            //EXPRESSION BODY DEFINITION
            //lambda exp. explicitly no need to define the functions seperately.
            int Add(int a, int b) => a + b;
            Console.WriteLine($"{Add(9,6)}");

            //RETURNIN MULTIPLE VALUES USING TUPLE
            //download nudget package tuple n then run it.

            List<int> numbers = new List<int>() { 10, 20, 30, 40, 50 };
            var result = GetResult(numbers);
            Console.WriteLine($"min = {result.min}, max = {result.max}, total = {result.sum}");
        }
        public static (int min, int max, int sum)GetResult(List<int> numbers)
        {
            return (numbers.Min(), numbers.Max(), numbers.Sum());
        }
    }
}
