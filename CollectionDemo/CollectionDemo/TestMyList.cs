using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class TestMyList
    {
        static void Main()
        {
            MyList<Pen> pens = new MyList<Pen>(3);
            pens.Add(new Pen { Rate = 100, Color = "blue" });
            pens.Add(new Pen { Rate = 200, Color = "red" });
            pens.Add(new Pen { Rate = 300, Color = "black" });
            foreach(Pen p in pens)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("===========================");

            MyList<int> nums = new MyList<int>(6);
            nums.Add(2);
            nums.Add(10);
            nums.Add(25);
            nums.Add(9);
            nums.Add(76);
            for(int i = 0; i < nums.Count; i++)
            {
                Console.WriteLine($"{nums[i]}"); //cannot assign [] to index.so use indexing.
            }
            Console.WriteLine("============================");
            MyList<string> fruits = new MyList<string>(5);
            fruits.Add("Apple");
            fruits.Add("Mango");
            fruits.Add("Banana");
            fruits.Add("Papaya");
            fruits.Add("Guava");
            
            for (int i = 0; i < fruits.Count; i++)
            {
                Console.WriteLine($"{fruits[i]}"); //cannot assign [] to index.so use indexing.in MyList.cs.
            }
            Console.WriteLine("===========================");
            foreach(string s in fruits) //error as no getenumerator method here foreach works in getenumerator.. so create one in MyList.cs
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("==========================");
        }
    }
}
