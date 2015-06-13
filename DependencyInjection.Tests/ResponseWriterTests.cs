using NUnit.Framework;

namespace DependencyInversion.Tests
{
    [TestFixture]
    public class ResponseWriterTests {

        [Test]
        public void WhenHtmlSelectedHtmlResponseIsCreated()  {
	        Assert.IsTrue(CreateResponseOfKind(new HtmlSerializer()).StartsWith("<html>"));
        }


        [Test]
        public void WhenXmlSelectedXmlResponseIsCreated()  {
	        Assert.IsTrue(CreateResponseOfKind(new XmlSerializer()).StartsWith("<customer>"));
        }

        [Test]
        public void WhenStringIsSelectedstringResponseIsCreated()  {
            Assert.IsTrue(CreateResponseOfKind(new StringSerializer()).StartsWith("Customer"));
        }

        private string CreateResponseOfKind(ISerialize serializer) {
	        Customer customer = new Customer("Kent Beck");
	        string response = new ResponseWriter().CreateResponse(customer, serializer);
	        return response;
        }
    }
}
