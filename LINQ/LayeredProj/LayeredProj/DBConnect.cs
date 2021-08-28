using System;
using DAL.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore; // for executing SQL Queries
using Microsoft.Data.SqlClient;

namespace DAL
{
    public class DBConnect
    {
        private static EFCoreContext Db;
        
        public DBConnect () // Intialising DB Connection 
        {
            try
            {
                Db = new EFCoreContext();
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
            catch (SqlException ex) // good Programming Practice to write Specific Exceptions 
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddDept() // Adding a new Department 
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
            catch (SqlException ex) // good Programming Practice to write Specific Exceptions 
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateDept() // Updating Department Data 
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
            catch (SqlException ex) // good Programming Practice to write Specific Exceptions 
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DelDeptByID() // Delete Dept By id 
        {
            try
            {
                Console.WriteLine("========================== <Delete By ID> ==========================");
                Console.WriteLine("Enter the ID to Delete : ");
                int toSearch = Convert.ToInt32(Console.ReadLine());
                Dept dep = Db.Depts.Find(toSearch);
                if (dep != null)
                {
                    Db.Depts.Remove(dep);
                    Db.SaveChanges();
                    this.ShowAllDept();      
                }
                else
                {
                    Console.WriteLine("Record Not Found");
                }
            }
            catch (SqlException ex) // good Programming Practice to write Specific Exceptions 
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ShowMixData() // Show data from Department and Employee using join 
        {
            try
            {
                var empsLinq = from e in Db.Emps join d in Db.Depts on e.Did equals d.Did select new { Ename = e.Ename, Dname = d.Name };
                // from <alias> in DB.<TableName> join <alias2> in DB.<Table2Name> on <alias.<RowName>> equals <alias2.RowName> select {Rows we want}

                var empsMethod = Db.Emps.Join(Db.Depts, e => e.Did, d => d.Did, (e, d) => new { Ename = e.Ename, Dname = d.Name });
                // DB.<Table to join>.Join(DB.<Table to join with>, <Joining Condition>, <Rows We want to Access>)

                foreach (var emp in empsLinq)
                {
                    Console.WriteLine($"{emp.Ename} -> {emp.Dname}");

                }
                Console.WriteLine("====================================");
                foreach (var emp in empsMethod)
                {
                    Console.WriteLine($"{emp.Ename} -> {emp.Dname}");
                }
            }
            catch (SqlException ex) // good Programming Practice to write Specific Exceptions 
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

         // SQL Queries with EF Core
         public void DispAllEmps() // Display All the employees
        {
            try
            {
                var emps = Db.Emps.FromSqlRaw("Select * from Emp"); // for executing SQL Queries 
                foreach (var emp in emps)
                {
                    Console.WriteLine(emp);
                }
            }
            catch (SqlException ex) // good Programming Practice to write Specific Exceptions 
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DispEmpById(int id, string name) // Display employee by id or by name
        {
            try
            {
                var pId = new SqlParameter("@eid", id); // setting '@eid' to id 
                var pName = new SqlParameter("@ename", name); // setting '@ename' to name 

                var emps = Db.Emps.FromSqlRaw("Select * from Emp where eid = @eid or ename = @ename", pId, pName); // for executing SQL Queries 
                foreach (var emp in emps)
                {
                    Console.WriteLine(emp);
                }
            }
            catch (SqlException ex) // good Programming Practice to write Specific Exceptions 
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddEmp(Emp obj)
        {
            try
            {
                var pId = new SqlParameter("@eid", obj.Eid);
                var pName = new SqlParameter("@ename", obj.Ename);
                var pDid = new SqlParameter("@did", obj.Did);
                var pSal = new SqlParameter("@sal", obj.Sal);

                Db.Database.ExecuteSqlRaw("insert into Emp (eid, ename, did, sal) values(@eid, @ename, @did, @sal)", pId, pName, pDid, pSal);

                Console.WriteLine("Record Inserted ");
            }
            catch (SqlException ex) // good Programming Practice to write Specific Exceptions 
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DelEmpProc(int id)
        {
            try
            {
                var pId = new SqlParameter("@peid", id);
                var isDeleted = Db.Database.ExecuteSqlRaw("exec pro_del_emp @peid", pId);

                if (isDeleted < 0)
                {
                    Console.WriteLine("Record Not Found");
                }
                else
                {
                    Console.WriteLine("Record Deleted ");
                    this.DispAllEmps();

                }
            }
            catch(SqlException ex) // good Programming Practice to write Specific Exceptions 
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateEmp(Emp obj) // Updating Emp Details
        {
            try
            {
                if (obj.Eid > 0)
                {
                    var pId = new SqlParameter("@eid", obj.Eid);
                    var pName = new SqlParameter("@ename", obj.Ename == "" ? Db.Emps.Find(obj.Eid).Ename : obj.Ename);
                    var pDid = new SqlParameter("@did", obj.Did == null ? Db.Emps.Find(obj.Eid).Did : obj.Did);
                    var pSal = new SqlParameter("@sal", obj.Sal == 0 ? Db.Emps.Find(obj.Eid).Sal : obj.Sal);

                    var isUpdated = Db.Database.ExecuteSqlRaw(" exec pro_up_emp @eid, @ename, @did, @sal", pId, pName, pDid, pSal);

                    if (isUpdated > 0)
                    {
                        Console.WriteLine("Record Updated ");
                        this.DispEmpById(obj.Eid, "");
                    }
                    else
                    {
                        Console.WriteLine("Record not Found");
                    }
                }
                else
                {
                    Console.WriteLine("ID Invalid");
                }
            }
            catch (SqlException ex) // good Programming Practice to write Specific Exceptions 
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
