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
                //dBbal.ShowAllEmployees();
                dBbal.ShowEmployeeById(4);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
