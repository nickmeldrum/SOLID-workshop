using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibility
{
    public class BankTransfer {

	    private BankAccount payer;
	    private BankAccount payee;
	    private double amount;

	    public BankTransfer(BankAccount payer, BankAccount payee, double amount) {
		    this.payer = payer;
		    this.payee = payee;
		    this.amount = amount;
	    }

	    public void Execute() {
		    payer.Withdraw(amount);
		    payee.Deposit(amount);
	    }

	    public string ToXml() {
		    return "<BankTransfer amount='" + amount.ToString() + "'>" +
				    "<Payer>" + payer.AccountNumber + "</Payer>" +
				    "<Payee>" + payee.AccountNumber + "</Payee>" +
				    "</BankTransfer>";
	    }

    }
}
