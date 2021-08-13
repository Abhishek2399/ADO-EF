using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    class TestException
    {
        static void Main()
        {
            try
            {
                int a = 10, b = 20, c = 0;
                if (b <= a)
                {
                    c = a / b;
                    Console.WriteLine($"c = {c}");
                }
                else
                {
                    throw new MyException("Value of a shld be more than b"); // to throw the exception from myexception we created as user exception.

                    // to throw exception normally.
                    //throw new Exception("Value of a shld be more than b");


                }

                somemethod();
                Console.WriteLine("hi all");
                int[] nums = new int[5];
                nums[6] = 10;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("EEEEErrrooooorrrrr");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("welcome to exception");
            }
        }

        private static void somemethod()
        {
            try
            {
                Pen p = null;
                p.Rate = 90;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
