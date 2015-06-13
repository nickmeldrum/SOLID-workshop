using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace SingleResponsibility.Tests
{
    [TestFixture]
    public class BankTransferTests {
    	
	    private BankAccount payer;
	    private BankAccount payee;
	    private BankTransfer transfer;

	    [Test]
	    public void RransferDeductsAmountFromPayersBalance() {
		    ExecuteBankTransfer();
		    Assert.AreEqual(50, payer.Balance);
	    }

    	
	    [Test]
	    public void TransferAddsAmountToPayeesBalance() {
		    ExecuteBankTransfer();
		    Assert.AreEqual(50, payee.Balance);
	    }
    	
	    [Test]
	    public void TransferSerializedToXmlHasPayerIDPayeeIDAndAmount() {
		    string expectedXml = "<BankTransfer amount='50'><Payer>1234</Payer><Payee>2345</Payee></BankTransfer>";
		    ExecuteBankTransfer();
		    Assert.AreEqual(expectedXml , transfer.ToXml());
	    }
    	
	    private void ExecuteBankTransfer() {
		    payer = new BankAccount(1234);
		    payee = new BankAccount(2345);
		    payer.Deposit(100);
		    transfer = new BankTransfer(payer, payee, 50, new Reporter());
		    transfer.Execute();
	    }

    }
}
