using System;
using System.Collections.Generic;
using System.Linq; // for using linq
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo1
{
    class Program
    {
        public static List<Cust> database()
        {
            List<Cust> lst = new List<Cust>()
            {
                new Cust(),
                new Cust(){ Cname = "Abhi", Cid = 79},
                new Cust(){ Cname = "Ashu", Cid = 21},
                new Cust(){ Cname = "Rahul", Cid = 29},
                new Cust(){ Cname = "Ashis", Cid = 12},
                new Cust(){ Cname = "Shetye", Cid = 1},

            };
            return lst;
        }


        static void Main(string[] args)
        {
            // Linq Query to access data from the in-memory object
            //1.] obtain the data src
            int[] arr = new int[]{ 1, 2, 3, 4, 5 }; // in-memory obj 

            var q = 45;// var data is type safe once initialised we cant change the data type 
            // we can give various values but we cant change the type 
            //2.] write the query 


            // Query Syntax => Src -> get data{can be in a Speific manner} -> where condition 


            var qRes = from data in arr 
                       select data; // defining query 
            // arr is the data source

            //3.] execute the query 
            foreach (var r in qRes)
            {
                Console.WriteLine(r);
            }

            // where clause 
            qRes = from data in arr 
                   where data < 3 
                   select data;
            
            foreach (var r in qRes)
            {
                Console.WriteLine(r);
            }

            var qRes2 = from data in database() // query syntax
                   where data.Cid > 7 orderby data.Cid descending
                   select data;

            foreach(var data in qRes2)
            {
                Console.WriteLine(data);
            }

            var q2 = database().ToList(); // method syntax 
            foreach(var t in q2)
            {
                Console.WriteLine(t);
            }

        }
    }
}
