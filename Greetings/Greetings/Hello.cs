using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greetings
{
    public class Hello
    {
        public string Welcome(string name)
        {
            return $"Welcome {name}";
        }
        public string Goodbye()
        {
            return "Good bye to .net";
        }
        public string TimePass()
        {
            return "Timepass";
        }
    }
}
