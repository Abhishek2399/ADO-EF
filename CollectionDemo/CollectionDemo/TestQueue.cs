using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace CollectionDemo
{
    class TestQueue
    {
        static void Main()
        {
            Queue queue = new Queue();
            //enqueue to add objects in queue.
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);
            Console.WriteLine($"The number of queue elements after enqueing is : {queue.Count}");
            //deque to delete objects
            while (queue.Count>0)
            {
                Console.WriteLine(queue.Dequeue());
            }
            Console.WriteLine("===============================");
            Console.WriteLine($"The number of queue elements after dequeing is : {queue.Count}");

        }
    }
}
