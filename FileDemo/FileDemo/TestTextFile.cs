using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileDemo
{
    class TestTextFile
    {
        static void Main()
        {
            //creating text files.
            #region Input characters in text file.
            //FileStream filestream = new FileStream("abc.txt", FileMode.Create, FileAccess.Write);
            //StreamWriter sw = new StreamWriter(filestream);
            //string oline;
            //Console.WriteLine("type a line :");
            //oline = Console.ReadLine();
            // sw.WriteLine(oline);
            //sw.Close();
            #endregion

            #region Multiple line inputs to create a file.
            //StreamWriter sw = new StreamWriter("xyz.txt", true); //true for appending the file.
            //string oline;
            //Console.WriteLine("type the context of file");
            //do
            //{
            //    oline = Console.ReadLine();
            //   sw.WriteLine(oline);
            //
            //} while (oline.Length!=0);
            //sw.Close();
            //Console.WriteLine("file create successfully");
            #endregion

            #region Reading text file.

            StreamReader sr = new StreamReader("xyz.txt");
            StreamWriter sw = new StreamWriter("pqr.txt", false); //to reasd from xyz and copy to pqr.we write false bcoz we want to create it instead of just appending it. this way everytime we run multiple copies will not be created.
            string oline = null;
            while((oline=sr.ReadLine())!=null)
            {
                Console.WriteLine(oline);
                sw.WriteLine(oline);
            }
            sr.Close();
            sw.Close();
            #endregion
        }
    }
}
