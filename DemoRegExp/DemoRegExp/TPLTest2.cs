using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace DemoRegExp
{
    class TPLTest2
    {
        static void Main()
        {
            DateTime startdate = DateTime.Now;
            Console.WriteLine($"sequential processing started at {startdate}");
            for (int i = 0; i < 10; i++)
            {
                long total = DoSomeWork();
                Console.WriteLine($"{i} -----------> {total}");
            }
            DateTime enddate = DateTime.Now;
            Console.WriteLine($"sequential processing started at {enddate}");
            TimeSpan span = enddate - startdate;
            int ms = (int)span.TotalMilliseconds;
            Console.WriteLine($"Time taken ====== {ms} milliseconds");
            Console.WriteLine("===============================================");
            startdate = DateTime.Now;
            Console.WriteLine($"Parallel processing started at {startdate}");
            Parallel.For(0, 10, i =>
              {
                  long total = DoSomeWork();
                  Console.WriteLine($"{i} -----------> {total}");
              });
            enddate = DateTime.Now;
            Console.WriteLine($"Parallel processing started at {enddate}");
            span = enddate - startdate;
            ms = (int)span.TotalMilliseconds;
            Console.WriteLine($"Time taken ====== {ms} milliseconds");
        }

        private static long DoSomeWork()
        {
            long total = 0;
            for (int i = 1; i < 10000000; i++)
            {
                total += i;
            }
            return total;
        }
    }
}
