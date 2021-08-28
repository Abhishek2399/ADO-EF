using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Emp
    {
        public int Eid { get; set; }
        public int? Did { get; set; }
        public string Ename { get; set; }
        public int Sal { get; set; }

        public override string ToString()
        {
            string info = $"-------------\nID : {Eid}\nName : {Ename}\nDept ID : {Did}\nSalary - {Sal} \n-------------";
            return info;
        }
    }
}
