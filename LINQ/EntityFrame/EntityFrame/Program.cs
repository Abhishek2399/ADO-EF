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

            var empData = from data in DB.emps
                          select data; // get all the data 

            var emp1 = from data in DB.emps
                       where data.eid == 1
                       select data;
            

            foreach( var data in emp1)
            {
                Console.WriteLine(data.eid + " " + data.ename);
            }




        }
    }
}
