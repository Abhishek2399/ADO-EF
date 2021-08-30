using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations; // for key-attr.

namespace CodeFirstProj.Models
{
    /// <summary>
    /// This class represents one of the table in the database
    /// It should have properties for columns in the table 
    /// </summary>
    public class Emp
    {
        /// <summary>
        /// To define a property as primary key we have Attribute [Key] present in the namespace  
        /// we are using models for tables and tables have primary key 
        /// </summary>
        [Key]
        public int Eid { get; set; }
        public string Ename { get; set; }
        public int Esal { get; set; }

        public int Did { get; set; }


        public Dept Dept { get; set; } // represents {references Dept(Did)} where we have our foreign key

        public override string ToString()
        {
            string info = $"-------------\nID : {Eid}\nName : {Ename}\nSalary : {Esal}\n-------------";
            return info;
        }


    }
}
