using System;
using BAL;
using DAL.Models;

namespace LayeredProjPrac
{
    class DbConnectUI
    {
        static void Main(string[] args)
        {
            try
            {
                DbConnectBAL dBbal = new DbConnectBAL();
                dBbal.ShowAllEmployees();
                //dBbal.ShowEmployeeById(4);

                Emp toAdd = new Emp() { Eid = 17, Did = 0, Ename = "Abhi", Sal = 9000 };
                Emp toUp = new Emp() { Eid = 2, Ename = "Abhi"};

                //dBbal.UpdateEmployeeByID(toUp);
                //dBbal.ShowEmployeeByName("Abhi");
                //dBbal.InsertEmployee(toAdd);

                dBbal.DeleteEmployeeByName("Abhi");
                dBbal.ShowAllEmployees();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
