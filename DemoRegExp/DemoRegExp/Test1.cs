using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace DemoRegExp
{
    class Test1
    {
        //define array of data and then decide valid or invalid pattern.
        static void Main()
        {
            string pattern = @"^[a-zA-Z0-9]\d{2}[a-zA-Z0-9](-\d{3}){2}[A-Za-z0-9]$";

            //first shld be either a letter or a digit then \d{2} 2 digits(\d - digits) -\d{3} means '-' sign then 3 digits {2} means '-' sign then 3 digits should be repeated twice then finally a letter should come.

            string[] data = { "1270-239-2143", "A09Z-931-468A", "_890-123-234x", "12345-KKA-1230", "0919-2738-2654", "A890-123-234x" };
            foreach(string d in data)
            {
                Console.WriteLine($"{d} {Regex.IsMatch(d,pattern)}");
            }
        }
    }
}
