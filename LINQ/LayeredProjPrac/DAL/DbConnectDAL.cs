using System;
using DAL.Models; // for accessing Entities and DB Context
using Microsoft.Data.SqlClient; // for execution of SQL Queries
using System.Linq; // for LINQ Queries
using System.Collections.Generic;

namespace DAL
{
    public class DbConnectDAL // for connection with the Db and Query Execution
    {
        private static LayProjContext dB;

        public DbConnectDAL()
        {
            dB = new LayProjContext();
        }

        // ---------- <Employee Related Queries> -----------

        static void EmpDispFormat(List<Emp> emps = null, Emp empSingle = null) // Displaying content of Employee table in specific format 
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Emp ID   | Emp Name             | Dept ID | Salary");
            Console.WriteLine("**************************************************");
            if (emps != null) {
                foreach (var emp in emps)
                {
                    Console.WriteLine(String.Format($"{emp.Eid,-8} | {emp.Ename,-20} | {emp.Did,-7} | {emp.Sal,-10}"));
                }
            }
            else if(empSingle != null)
            {
                Console.WriteLine(String.Format($"{empSingle.Eid,-8} | {empSingle.Ename,-20} | {empSingle.Did,-7} | {empSingle.Sal,-10}"));
            }
            else
            {
                Console.WriteLine("No Object Passed");
            }
            Console.WriteLine("--------------------------------------------------");

        }

        public void ShowAllEmployees() // Get and Display All the data from Emp Table 
        {
            try
            {
                List<Emp> emps = dB.Emps.ToList();
                if (emps != null)
                {
                    EmpDispFormat(emps);
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
                Emp emp = dB.Emps.Find(toSearch);
                if (emp != null)
                {
                    EmpDispFormat(null, emp);
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
        
        public void UpdateEmployeeByID(Emp empUpdates) // Get Employee By ID and Update Details
        {
            try
            {
                Emp emp = dB.Emps.Find(empUpdates.Eid);
                if (emp != null)
                {
                    emp.Ename = empUpdates.Ename == null ? emp.Ename : empUpdates.Ename ;
                    emp.Did = empUpdates.Did == 0 ? emp.Did : empUpdates.Did ;
                    emp.Sal = empUpdates.Sal == -1 ? emp.Sal : empUpdates.Sal ;
                    dB.SaveChanges();
                    Console.WriteLine("Record Successfully Updated");
                    this.ShowEmployeeByID(empUpdates.Eid);
                }
                else
                {
                    Console.WriteLine("Record Not Found");
                }
            }
            catch(SqlException ex)
            {
                throw new Exception($"SQL Exception : {ex.Message}");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }



        // ---------- <Department Related Queries> -----------



        // ---------- <Join Queries> -----------


    }
}
