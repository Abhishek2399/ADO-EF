using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public abstract class Customer
    {
        public int ID {get;set;}
        public string Name { get; set; }
        public int Balance { get; set; }

        public abstract void Deposit(int amount);
        public abstract void Withdraw(int amount);

    }
}
