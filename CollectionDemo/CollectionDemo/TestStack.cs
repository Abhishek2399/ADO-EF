using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace CollectionDemo
{
    class TestStack
    {
        static void Main()
        {
            Stack stack = new Stack();
            //push method to add object.
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            Console.WriteLine($"total objects in stack after pushing : {stack.Count}");
            //pop
            Console.WriteLine("Stack objects are :");
            while (stack.Count>0)
            {
                Console.WriteLine(stack.Pop());
            }
            Console.WriteLine("================");
            Console.WriteLine($"total objects in stack after poping: {stack.Count}");
            //peek takes object from stack similar to pop but does not removes it.
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Peek();
            Console.WriteLine("================");
            Console.WriteLine($"total objects in stack after peeking: {stack.Count}");
        }
    }
}
