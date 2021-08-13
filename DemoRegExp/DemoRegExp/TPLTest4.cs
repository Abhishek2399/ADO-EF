using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRegExp
{
    class TPLTest4
    {
        static void Main()
        {
            Account account = new Account(1000);
            Task[] tasks = new Task[2]; //for testing multiple tasks
            for(int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = Task.Run(() => UpdateAccount(account));
            }
            Task.WaitAll(tasks);
        }

        private static void UpdateAccount(Account account)
        {
            //method will be called two times
            //generate random value;
            var rmd = new Random();
            for(int i = 0; i < 2; i++)  //we will check two times debit and two times credit.
            {
                int amt = rmd.Next(1,500);  //generate no within 1 to 100. 
                bool yes = amt < 200 ? true : false;
                if (yes)
                {
                    account.Debit(amt);
                }
                else
                    account.Credit(amt);
            }
        }
    }
}
