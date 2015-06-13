using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitution
{
    public class BankAccount
    {

        private double balance = 0;

        public double Balance
        {
            get { return balance; }
        }

        public void Debit(double amount)
        {
            if (amount > balance)
                throw new DebitAmountExceedsLimitException();
            balance -= amount;
        }

        public void Credit(double amount)
        {
            balance += amount;
        }


    }
}
