using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsApp
{
    class SavingsAccount : Account
    {
        public double Interest { get; set; }

        private const double TRANSACTION_FEE = 2.25;

        public SavingsAccount(int number, string name, double balance, double interest) : base(number, name, balance)
        {
            Interest = interest;
        }

        public override void Deposit(double amount)
        {
            Balance = Balance + (amount - TRANSACTION_FEE);
        }

        public override void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance = Balance - (amount + TRANSACTION_FEE);
            }
        }
    }
}
