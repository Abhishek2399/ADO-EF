using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace DemoReflection
{
    class AssemblyLoad
    {
        static void Main()
        {
            //TO FIND DETAILS OF an ASSEMBLY OR APPLICATION OR CLASS AT RUN TIME.
            //------------------------------------------------------------------------

            //1. give the file name which dll you wanna load.
            string filename = @"D:\Capgemini_codes\OopsDemo\OopsDemo\bin\Debug\OopsDemo.exe";
            //2.loading that application 
            Assembly assembly = Assembly.LoadFrom(filename);
            //3.creating array of type Type and storing details of type/class in it.
            Type[] types = assembly.GetTypes();
            //4. looping through the type details to print 
            foreach (Type t in types)  
            {
                Console.WriteLine($"==================={t.Name}==================");
                MemberInfo[] members = t.GetMembers();  //5.Getting all members of each Type and storing in array.
                foreach(MemberInfo mi in members)       //6. looping through array to print all the members.
                {
                    Console.WriteLine($"{mi.Name}--------{mi.MemberType}");
                }
            }
        }
    }
}
