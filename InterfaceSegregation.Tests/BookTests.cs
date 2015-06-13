using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;

namespace InterfaceSegregation.Tests
{
    [TestFixture]
    public class BookTests {

	    [Test]
	    public void BookSummaryHasTitleAuthorAndYearPublished() {
		    Book book = new Book("Watership Down", "Richard Adams", 1972);
		    Assert.AreEqual("Watership Down by Richard Adams, published 1972",
				    book.Summary);
	    }
    	
	    [Test]
	    public void BookRatingIsAverageOfUserRatings() {
		    Book book = new Book(null, null, 0);
		    book.Rate(3);
		    book.Rate(5);
		    Assert.AreEqual(4, book.Rating);
	    }
    }
}
