using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;

namespace LawOfDemeter.Tests
{
    [TestFixture]
    public class InvoiceTests {
	
	    [Test]
	    public void ShippingShouldBeAddedIfAddressIsNotInEurope() {
    		
		    Address address = new Address(new Country(false));
		    Customer customer = new Customer(address);
    		
		    Invoice invoice = new Invoice(customer);
		    invoice.AddItem(new InvoiceItem("Product X", 1, 100));
    		
		    Assert.AreEqual(100 + Invoice.SHIPPING_COST_OUTSIDE_EU, 
				    invoice .TotalPrice);
	    }

    }
}
