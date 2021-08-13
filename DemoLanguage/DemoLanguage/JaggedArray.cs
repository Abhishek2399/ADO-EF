using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLanguage
{
    class JaggedArray
    {
        static void Main()
        {
            string[] students = { "ajay", "vijay", "salim" };
            int[][] marks = new int[3][];
            marks[0] = new int[]{ 70, 40, 50 };
            marks[1] = new int[] { 28, 45 };
            marks[2] = new int[] { 67, 87, 78, 69, 90 };
            for(int i=0;i<students.Length;i++)
            {
                Console.WriteLine($"Students is {students[i]}");
                for(int j=0;j<marks[i].Length;j++)
                {
                    Console.WriteLine($"{marks[i][j]}");
                }
            }
        }
    }
}
