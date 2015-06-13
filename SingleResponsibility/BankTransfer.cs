using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibility
{
    public class BankTransfer {

	    private BankAccount payer;
	    private BankAccount payee;
	    private double amount;

        private Reporter reporter;

	    public BankTransfer(BankAccount payer, BankAccount payee, double amount, Reporter reporter) {
		    this.payer = payer;
		    this.payee = payee;
		    this.amount = amount;
	        this.reporter = reporter;
	    }

	    public void Execute() {
		    payer.Withdraw(amount);
		    payee.Deposit(amount);
	    }

        public string ToXml()
        {
            return reporter.ToXml(payer.AccountNumber, payee.AccountNumber, amount);
        }
    }
}
