using System;
using System.Collections.Generic;
using System.Linq; // for LINQ Queries
using System.Text;
using System.Threading.Tasks;

namespace EntityFrame
{
    // EntityFrameWork works on top of ADO.NET
    //Steps to use EFW
    // Proj->Add new item->Template->Data->Ado.net->Ef Designer Db->Connection
    // Connection -> new -> sever name -> db name -> Connect
    // Connection -> exist -> Connect
    // Connect -> EF Ver -> Check Tables we want
    // EDM(Entity Data Model) .edmx will be Constructed by the EFW 

    class Program
    {
        static void Main(string[] args)
        {
            DemoProjEntities2 DB = new DemoProjEntities2();

            var empData = from data in DB.emps // src of data 
                          select data; // get all the data 

            var emp1 = from data in DB.emps // src of the data 
                       where data.eid == 1 // condn to get the data 
                       select data; // select data 

            // Specific cols

            var empSpecData = from data in DB.emps // src of data 
                      where data.d_id == 100 // condn for data
                      select new { data.eid, data.ename }; // specific cols 

            foreach( var data in empSpecData) // printing out the values 
            {
             //   Console.WriteLine(data.eid + " " + data.ename);
            }


            // Method Syntax 
            // to get all the cols

            var allData = DB.emps.ToList();// get all the recs from emps 

            var whereData = DB.emps.Where(x => x.d_id == 100); // where dept id == 100, we have to use lambda expression in method parameter => expression
            foreach( var data in allData)
                Console.WriteLine(data.eid + " " + data.ename);



        }
    }
}
