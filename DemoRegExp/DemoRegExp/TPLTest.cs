using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace DemoRegExp
{
    class TPLTest
    {
        static void Main()
        {
            //difference btwn parallel processing and sequential processing.
            Console.WriteLine("Sequential processing");
            int number = 10;
            for(int i = 0; i < number; i++)
            {
                Console.WriteLine($"Count = {i}, Thread = {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(10);
            }
            Console.WriteLine("Parallel processing");
            Parallel.For(0, number, i =>
            {
                Console.WriteLine($"Count = {i},Thread = {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(10);
            });
        }
    }
}
