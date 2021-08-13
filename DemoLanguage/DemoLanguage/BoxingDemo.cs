using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLanguage
{
    class BoxingDemo
    {
        public static void Main()
        {
            int x = 10;
            object oo;
            // value type we are storing into reference type which is called as boxing.
            oo = x;
            Console.WriteLine(oo);
            x = 20;
            Console.WriteLine(oo);

            // reference type storing in value type it is called as unboxing
            int y;
            //y = oo;//problem bcoz of CASTING . convert object type to int.object typecan store any data type but not vice versa.
            y = Convert.ToInt32(oo);
            Console.WriteLine(y);
        }
    }
}
