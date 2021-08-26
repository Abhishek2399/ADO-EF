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

    // System Warning -> Run VS as admin -> ok

    class Program
    {
        public static DemoProjEntities2 DB = new DemoProjEntities2(); // creating object to access data base 

        public static void AddEmp()
        {
            try
            {
                // create a record to add
                emp newEmp = new emp();
                newEmp.eid = 197;
                newEmp.ename = "Ashish";
                newEmp.d_id = 300;
                newEmp.sal = 30000;
                //--------------

                // Adding in the emps collections present in the Data base 
                DB.emps.Add(newEmp);
                // Saving the Changes to the Db
                DB.SaveChanges();
                //--------------

                var getEmp = DB.emps.ToList();
                foreach (var data in getEmp)
                {
                    Console.WriteLine(data);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static void DelEmp()
        {
            try
            {
                Console.WriteLine("Enter the id to delete : ");
                int toDel = Convert.ToInt32(Console.ReadLine());
                emp empToDel = DB.emps.Find(toDel);
                if (empToDel != null)
                {
                    DB.emps.Remove(empToDel);
                    DB.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Record not present ");
                }
                var getEmp = DB.emps.ToList();
                foreach (var data in getEmp)
                {
                    Console.WriteLine(data);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void UpdateEmp()
        {
            try
            {
                Console.WriteLine("Enter the id to update : ");
                int toUpdate = Convert.ToInt32(Console.ReadLine());
                emp empToUpdate = DB.emps.Find(toUpdate);
                if (empToUpdate != null)
                {
                    Console.WriteLine("Enter the new name ");
                    empToUpdate.ename = Console.ReadLine();

                    Console.WriteLine("Enter the new salary ");
                    empToUpdate.sal = Convert.ToInt32(Console.ReadLine());
                    DB.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Record not present ");
                }
                var getEmp = DB.emps.ToList();
                foreach (var data in getEmp)
                {
                    Console.WriteLine(data);
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        static void Main(string[] args)
        {

            try
            {

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

                emp singleVal = DB.emps.Find(100);// only single rec is returned hence can't use foreach loop
                // Find only for primary key and for non primary keys Where method 


                // emps is collection 
                // emp is single tuple / record 

                var empAbove4 = DB.emps.Where(data => data.eid > 4).First();// First returns a single record hence we can't use foreach loop 
                // if no record this will throw run time exception and we cant track it by checking null val.

                var empSalAbove200 = DB.emps.Where(data => data.sal > 2500).FirstOrDefault();
                if(empSalAbove200 != null)
                    Console.WriteLine(empSalAbove200);
                else
                    Console.WriteLine("Employee Not Found");

                // single or singleordefault works for the '==' operator only 
                var empEquals4 = DB.emps.Where(data => data.eid ==  1).Single();// First returns a single record hence we can't use foreach loop 
                // if no record this will throw run time exception and we cant track it by checking null val.
                
                //var empSalEquals = DB.emps.Where(data => data.sal == 25000).SingleOrDefault(); 
                // if query contains more than one values we can't use Single or default, hence this won't work 
                // we have to use the ToList Method
                var empSalEquals = DB.emps.Where(data => data.sal == 25000).ToList();

                if (empSalEquals != null)
                    foreach(var data in empSalEquals)
                    {
                        Console.WriteLine(data);
                    }
                else
                    Console.WriteLine("Employee Not Found");

                if(singleVal != null)
                    Console.WriteLine(singleVal.eid + ":" + singleVal.ename);
                else
                    Console.WriteLine("Record not present ");

                //AddEmp();
                DelEmp();
                UpdateEmp();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
