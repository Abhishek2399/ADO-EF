using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    class TestIndexers
    {
        static void Main()
        {
            MyFacebook fb1 = new MyFacebook(3);
            fb1.Username = "tom";
            //indexers become the properties of the ARRAY.
            fb1[0] = "india won gold";
            fb1[1] = "tom loves milk";
            fb1[2] = "Hi all";
            for(int i=0;i<3;i++)
            {
                Console.WriteLine($"the post is by {fb1.Username} {i+1} ========> {fb1[i]}");
            }
        }
    }
}
