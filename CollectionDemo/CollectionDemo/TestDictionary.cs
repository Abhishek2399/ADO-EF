using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class TestDictionary
    {
        static void Main()
        {
            Dictionary<int, string> player = new Dictionary<int, string>();
            player.Add(1, "Dhoni");
            player.Add(2, "Virat");
            player.Add(3, "Rohit");
            player.Add(4, "Yuvraj");
            player.Add(5, "Bumrah");
            Console.WriteLine(player[2]);
            Console.WriteLine(player[5]);
            if (player.ContainsKey(5))
                player[5] = "Ashwin";
            Console.WriteLine(player[5]);
            foreach (int pl in player.Keys)
            {
                Console.WriteLine($"{pl} ===> {player[pl]}");
            }
        }
    }
}
