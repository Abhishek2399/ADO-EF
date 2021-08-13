using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLanguage
{
    class SingleDimDemo
    {
        static void Main()
        {
            int[] salary = new int[5];
            string[] name = new string[5];
            int total = 0;
            for(int i=0;i<5;i++)
            {
                Console.WriteLine($"Enter the name of employee{i+1}");
                name[i] = Console.ReadLine();
                Console.WriteLine($"Enter the salary of employee {i+1}");
                salary[i] = Convert.ToInt32(Console.ReadLine());
                total += salary[i];
            }
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"the name of employee {i+1} is : {name[i]}");
                
                Console.WriteLine($"the salary of employee {i+1} is : {salary[i]}");     
            }
            Console.WriteLine($"Total salary is : {total}");
        }
    }
}
