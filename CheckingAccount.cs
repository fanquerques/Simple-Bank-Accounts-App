using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsApp
{
    class CheckingAccount:Account
    {
        public double Limit { get; set; }

        private const double TRANSACTION_FEE = 1.00;

        public CheckingAccount(int number, string name, double balance, double limit) : base(number, name, balance)
        {
            Limit = limit;
        }

        public override void Deposit(double amount)
        {
            Balance = Balance + (amount - TRANSACTION_FEE);
        }

        public override void Withdraw(double amount)
        {
            if (amount <= Limit && amount <= Balance)
            {
                Balance = Balance - (amount + TRANSACTION_FEE);
            }
        }
    }
}
