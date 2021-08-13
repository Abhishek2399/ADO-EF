using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    abstract class Employee
    {
        //auto implemented properties.
        public int Empno { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Display()
        {
            string oline = string.Format($"{Empno} {Name} {Salary}");
            return oline;
        }
        public abstract int Calsalary();
        #region Indexers //indexers
        /*
        public string this[int i]
        {
            get
            {
                if (i == 10) return Name;
                else return null;

            }
            set
            {
                if(i==10) { Name = value; }
            }
        }*/

        #endregion
    }
}
