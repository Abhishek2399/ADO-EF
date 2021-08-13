using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking;

namespace OopsDemo
{
    class TestBanking
    {
        static void Main()
        {
            int amount;
            Savings s = new Savings();
            Console.WriteLine("Enter customer name");
            s.Name = Console.ReadLine();
            Console.WriteLine("Enter customer Id");
            s.ID = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter customer balance");
            s.Balance = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter customer minimum balance");
            //minbalance = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ennter the amount to deposit : ");
            amount = Convert.ToInt32(Console.ReadLine());
            s.Deposit(amount);
            Console.WriteLine($"Balance in account after depositing is : {s.Balance}");

            Console.WriteLine("Ennter the amount to withdraw : ");
            amount = Convert.ToInt32(Console.ReadLine());
            try
            {
                s.Withdraw(amount);
                Console.WriteLine($"Balance in account after withdrawing is : {s.Balance}");
                
                s.Withdraw(2000);
                Console.WriteLine($"Balance in account after withdrawing is : {s.Balance}");

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
    }
}
