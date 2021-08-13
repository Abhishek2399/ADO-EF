using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace DemoRegExp
{
    class Test3
    {
        //REPLACE IN REGULAR EXPRESSION.
        static void Main()
        {
            string input1 = " Today is wednesday";
            string pattern1 = @"\s+";
            string replace1 = "-";
            Regex regex = new Regex(pattern1);
            string result = regex.Replace(input1, replace1);
            Console.WriteLine($"{input1} ============> {result}");
        }
    }
}
