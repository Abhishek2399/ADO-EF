using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    class Sales:Employee
    {
        public int TravelAllowence { get; set; }
        public int LaunchAllowence { get; set; }

        public override int Calsalary()
        {
            return Salary + TravelAllowence + LaunchAllowence;
        }

        public new string Display()
        {
            string oline = string.Format($"{base.Display()},{TravelAllowence},{LaunchAllowence}, {Calsalary()}");
            return oline;

        }
    }
}
