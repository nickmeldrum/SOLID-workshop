using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;

namespace DependencyInversion.Tests
{
    [TestFixture]
    public class HtmlSerializerTests {
    	
	    [Test]
	    public void CustomerShouldBeWrittenInHtmlTable() {
		    Customer customer = new Customer("xyz");
		    string html = "<html><head><title>Customer Details</title></head>" +
						    "<body><table><tr><td>Customer</td><td>xyz" + 
						    "</td></tr></table></html>";
		    Assert.AreEqual(html , new HtmlSerializer().SerializeToHtml(customer));
	    }

    }
}
