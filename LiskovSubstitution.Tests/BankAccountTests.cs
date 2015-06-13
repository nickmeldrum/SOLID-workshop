using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;

namespace LiskovSubstitution.Tests
{
    [TestFixture]
    public class BankAccountTests {
    	
	    [Test]
	    public void DebitingAccountSubtractsAmountFromBalance() {
		    BankAccount account = CreateAccountWithStartingBalance(100);
		    account.Debit(50);
		    Assert.AreEqual(50, account.Balance );
	    }

    	
	    [Test]
	    public void CreditingAccountAddsAmountToBalance() {
		    BankAccount account = CreateAccountWithStartingBalance(100);
		    Assert.AreEqual(100, account.Balance);
	    }
    	
	    [ExpectedException(typeof(DebitAmountExceedsLimitException))]
	    public void CannotDebitMoreThanAvailableBalance() {
		    new BankAccount().Debit(50);
	    }

	    private BankAccount CreateAccountWithStartingBalance(int balance) {
		    BankAccount account = new BankAccount();
		    account.Credit(balance);
		    return account;
	    }
    }
}
