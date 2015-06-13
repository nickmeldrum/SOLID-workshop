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
    	
        [Test]
	    [ExpectedException(typeof(DebitAmountExceedsLimitException))]
	    public void CannotDebitMoreThanAvailableBalance() {
            BankAccount account = CreateAccountWithStartingBalance(0);
            account.Debit(50);
	    }

        protected virtual BankAccount CreateAccountWithStartingBalance(int balance)
        {
		    BankAccount account = new BankAccount();
		    account.Credit(balance);
		    return account;
	    }
    }
}
