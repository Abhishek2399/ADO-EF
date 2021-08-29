using System;
using DAL;
using DAL.Models;
using System.Text.RegularExpressions;

namespace BAL
{
    public class DbConnectBAL // Interface between the DAL and UI
    {
        private static DbConnectDAL dBdal;

        public DbConnectBAL()
        {
            dBdal = new DbConnectDAL();
        }

        // ---------- <Employee Related Methods> -----------

        public void ShowAllEmployees() // Show employees
        {
            dBdal.ShowAllEmployees();
        }

        public void ShowEmployeeById(int toSearch) // Display by id 
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

        public void ShowEmployeeByName(string nameToSearch) // Validate if the passed parameter is correct and call the SearchByName Method
        {
            string alphaNumPattern = @"[0-9]"; // if name contains numbers
            string specialChars = @"[!@#$%^&*]"; // if name contains special chars
            bool notAlpaNum = !Regex.IsMatch(nameToSearch, alphaNumPattern);
            bool noSpecialChar = !Regex.IsMatch(nameToSearch, specialChars);
            bool isValidName = noSpecialChar & notAlpaNum & nameToSearch != "" & nameToSearch != null & nameToSearch != " ";
            Console.WriteLine();
            if (isValidName)
            {
                dBdal.ShowEmployeeByName(nameToSearch);
            }
            else
            {
                Console.WriteLine("Invalid Name");
            }
        }

        public void DeleteEmployeeByName(string nameToDelete) // Validate if the passed parameter is correct and call the DeleteByName Method
        {
            string alphaNumPattern = @"[0-9]";
            string specialChars = @"[!@#$%^&*]";
            bool notAlpaNum = !Regex.IsMatch(nameToDelete, alphaNumPattern);
            bool noSpecialChar = !Regex.IsMatch(nameToDelete, specialChars);
            bool isValidName = noSpecialChar & notAlpaNum & nameToDelete != "" & nameToDelete != null & nameToDelete != " ";
            Console.WriteLine();
            if (isValidName)
            {
                dBdal.DeleteEmployeeByName(nameToDelete);
            }
            else
            {
                Console.WriteLine("Invalid Name");
            }
        }
        
        public void InsertEmployee(Emp toAdd = null) // Insert a new Employee 
        {
            try
            {
                if (toAdd.Eid > 0)
                {
                    string alphaNumPattern = @"[0-9]";
                    string specialChars = @"[!@#$%^&*]";
                    bool notAlpaNum = !Regex.IsMatch(toAdd.Ename, alphaNumPattern);
                    bool noSpecialChar = !Regex.IsMatch(toAdd.Ename, specialChars);
                    bool isValidName = noSpecialChar & notAlpaNum & toAdd.Ename != "" & toAdd.Ename != null & toAdd.Ename != " ";
                    if (isValidName)
                    {
                        if (toAdd.Sal > 1000)
                        {
                            dBdal.InsertEmployee(toAdd);
                        }
                        else Console.WriteLine("Salary Should be greater than 1000");
                    }
                    else Console.WriteLine("Name not Valid, shouldn't be alpha numeric or should not have special char");
                }
                else Console.WriteLine("ID should be greater than 0");

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}
