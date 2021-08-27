using System;
using DAL;

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
