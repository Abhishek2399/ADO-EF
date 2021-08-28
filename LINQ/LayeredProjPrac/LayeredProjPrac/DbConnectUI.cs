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
                
                Emp update = new Emp();
                update.Eid = 11;
                update.Did = 200;
                update.Ename = "Owen Wilson";

                //dBbal.UpdateEmployeeByID(update);
                dBbal.ShowEmployeeByName("Abhi");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
