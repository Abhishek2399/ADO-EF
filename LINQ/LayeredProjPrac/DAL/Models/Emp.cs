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

        public Emp()
        {
            Eid = 0;
            Ename = null;
            Did = 0;
            Sal = -1;
        }
    }
}
