using System;
using DAL;
using DAL.Models;

namespace BAL
{
    public class DbConnectBAL // Interface between the DAL and UI
    {
        private static DbConnectDAL dBdal;

        public DbConnectBAL()
        {
            dBdal = new DbConnectDAL();
        }


        public void ShowAllEmployees()
        {
            dBdal.ShowAllEmployees();
        }

        public void ShowEmployeeById(int toSearch)
        {
            if (toSearch > 0)
            {
                dBdal.ShowEmployeeByID(toSearch);
            }
            else
            {
                Console.WriteLine("ID Can't be negative");
            }
        }

        // ? Doubt 
        public void UpdateEmployeeByID(Emp empUpdates) // Get Employee By ID and Update Details
        {
            try
            {
                if (empUpdates.Eid > 0) {
                    dBdal.UpdateEmployeeByID(empUpdates);
                }
                else
                {
                    Console.WriteLine("Emp ID can't be null/0");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
