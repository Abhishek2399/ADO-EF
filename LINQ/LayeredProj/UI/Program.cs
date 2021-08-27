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
                Emp e = DB.Emps.Find(1);
                Console.WriteLine($"{e.Eid} : {e.Ename}");
                db.ShowMixData();

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }       

        }
    }
}
