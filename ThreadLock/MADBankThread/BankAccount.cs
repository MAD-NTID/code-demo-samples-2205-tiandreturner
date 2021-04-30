using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADBankThread
{
    class BankAccount
    {
        public double Balance { get; set; }
        public string Name { get; set; }
        //add lock
        private object accountLock = new object();

        public BankAccount(double bal)
        {
            Balance = bal;
        }

        public double Withdraw(double amt)
        {

                if ((Balance - amt) < 0)
                {
                    Console.WriteLine($"ERROR: {Balance} is insufficient for this amount {amt}");

                }
            lock (accountLock)
            {
                if (Balance >= amt)
                {

                    Console.WriteLine($"Removed {amt} and {Balance - amt} left in account");
                    Balance -= amt; //this is leet code and it works

                }
            }

            return Balance;
        }

        public void IssueWithdraw()
        {
            Withdraw(40);
        }

    }
}
