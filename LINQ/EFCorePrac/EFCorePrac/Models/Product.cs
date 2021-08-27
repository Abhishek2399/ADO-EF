using System;
using System.Collections.Generic;

#nullable disable

namespace EFCorePrac.Models
{
    public partial class Product
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public int? Pcost { get; set; }
    }
}
