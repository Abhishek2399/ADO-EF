using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreDemo.Models
{
    public partial class Emp
    {
        public int Eid { get; set; }
        public int? Did { get; set; }
        public string Ename { get; set; }
        public int Sal { get; set; }
    }
}
