using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstProj.Models
{
    public class Dept
    {
        [Key]
        public int Did { get; set; }

        public string Dname { get; set; }

        public Loc Location { get; set; }
    }
}
