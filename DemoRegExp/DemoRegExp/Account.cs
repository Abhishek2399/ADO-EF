using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRegExp
{
    class Account
    {
        object objlock = new object();
        int balance;
        public Account(int bal)
        {
            this.balance = bal;
        }
        public int Debit(int amt)
        {
            lock (objlock)
            {
                Console.WriteLine($"Balance before Debit - {balance,5}");   //5 means reserved 5 spaces for printing the number.s
                //cw("balance b4 debit = {0}{1},balance,amt)   0,1 is the placeholder.
                Console.WriteLine($"amount to be removed - {amt,5}");
                balance = balance - amt;
                Console.WriteLine($"Balance after debit - {balance,5}");
                Console.WriteLine("----------------------------------------------");
                return balance;
            }
        }
        public int Credit(int amt)
        {
            lock (objlock)
            {
                Console.WriteLine($"Balance before Credit - {balance,5}");   //5 means reserved 5 spaces for printing the number.s
                Console.WriteLine($"amount to be added - {amt,5}");
                balance = balance - amt;
                Console.WriteLine($"Balance after Credit - {balance,5}");
                Console.WriteLine("-----------------------------------------------");
                return balance;
            }
        }
        public void Dummy()
        {
            Dictionary<int, string> Players = new Dictionary<int, string>();
            Players.Add(1, "Dhoni");
            Players[2] = "Virat";
        }
        //public class Products
        //{
         //   public int ID { get; set; } = 120;  //auto updated properties initializers. this way we can give default values to object instead of doing it with constructor.
        //}

    }
}
