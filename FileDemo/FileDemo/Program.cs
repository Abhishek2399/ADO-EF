using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DirectoryInfo info = new DirectoryInfo(@"d:\labbook\lab1");
                DirectoryInfo[] directories = info.GetDirectories(); //put all folders of that directory in an array.
                foreach (var di in directories) //folder in capgemini_codes.
                {
                    Console.WriteLine($"{di.Name}");
                    Console.WriteLine($"{di.FullName}");
                    Console.WriteLine($"{di.Parent}");
                    Console.WriteLine($"{di.CreationTime}");

                    FileInfo[] files = di.GetFiles(); //file inside current folder
                    foreach (var f in files) //display all files inside current folder.
                    {
                        Console.WriteLine($"=========================={f.Name}---------{f.Length}-------{f.CreationTime}");
                    }
                    Console.WriteLine("*************************************************************************************");
                }
                try
                {
                    DirectoryInfo di = new DirectoryInfo(@"d:\others_code");
                    di.CreateSubdirectory("Test Folder");
                    Console.WriteLine("folder created");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
