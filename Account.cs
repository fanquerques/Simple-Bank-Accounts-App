using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsApp
{
    abstract class Account
    {
        public int Number { get; }
        public double Balance { get; protected set; }
        public string Name { get; }

        public Account(int number, string name, double balance)
        {
            Number = number;
            Name = name;
            Balance = balance;
        }

        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
    }
}
