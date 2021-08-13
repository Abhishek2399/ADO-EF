using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    class TestStudent
    {
        static void Main()
        {
            Student stu = new Student();
            Student stu1 = new Student(11, "rajesh", 67, 78, 89, 87, 100);
            #region Student Calculation
            Console.WriteLine($"The total marks {stu.Name} obtained is : {stu.Marks()}");
            Console.WriteLine($"The total marks {stu1.Name} obtained is : {stu1.Marks()}");
            Console.WriteLine($"The average marks {stu.Name} obtained is : {stu.Average()}");
            Console.WriteLine($"The average marks {stu1.Name} obtained is : {stu1.Average()}");
            Console.WriteLine($"The grade {stu.Name} obtained is : {stu.Grade()}");
            Console.WriteLine($"The grade {stu1.Name} obtained is : {stu1.Grade()}");
            #endregion

            Console.WriteLine($"The details of {stu.Name}  : {stu.ShowDetails()}");
            Console.WriteLine($"The details of {stu1.Name}  : {stu1.ShowDetails()}");
        }
    }
}
