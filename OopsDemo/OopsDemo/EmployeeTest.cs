using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    class EmployeeTest
    {
        static void Main()
        {

            Manager m1 = new Manager { Empno = 1010, Name = "raj", HRA=3000 , DA=4000};
            Console.WriteLine(m1.Display());

            Sales s = new Sales { Empno = 1010, Name = "raj", TravelAllowence = 9000, LaunchAllowence = 7000 };
            Console.WriteLine(s.Display());

            // Employee e1 = new Employee();
            //object initializers

            /*Employee emp1 = new Employee { Empno = 1010, Name = "raj" };
            Employee emp2 = new Employee { Name = "tom", Salary = 200000 };
            Employee emp3 = new Employee { Empno = 1001, Salary = 400000 };

            Pen p1 = new Pen { Color = "Black" };
            Console.WriteLine(emp1.Empno);*/
            //indexers
            //Console.WriteLine(emp1[10]);
        }
    }
}
