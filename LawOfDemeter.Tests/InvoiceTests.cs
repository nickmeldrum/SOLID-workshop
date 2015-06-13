using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;

namespace LawOfDemeter.Tests
{
    [TestFixture]
    public class InvoiceTests {
	
	    [Test]
	    public void ShippingShouldBeAddedIfAddressIsNotInEurope()
	    {
	        var country = new Country(false);
    		
		    Invoice invoice = new Invoice(country);
		    invoice.AddItem(new InvoiceItem("Product X", 1, 100));
    		
		    Assert.AreEqual(100 + Invoice.SHIPPING_COST_OUTSIDE_EU, 
				    invoice .TotalPrice);
	    }

    }
}
