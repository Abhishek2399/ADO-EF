using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace DemoRegExp
{
    class Test2
    {
        static void Main()
        {
            string input = "the Sun Sets in the west during summer";
            string pattern = @"\bS\S*";         // \b - starting of word and \bS means word shld start with 'S'
            MatchCollection match = Regex.Matches(input, pattern);
            foreach(Match m in match)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine("--------------------------");
            string pattern1 = @"\bh\S*e\b";     //means we want words starting with 'h' and ending with 'e'.
            string input1 = "Hi all, how are you. stay home stay safe. Life is very important there is only one life.enjoy it and keep it safe.Home sweet home ! house is the best place to live comfortabely.harrase less";
            match = Regex.Matches(input1, pattern1);
            foreach (Match m in match)
            {
                Console.WriteLine(m);
            }
            string names = "Tom,Ajay Shah,Ajgar,Amit,Raj,Varun,Dhoni";
            string pattern2 = @"\b[A][j]\w+";  // w means word, + means one word only,[j] means second letter as 'j'. 
            match = Regex.Matches(names, pattern2);
            Console.WriteLine("--------------------------------");
            foreach (Match m in match)
            {
                Console.WriteLine(m);
            }

            string pattern3 = @"\b[aA][m]\w+";  // either word startng with a/A and second letter as 'm'. 
            match = Regex.Matches(names, pattern3);
            Console.WriteLine("--------------------------------");
            foreach (Match m in match)
            {
                Console.WriteLine(m);
            }
        }
    }
}
