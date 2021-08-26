using EFCoreDemo.Models; // where our databse and tables are modeled
using System;
using System.Linq; // for linq queries
namespace EFCoreDemo
{
    // console app should be of .net core type if we want to use EF core
    // create the Database with all the pre defined tables we want to link our application to  
    // we need to use the sccafold command to connect the appn with database 

    class Program
   {
        private static EFCoreDemoContext DB = new EFCoreDemoContext(); // database context object 
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World!");

                // ------------<Structure Change>----------
                //DispAllEmp();
                //DispEmpById();
                //AddEmp();
                //DeleteEmp();
                // -----------------

                //DispAllDept();
                //DispDeptById();
                //AddDept();
                //DeleteDept();
                //UpdateDept();

                ShowLocByName();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void DispAllEmp()
        {
            try
            {
                Console.WriteLine("================== <Display All Employee> ==================");
                var allEmps = DB.Emps.ToList();
                if (allEmps != null)
                {
                    Console.WriteLine("--------------------------");
                    foreach (var emp in allEmps)
                    {
                        Console.WriteLine($"Emp ID : {emp.Eid}");
                        Console.WriteLine($"Dept ID : {emp.Did}");
                        Console.WriteLine($"Emp Name : {emp.Ename}");
                        Console.WriteLine($"Salary : {emp.Sal}");
                        Console.WriteLine("--------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("Record Not Present ");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }// Display all the employees

        public static void DispEmpById()
        {
            try
            {
                Console.WriteLine("================== <Display Employee By ID> ==================");
                Console.WriteLine("Enter the ID to Search : ");
                int toSearch = Convert.ToInt32(Console.ReadLine());
                var emp = DB.Emps.Find(toSearch);

                if (emp != null)
                {
                    Console.WriteLine("--------------------------");
                    Console.WriteLine($"Emp ID : {emp.Eid}");
                    Console.WriteLine($"Dept ID : {emp.Did}");
                    Console.WriteLine($"Emp Name : {emp.Ename}");
                    Console.WriteLine($"Salary : {emp.Sal}");
                    Console.WriteLine("--------------------------");
                }
                else
                {
                    Console.WriteLine("Record Not Present ");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } // Display Employee by ids 

        public static void AddEmp()
        {
            try
            {
                Emp newEmp = new Emp();
                newEmp.Eid = 7;
                newEmp.Did = 100;
                newEmp.Ename = "Ashish";
                newEmp.Sal = 13000;

                DB.Emps.Add(newEmp); // add the new Emp object to the emps collection 
                DB.SaveChanges(); // save the changes to the data base 
                DispAllEmp(); // display all the employees
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } //  Add a new Employee

        public static void DeleteEmp()
        {
            try
            {
                Console.WriteLine("================== <Delete Employee By ID> ==================");
                Console.WriteLine("Enter the ID to Delete : ");
                int toDelete = Convert.ToInt32(Console.ReadLine());
                
                var emp = DB.Emps.Find(toDelete);
                if (emp != null)
                {
                    DB.Emps.Remove(emp);
                    DB.SaveChanges();
                    DispAllEmp();
                }
                else
                {
                    Console.WriteLine("Record Not Present ");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        } // Delete an employee

        public static void DispAllDept()
        {
            try
            {
                Console.WriteLine("================== <Display All Departments> ==================");
                var allDepts = DB.Depts.ToList();
                if (allDepts != null)
                {
                    Console.WriteLine("--------------------------");
                    foreach (var dep in allDepts)
                    {
                        Console.WriteLine($"Dept ID : {dep.Did}");
                        Console.WriteLine($"Dept Name : {dep.Name}");
                        Console.WriteLine("--------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("Record Not Present ");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } // Display All Department

        public static void DispDeptById()
        {
            try
            {
                Console.WriteLine("================== <Display Department By ID> ==================");
                Console.WriteLine("Enter the ID to Search : ");
                int toSearch = Convert.ToInt32(Console.ReadLine());
                var dep = DB.Depts.Find(toSearch);

                if (dep != null)
                {
                    Console.WriteLine("--------------------------");
                    Console.WriteLine($"Dept ID : {dep.Did}");
                    Console.WriteLine($"Dept Name : {dep.Name}");
                    Console.WriteLine("--------------------------");
                }
                else
                {
                    Console.WriteLine("Record Not Present ");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } // Display Department By id 

        public static void AddDept()
        {
            try
            {
                Console.WriteLine("================== <Add Department > ==================");
                Dept newDept = new Dept();
                newDept.Did = 400;
                newDept.Name = "MARKETING";

                DB.Depts.Add(newDept); // add the new Emp object to the emps collection 
                DB.SaveChanges(); // save the changes to the data base 
                DispAllDept(); // display all the employees
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } // Add a new Department

        public static void DeleteDept()
        {
            try
            {
                Console.WriteLine("================== <Delete Department By ID> ==================");
                Console.WriteLine("Enter the ID to Delete : ");
                int toDelete = Convert.ToInt32(Console.ReadLine());

                Dept dep = DB.Depts.Find(toDelete);
                if (dep != null)
                {
                    DB.Depts.Remove(dep);
                    DB.SaveChanges();
                    DispAllDept();
                }
                else
                {
                    Console.WriteLine("Record Not Present ");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        } // Delete a Department 

        public static void UpdateDept() // Update a Department 
        {
            try
            {
                Console.WriteLine("================== <Update Department > ==================");
                Console.WriteLine("Enter the ID to Update : ");
                int toDelete = Convert.ToInt32(Console.ReadLine());

                Dept dep = DB.Depts.Find(toDelete);
                if (dep != null)
                {
                    Console.WriteLine("Enter the new department name : ");
                    dep.Name = Console.ReadLine();
                    DB.SaveChanges();
                    DispAllDept();
                }
                else
                {
                    Console.WriteLine("Record Not Present ");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static void ShowLocByName()
        {
            try
            {
                Console.WriteLine("=================== <Display Lcation By ID> =======================");
                Console.WriteLine("Enter the Location Name to Search");
                string loc = Console.ReadLine();
                var locs = DB.Locations.Where(data => data.Lname == loc);
                if(locs != null)
                {
                    foreach(Location location in locs)
                    {
                        Console.WriteLine($"{location.Lid} : {location.Lname}");
                    }
                }
                else
                {
                    Console.WriteLine("Record Not Present ");
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}