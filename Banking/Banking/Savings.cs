using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class Savings:Customer
    {
        int minbalance=500;

        public override void Deposit(int amount)
        {
            Balance = Balance + amount;
            //return Balance;
        }

        public override void Withdraw(int amount)
        {
            if (minbalance > Balance )
                throw new Exception("Balance should be more than minimum balance to withdraw");
            Balance = Balance - amount;
        }
    }
}
