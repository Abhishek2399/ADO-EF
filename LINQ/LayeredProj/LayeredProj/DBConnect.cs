using System;
using DAL.Models;
using System.Linq;

namespace DAL
{
    public class DBConnect
    {
        private static EFCoreContext Db;
        
        public DBConnect () // Intialising DB Connection 
        {
            try
            {
                Db = new EFCoreDemoContext();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void ShowAllDept() // Displaying all the Departments 
        {
            try
            {
                var deps = Db.Depts.ToList();
                if (deps != null)
                {
                    foreach (var dep in deps)
                    {
                        Console.WriteLine(dep);
                    }
                }
                else
                {
                    Console.WriteLine("Records Not Found");
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static void ShowDeptById() // Display Department By ID
        {
            try
            {
                Console.WriteLine("========================== <Display By ID> ==========================");
                Console.WriteLine("Enter the ID to Search : ");
                int toSearch = Convert.ToInt32(Console.ReadLine());
                Dept dep = Db.Depts.Find(toSearch);
                if (dep != null)
                {
                    Console.WriteLine("Search Result : ");
                    Console.WriteLine(dep);
                }
                else
                {
                    Console.WriteLine("Record Not Found");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddDept(Dept obj)
        {
            try
            {
                Console.WriteLine("========================== <Add Record> ==========================");
                Console.Write("Department Available : ");
              
                Dept newDep = new Dept();
                Console.WriteLine("\nEnter ID : ");
                newDep.Did = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Name : ");
                newDep.Name = Console.ReadLine();

                Db.Depts.Add(newDep);
                Db.SaveChanges();

                this.ShowAllDept();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateRec() // 
        {
            try
            {
                Console.WriteLine("========================== <Update Record> ==========================");
                Console.WriteLine("Enter the ID to Update : ");
                int toSearch = Convert.ToInt32(Console.ReadLine());
                Dept dep = Db.Depts.Find(toSearch);

                if (dep != null)
                {
                    Console.WriteLine("Enter New Name : ");
                    string newName = Console.ReadLine();

                    Console.WriteLine("Enter New Dept ID : ");
                    string newDepId = Console.ReadLine();

                    dep.Did = newDepId == "" | newDepId == " " ? dep.Did : Convert.ToInt32(newDepId);
                    dep .Name = newName == "" | newName == " " ? dep.Name : newName;
                    Db.SaveChanges();
                    this.ShowAllDept();
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

    }
}
