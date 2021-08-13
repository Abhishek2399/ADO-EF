using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace DemoRegExp
{
    class Test4
    {
        static void Main()
        {
            //  SPLIT IN REGULAR EXPRESSION.
            string exp1 = "20 + 50 / 5 * 100";
            string pattern1 = @"\s+";
            var result1 = Regex.Split(exp1, pattern1);
            foreach(var r in result1)
            {
                Console.WriteLine(r);
            }
            Console.WriteLine("-----------------------");
            string input1 = "abcdef223738dfhico890";
            string pattern2 = @"\D+"; //for splitting nos and excluding alphabets.
            var result2 = Regex.Split(input1, pattern2);
            foreach (var r in result2)
            {
                Console.WriteLine(r);
            }
            Console.WriteLine("-----------------------");
            string pattern3 = @"\d+";   //for splitting alphabets excluding numbers.
            var result3 = Regex.Split(input1, pattern3);
            foreach (var r in result3)
            {
                Console.WriteLine(r);
            }
        }
    }
}
