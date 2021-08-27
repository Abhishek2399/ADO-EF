using System;
using System.Collections.Generic;

#nullable disable

namespace EFCorePrac.Models
{
    public partial class Emp1
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public int? DId { get; set; }
        public int? Sal { get; set; }

        public virtual Dept DIdNavigation { get; set; }
    }
}
