using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;

namespace DependencyInversion.Tests
{
    [TestFixture]
    public class StringSerializerTests {
    	
	    [Test]
	    public void CustomerShouldBeWrittenInSimpleString() {
		    Customer customer = new Customer("xyz");
		    string html = "Customer: xyz";
		    Assert.AreEqual(html , new StringSerializer().Serialize(customer));
	    }

    }
}
