using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    //INDEXERS DEMO.
    class MyFacebook
    {
        public string Username { get; set; }
        string[] MyPost;//private and to access it we take help of properties with the help of indexers.
        public MyFacebook(int size)
        {
            MyPost = new string[size];
        }
        public string this[int pos] //creating properties here we call it by keyword this wo use the indexers.
        {
            get { return MyPost[pos]; }
            set { MyPost[pos] = value; }
        }
    }
}