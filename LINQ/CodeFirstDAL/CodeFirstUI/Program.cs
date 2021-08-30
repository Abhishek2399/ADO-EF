using System;
using CodeFirstBAL;
using CodeFirstProj.Models;

namespace CodeFirstUI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BAL dBbal = new BAL();
                dBbal.ShowAllEmployees();
                //dBbal.ShowEmployeeById(4);

                //Emp toAdd = new Emp() {Did = 0, Ename = "Abhi", Esal = 9000 };
                //Emp toUp = new Emp() { Eid = 9, Esal = 45786, Did = 4 };

                //dBbal.UpdateEmployeeByID(toUp);
                //dBbal.ShowEmployeeByName("Abhi");
                //dBbal.InsertEmployee(toAdd);

                //dBbal.DeleteEmployeeByName("Abhi");
                //dBbal.ShowAllEmployees();
                dBbal.ShowEmpDept();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
