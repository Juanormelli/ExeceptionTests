using Bank.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithDrawLimit { get; set; }


        public Account()
        {

        }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void WithDraw(double amount)
        {
            if (amount > Balance)
            {
                throw new AppException ( "Withdraw amount is higher than the balance!");
            }
            if (amount > WithDrawLimit)
            {
                throw new AppException("WithDraw amount is higher than your withdraw Limit!");
            }
            
            Balance -= amount;
        }
        public override string ToString()
        {
            return "Balance: " + Balance;
            
        }

    }
}
