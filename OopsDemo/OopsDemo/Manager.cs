using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    class Manager:Employee
    {
        public int HRA { get; set; }
        public int DA { get; set; }

        public override int Calsalary()
        {
            return Salary + DA + HRA;
        }

        public new string Display()
        {
            string oline = string.Format($"{base.Display()} , {HRA}, {DA}, {Calsalary()}");
            return oline;
        }

    }
}
