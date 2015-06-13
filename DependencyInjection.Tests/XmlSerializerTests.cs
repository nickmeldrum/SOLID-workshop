using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;

namespace DependencyInversion.Tests
{
    [TestFixture]
    public class XmlSerializerTests {
    	
	    [Test]
	    public void CustomerShouldBeWrittenInXml() {
		    Customer customer = new Customer("xyz");
		    string html = "<customer>xyz</customer>";
		    Assert.AreEqual(html , new XmlSerializer().Serialize(customer));
	    }

    }
}
