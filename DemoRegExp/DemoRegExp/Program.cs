using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace DemoRegExp
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = "Todayiswednesday";
            string input2 = "Today is Wednesday";
            string pattern = @"^[a-zA-z0-9]*$"; //$- means it should end with any of the defined characters.space is not defined so input 2 is false.
            var result = Regex.IsMatch(input1, pattern);
            Console.WriteLine($"The result of first input {result}");
            result = Regex.IsMatch(input2, pattern);
            Console.WriteLine($"The result of second input {result}");
            string pattern1 = @"^[0-9]{3}[A-Z]{2}$";
            string input3 = "452ET";
            result = Regex.IsMatch(input3, pattern1);
            Console.WriteLine($"The result of input 3 is {result}");
            string pattern2 = @"^Super\s";  //word shld shart with Super followed by a space.
            Console.WriteLine($"{Regex.IsMatch("Super man is great",pattern2)}");

            //pattern of website address check,
            string pattern3 = @"^www[.][a-zA-Z]{3,20}[.](com|in|net)$";
            Console.WriteLine($"{Regex.IsMatch("wwwCapgemini.com", pattern3)}");
            Console.WriteLine($"{Regex.IsMatch("www.IndiawonMedal.in", pattern3)}");
            Console.WriteLine($"{Regex.IsMatch("www.IndiawonGoldMedalinOlympics.in", pattern3)}");

            Console.WriteLine($"{Regex.IsMatch("ATE","A.E")}");

            Regex regex = new Regex(pattern);
            var result1 = regex.IsMatch(input3);
        }
    }
}
