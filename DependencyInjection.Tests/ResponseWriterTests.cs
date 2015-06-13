using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;

namespace DependencyInversion.Tests
{
    [TestFixture]
    public class ResponseWriterTests {

        [Test]
        public void WhenHtmlSelectedHtmlResponseIsCreated()  {
	        Assert.IsTrue(CreateResponseOfKind(ResponseKind.HTML).StartsWith("<html>"));
        }


        [Test]
        public void WhenXmlSelectedXmlResponseIsCreated()  {
	        Assert.IsTrue(CreateResponseOfKind(ResponseKind.XML ).StartsWith("<customer>"));
        }

        [Test]
        public void WhenStringIsSelectedstringResponseIsCreated()  {
	        Assert.IsTrue(CreateResponseOfKind(ResponseKind.STRING).StartsWith("Customer"));
        }

        private string CreateResponseOfKind(ResponseKind responseKind) {
	        Customer customer = new Customer("Kent Beck");
	        string response = new ResponseWriter().CreateResponse(customer, responseKind );
	        return response;
        }
    }
}
