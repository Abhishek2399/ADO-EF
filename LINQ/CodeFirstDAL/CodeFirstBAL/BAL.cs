using System;
using CodeFirstDAL;
using CodeFirstProj.Models;
using System.Text.RegularExpressions;

namespace CodeFirstBAL
{
    public class BAL
    {
        private static DAL dBDAL ;

        public BAL()
        {
            dBDAL = new DAL();
        }

        public void ShowAllEmployees() // Show employees
        {
            dBDAL.ShowAllEmployees();
        }

        public void ShowEmployeeById(int toSearch) // Display by id 
        {
            if (toSearch > 0)
            {
                dBDAL.ShowEmployeeByID(toSearch);
            }
            else
            {
                Console.WriteLine("ID Can't be negative");
            }
        }

        public void UpdateEmployeeByID(Emp empUpdates) // Get Employee By ID and Update Details
        {
            try
            {
                if (empUpdates.Eid > 0)
                {
                    dBDAL.UpdateEmployeeByID(empUpdates);
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
            string alphaNumPattern = @"[0-9]"; 
            string specialChars = @"[!@#$%^&*]"; // if name contains special chars
            bool notAlpaNum = !Regex.IsMatch(nameToSearch, alphaNumPattern); // if name is not alpha-num
            bool noSpecialChar = !Regex.IsMatch(nameToSearch, specialChars); // if name does not have special chars
            bool isValidName = noSpecialChar & notAlpaNum & nameToSearch != "" & nameToSearch != null & nameToSearch != " ";
            Console.WriteLine();
            if (isValidName)
            {
                dBDAL.ShowEmployeeByName(nameToSearch);
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
                dBDAL.DeleteEmployeeByName(nameToDelete);
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
                    string alphaNumPattern = @"[0-9]"; // Alpha num check
                    string specialChars = @"[!@#$%^&*]"; // Special char check
                    bool notAlpaNum = !Regex.IsMatch(toAdd.Ename, alphaNumPattern);
                    bool noSpecialChar = !Regex.IsMatch(toAdd.Ename, specialChars);
                    bool isValidName = noSpecialChar & notAlpaNum & toAdd.Ename != "" & toAdd.Ename != null & toAdd.Ename != " ";
                    if (isValidName)
                    {
                        if (toAdd.Esal > 1000)
                        {
                            dBDAL.InsertEmployee(toAdd);
                        }
                        else Console.WriteLine("Salary Should be greater than 1000");
                    }
                    else Console.WriteLine("Name not Valid, shouldn't be alpha numeric or should not have special char");
                
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ShowEmpDept()
        {
            dBDAL.ShowEmpDept();
        }


    }
}
