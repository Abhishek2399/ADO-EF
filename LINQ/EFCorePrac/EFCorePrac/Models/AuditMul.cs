using System;
using System.Collections.Generic;

#nullable disable

namespace EFCorePrac.Models
{
    public partial class AuditMul
    {
        public int? Eid { get; set; }
        public string Ename { get; set; }
        public int? Did { get; set; }
        public int? Sal { get; set; }
        public string Trans { get; set; }
    }
}
