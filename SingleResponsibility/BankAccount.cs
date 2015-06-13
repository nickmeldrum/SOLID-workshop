using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibility
{
    public class BankAccount
    {

        private double balance = 0;
        private int accountNumber;

        public BankAccount(int accountNumber)
        {
            this.accountNumber = accountNumber;

        }

        public double Balance
        {
            get { return balance; }
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            balance -= amount;
        }

        public int AccountNumber
        {
            get { return accountNumber; }
        }

    }
}
