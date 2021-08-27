using System;
using System.Collections.Generic;

#nullable disable

namespace EFCorePrac.Models
{
    public partial class Employee1
    {
        public int EId { get; set; }
        public string EName { get; set; }
        public int? DId { get; set; }

        public virtual Depart DIdNavigation { get; set; }

        public override string ToString()
        {
            string info = $"------------------\nID : {EId}\nName : {EName}\nDept ID : {DId}\n------------------";
            return info;
        }
    }
}
