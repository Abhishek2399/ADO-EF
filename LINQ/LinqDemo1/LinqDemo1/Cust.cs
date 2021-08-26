using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo1
{
    public class Cust
    {
        public string Cname { get; set; }
        public int Cid { get; set; }

        public Cust()
        {
            Cname = "Def Name";
            Cid = -1;
        }

        public Cust(string name, int id)
        {
            Cname = name;
            Cid = id;
        }

        public override string ToString()
        {
            string info = $"------------------------------\n Name : {Cname}\nID : {Cid} \n------------------------------";
            return base.ToString();
        }

    }
}
