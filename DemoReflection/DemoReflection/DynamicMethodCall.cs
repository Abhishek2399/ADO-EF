using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace DemoReflection
{
    class DynamicMethodCall
    {
        static void Main()
        {
            try
            {
                Assembly assembly = Assembly.GetExecutingAssembly(); //getting current assembly information.
                Type type = assembly.GetType("DemoReflection.MyMaths"); //to get details of particular class GetType().

                //creating instance of m maths below so that we can call the methods of class MyMaths:
                object objMath = assembly.CreateInstance("DemoReflection.MyMaths");

                //to get info about the properties so that we can set the values.
                PropertyInfo[] properties = type.GetProperties();
                properties[0].SetValue(objMath, 70); //setting value for 2 properties.where to set(in objMath) and what value to set.
                properties[1].SetValue(objMath, 60);

                //To get information about the methods and then execute it.
                MethodInfo method = type.GetMethod("Add");

                //invoke method.
                int result = (int)method.Invoke(objMath, null); //null mean method add was not taking any parameters.
                Console.WriteLine($"Add {result}");

                //invoking method with parameters and not by properties.
                MethodInfo method1 = type.GetMethod("Multiply");
                int result1 = (int)method1.Invoke(objMath, new object[] { 4, 2 });
                Console.WriteLine($"Multiply {result1}");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
