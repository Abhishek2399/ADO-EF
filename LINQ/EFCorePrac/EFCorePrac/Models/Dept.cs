using System;
using System.Collections.Generic;

#nullable disable

namespace EFCorePrac.Models
{
    public partial class Dept
    {
        public Dept()
        {
            Emp1s = new HashSet<Emp1>();
        }

        public int DId { get; set; }
        public string DName { get; set; }
        public int? LocId { get; set; }

        public virtual ICollection<Emp1> Emp1s { get; set; }
    }
}
