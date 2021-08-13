using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CollectionDemo
{
    class TestEvent
    {
        static void Main()
        {
            Pen pen = new Pen { Rate = 100, Color = "blue" };
            pen.RateChange += ShowMessage; //3. Handling of event.
            pen.RateChange += WriteToFile; //to write msg in text file also along with displaying in colsole.
            Console.WriteLine(pen);
            pen.NewRate(250);
            Console.WriteLine(pen);
            //we have raised the event in server side but we have not handled the event in client side that is why exception is thrown.
        }

        private static void WriteToFile(string msg)
        {
            StreamWriter sw = new StreamWriter("msg.txt", true);
            sw.WriteLine(msg);
            sw.Close();
        }

        private static void ShowMessage(string msg) //handling of event.
        {
            Console.WriteLine(msg);
        }
    }
}
