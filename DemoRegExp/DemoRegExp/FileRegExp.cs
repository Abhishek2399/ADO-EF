using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
namespace DemoRegExp
{
    class FileRegExp
    {
        static void Main()
        {
            try
            {

                StreamReader sr = new StreamReader("xyz.txt");
                StreamWriter sw = new StreamWriter("pqr.txt");
                string oline = null;
                string pattern = @"^[0-9]";
                string pattern1 = @"\s+";
                string replace1 = ",";
                Regex regex = new Regex(pattern1);
                while ((oline = sr.ReadLine()) != null)
                {
                    if (Regex.IsMatch(oline, pattern))
                    {
                        string result = regex.Replace(oline, replace1);
                        sw.WriteLine(result);
                        Console.WriteLine($"{oline} ============> {result}");
                    }

                }
                sr.Close();
                sw.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
