using System;
using CodeFirstProj.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace CodeFirstDAL
{
    public class DAL
    {
        private static ProjDbContext dB;

        public DAL()
        {
            dB = new ProjDbContext();
        }

        static void EmpDisplayFormat<T>(T data) // Displaying content of Employee table in specific format 
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Emp ID   | Emp Name             | Dept ID | Salary");
            Console.WriteLine("**************************************************");
            if (data is List<Emp>) // Tolist
            {
                var emps = data as List<Emp>;
                foreach (var emp in emps)
                {
                    Console.WriteLine(String.Format($"{emp.Eid,-8} | {emp.Ename,-20} | {emp.Did,-7} | {emp.Esal,-10}"));
                }
            }
            else if (data is IQueryable<Emp>) // Where
            {
                var emps = data as IQueryable<Emp>;
                foreach (var emp in emps)
                {
                    Console.WriteLine(String.Format($"{emp.Eid,-8} | {emp.Ename,-20} | {emp.Did,-7} | {emp.Esal,-10}"));
                }
            }
            else if (data is Emp)
            {
                var emp = data as Emp;
                Console.WriteLine(String.Format($"{emp.Eid,-8} | {emp.Ename,-20} | {emp.Did,-7} | {emp.Esal,-10}"));
                return;
            }
            else
            {
                Console.WriteLine("No Object Passed");
                return;
            }


            Console.WriteLine("--------------------------------------------------");

        }


        public void ShowAllEmployees() // Get and Display All the data from Emp Table 
        {
            try
            {
                List<Emp> emps = dB.Employees.ToList();
                if (emps != null)
                {
                    EmpDisplayFormat(emps);
                }
                else
                {
                    Console.WriteLine("Table Empty");
                }

            }
            catch (SqlException ex)
            {
                throw new Exception($"SQL Exception : {ex.Message}");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ShowEmployeeByID(int toSearch) // Get and Display Employee By ID
        {
            try
            {
                Emp emp = dB.Employees.Find(toSearch);
                if (emp != null)
                {
                    EmpDisplayFormat(emp);
                }
                else
                {
                    Console.WriteLine("Record Not Found");
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"SQL Exception : {ex.Message}");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ShowEmployeeByName(string nameToSearch) // Get and Display Employee By ID
        {
            try
            {
                var emp = dB.Employees.Where(e => e.Ename == nameToSearch).FirstOrDefault();
                if (emp != null)
                {
                    var emps = dB.Employees.Where(e => e.Ename == nameToSearch);
                    EmpDisplayFormat(emps);
                }
                else
                {
                    Console.WriteLine("Record not Found");
                }

            }
            catch (SqlException ex)
            {
                throw new Exception($"SQL Exception : {ex.Message}");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateEmployeeByID(Emp empUpdates) // Get Employee By ID and Update Details
        {
            try
            {
                Emp emp = dB.Employees.Find(empUpdates.Eid);
                if (emp != null)
                {
                    emp.Ename = empUpdates.Ename == null ? emp.Ename : empUpdates.Ename;
                    emp.Did = empUpdates.Did == 0 ? emp.Did : empUpdates.Did;
                    emp.Esal = empUpdates.Esal == -1 ? emp.Esal : empUpdates.Esal;
                    dB.SaveChanges();
                    Console.WriteLine("Record Successfully Updated");
                    this.ShowEmployeeByID(empUpdates.Eid);
                }
                else
                {
                    Console.WriteLine("Record Not Found");
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"SQL Exception : {ex.Message}");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteEmployeeByName(string nameToDelete) // Delete Employees By Name
        {
            try
            {
                var toDelete = dB.Employees.Where(e => e.Ename == nameToDelete);
                foreach (var emp in toDelete)
                {
                    dB.Employees.Remove(emp);
                }
                dB.SaveChanges();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InsertEmployee(Emp empToAdd = null) // Adding a new Employee
        {
            try
            {
                if (empToAdd != null)
                {
                    dB.Employees.Add(empToAdd);
                    dB.SaveChanges();
                    this.ShowAllEmployees();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ShowEmpDept()
        {
            try
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("Emp Name   | Dep Name |");
                Console.WriteLine("************************");
                var empDep = dB.Employees.Join(dB.Depts, e => e.Did, d => d.Did, (e, d) => new { Ename = e.Ename, Dname = d.Dname });
                if(empDep != null)
                {
                    foreach (var emp in empDep)
                    {
                        Console.WriteLine(String.Format($"{emp.Ename,-10} | {emp.Dname,-8} |"));
                    }
                }
            }
            catch (SqlException ex)
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
