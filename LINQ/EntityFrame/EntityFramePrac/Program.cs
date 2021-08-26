using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramePrac
{
    class Program
    {
        static DemoProjEntities DB = new DemoProjEntities();

        static void AddEmp(emp newEmp)
        {
            try
            {
                DB.emps.Add(newEmp);
                DB.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        static void UpdateEmp(int id)
        {
            emp toUpdate = DB.emps.Find(id);
           
        }

        static void Main(string[] args)
        {


        }
    }
}
