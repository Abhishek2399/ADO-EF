using System;
using System.Collections.Generic;

#nullable disable

namespace EFCorePrac.Models
{
    public partial class Depart
    {
        public Depart()
        {
            Employee1s = new HashSet<Employee1>();
        }

        public int DId { get; set; }
        public string DName { get; set; }

        public virtual ICollection<Employee1> Employee1s { get; set; }
    }
}
