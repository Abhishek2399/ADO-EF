using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLanguage
{
    class MultiDimDemo
    {
        static void Main()
        {
            string[,] flat = new string[3,4];
            int n=0,total=0;
            int[] no_members=new int[12];
            string[] members = new string[100];
            int[] floor_total = new int[3];
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<4;j++)
                {
                    Console.WriteLine($"Enter the owner of flat {j+1} of floor {i+1} :: ");
                    flat[i, j] = Console.ReadLine();
                    Console.WriteLine($"Enter number of members in flat {j+1} of floor {i+1}");
                    no_members[n] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the members name : ");
                    
                    total += no_members[n]+1;
                    for (int k=0;k<no_members[n];k++)
                    {
                        members[k] = Console.ReadLine();
                    }
                    n++;
                }
                floor_total[i] = total;
            }
            n = 0;
            for(int i=0;i<3;i++)
            {
                
                for (int j=0;j<4;j++)
                {
                    Console.WriteLine($"owner of flat {j + 1} of floor {i + 1} are : : {flat[i,j]}");
                    Console.WriteLine($"list of members in flat {j + 1} of floor {i + 1} are :");
                    for(int k=0;k<no_members[n];k++)
                    {
                        Console.WriteLine(members[k]);
                    }
                }
                
            }
            Console.WriteLine($"Total members in building : {total}");
            for (int i = 0; i < 3; i++) {
                Console.WriteLine($"Total members in each floor of building : {floor_total[i]}");
            }

        }
    }
}
