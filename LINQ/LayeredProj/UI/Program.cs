using System;
using DAL;
using DAL.Models;


namespace UI
{
    class Program
    {
        public static DBConnect db = new DBConnect();
        
        static void Main(string[] args)
        {
            try
            {
                //Connection to the Databse
                //db.ShowAllDept();

                EFCoreContext DB = new EFCoreContext();

                //db.ShowMixData();
                //db.DispAllEmps();
                //db.DispEmpById(2, "Abhishek");

                Emp newEmp = new Emp();
                newEmp.Eid = 19;
                newEmp.Ename = "Owen";
                newEmp.Did = 400;
                newEmp.Sal = 4000000;

                //db.AddEmp(newEmp);
                //db.DispAllEmps();
                //db.DelEmpProc(newEmp.Eid);
                Emp toUp = new Emp();
                toUp.Eid = 2;
                toUp.Ename = "Abhishek";
                db.UpdateEmp(toUp); // needs some updation 

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }       

        }
    }
}
