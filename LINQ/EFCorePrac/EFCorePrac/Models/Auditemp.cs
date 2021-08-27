using System;
using System.Collections.Generic;

#nullable disable

namespace EFCorePrac.Models
{
    public partial class Auditemp
    {
        public int? Eid { get; set; }
        public string Trans { get; set; }
        public DateTime? TransDate { get; set; }
    }
}
