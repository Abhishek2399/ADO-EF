using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OopsDemo
{
    //USER BASED EXCEPTION
    class MyException:ApplicationException
    {
        public MyException(string msg) : base(msg)              //base class constructor
        {
            WritetoFile(msg);
        }

        private void WritetoFile(string msg)
        {
            string printline = string.Format($"Error occured on {DateTime.Now} It was related to {msg}");
            StreamWriter sw = new StreamWriter("error.txt", true);          //sw from system.io
            // StreamWriter class will write the error in error.txt file.
            sw.WriteLine(printline);
            sw.Close();
        }
    }
}
