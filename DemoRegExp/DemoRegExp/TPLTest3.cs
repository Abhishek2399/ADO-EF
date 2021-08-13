using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace DemoRegExp
{
    class TPLTest3
    {
        static void Main()
        {
            Console.WriteLine($"Main thread ={Thread.CurrentThread.ManagedThreadId} started");
            //Task task1 = new Task(PrintNos);
            //task1.Start();
            //instead of this we can write
            Task task1 = Task.Run(() =>
            {
                PrintNos();
            });
            task1.Wait(); //wait command will interrupt main thread and start the child thread then afer completed the child thread main thread will be completing.

            Console.WriteLine($"Main thread ={Thread.CurrentThread.ManagedThreadId} completed");
            Console.ReadKey();  //Task threading does asynchronous programming. when the processing is completed we get o/p but there shld be wave period to reflect the op back. so the child threding was not printing, main thread starts n completes the task and prints the o/p but we didn't give wave period,directly the program was getting over. so we used this statement to make child threads also print. 
        }

        private static void PrintNos()
        {
            Console.WriteLine($"Child threads = {Thread.CurrentThread.ManagedThreadId} started");
            for(int count = 1; count <= 5; count++)
            {
                Console.WriteLine($"Count = {count}");
            }
            Console.WriteLine($"Child threads = {Thread.CurrentThread.ManagedThreadId} completed !");
        }
    }
}
