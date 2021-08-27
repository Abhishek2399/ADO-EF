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



            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }       

        }
    }
}
