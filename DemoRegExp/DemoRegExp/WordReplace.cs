using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
namespace DemoRegExp
{
    class WordReplace
    {
        static void Main()
        {
            ReplaceFile("news.txt", "Tuesday", "Wednesday");
            Console.WriteLine("Replacement done!");
            
        }

        private static void ReplaceFile(string filename, string v2, string v3)
        {
            string newContent;
            StreamReader sr = new StreamReader(filename);
            string wholeData = sr.ReadToEnd();
            sr.Close();
            newContent = Regex.Replace(wholeData, v2, v3);
            StreamWriter sw = new StreamWriter(filename);
            sw.WriteLine(newContent);
            sw.Close();
            Console.WriteLine(newContent);
        }
    }
}
