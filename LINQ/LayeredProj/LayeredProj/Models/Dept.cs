using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Dept
    {
        public int Did { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            string info = $"--------------------\nDept ID : {Did}\nName : {Name}\n--------------------";
            return info;
        }
    }
}
