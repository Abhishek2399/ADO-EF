using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    static class MyFunction
    {
        public static int MyWordCount(this string str) //this shld be the first parameter. and we want to work on string.
        {
            int count = str.Split(' ').Count();
            return count;
        }
        public static string OddEven(this int n)
        {
            if (n % 2 == 0)
                return "Even";
            else
                return "Odd";
        }
        public static string ValidPhone(this String str)
        {
            //check the no 123-456-789 and remove hipens in numbers to read as 123456789.
            StringBuilder sb = new StringBuilder();
            for(int i=0;i<str.Length;i++)
            {
                if (Char.IsNumber(str[i]))
                {
                    sb.Append(str[i]);
                }
            }
            return sb.ToString(); //converting string builder object to string and returning it.
        }

        // using extend method but not using same class here we are using Pen class object inside TestEnum class.So two parameters.
        public static float PenDiscount(this Pen p,int disc) //1st parameter is the reference of pen type object and 2ndparameter is the discount.
        {
            float discamount;
            discamount = p.Rate*disc / 100;
            return discamount;
        }
    }
}
