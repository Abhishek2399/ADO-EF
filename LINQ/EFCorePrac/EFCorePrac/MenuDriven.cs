using System;
using EFCorePrac.Models; // where the tables are 
using System.Linq; // for using the linq commands

namespace EFCorePrac
{
    class MenuDriven
    {
        public static DemoProjContext DB = new DemoProjContext(); // in order to access the tables 

        public static void ShowMenu()
        {
            Console.WriteLine("(1) Display All Records\n(2) Display Record by ID\n(3) Add Record\n(4) Update Record\n(5) Delete Record by ID");        
        }

        public static void DispAllRecs()
        {
            try
            {
                Console.WriteLine("========================== <Display All Records> ==========================");
                var emps = DB.Employees1.ToList();
                if (emps.Count != 0) {
                    foreach (var emp in emps)
                    {
                        Console.WriteLine(emp);
                    }
                }
                else
                {
                    Console.WriteLine("Table Empty ");
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static void DispByID()
        {
            try
            {
                Console.WriteLine("========================== <Display By ID> ==========================");
                Console.WriteLine("Enter the ID to Search : ");
                int toSearch = Convert.ToInt32(Console.ReadLine());
                Employee1 emp = DB.Employees1.Find(toSearch);
                if (emp != null)
                {
                    Console.WriteLine("Search Result : ");
                    Console.WriteLine(emp);
                }
                else
                {
                    Console.WriteLine("Record Not Found");
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static void AddRec()
        {
            try
            {
                Console.WriteLine("========================== <Add Record> ==========================");
                Console.Write("Department Available : ");
                var deps = DB.Departs.ToList();
                foreach(var dep in deps)
                {
                    Console.Write($"{dep.DId} ");
                }

                Employee1 newEmp = new Employee1();
                Console.WriteLine("\nEnter ID : ");
                newEmp.EId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Name : ");
                newEmp.EName = Console.ReadLine();
                
                Console.WriteLine("Enter Dept ID : ");
                newEmp.DId = Convert.ToInt32(Console.ReadLine());

                DB.Employees1.Add(newEmp);
                DB.SaveChanges();

                DispAllRecs();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UpdateRec()
        {
            try
            {
                Console.WriteLine("========================== <Update Record> ==========================");
                Console.WriteLine("Enter the ID to Update : ");
                int toSearch = Convert.ToInt32(Console.ReadLine());
                Employee1 emp = DB.Employees1.Find(toSearch);
                Employee1 tempEmp = DB.Employees1.Find(toSearch);

                if (emp != null)
                {
                    Console.WriteLine("Enter New Name : ");
                    string newName = Console.ReadLine();

                    Console.WriteLine("Enter New Dept ID : ");
                    string newDepId = Console.ReadLine();
                    
                    emp.DId = newDepId == "" | newDepId == " " ? tempEmp.DId : Convert.ToInt32(newDepId);
                    emp.EName = newName == "" | newName == " " ? tempEmp.EName : newName;
                    DB.SaveChanges();
                    DispAllRecs();
                    
                }
                else
                {
                    Console.WriteLine("Record Not Found");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        public static void DelByID()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        static void Main(string[] args)
        {
            try
            {
                DispByID();
                UpdateRec();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
