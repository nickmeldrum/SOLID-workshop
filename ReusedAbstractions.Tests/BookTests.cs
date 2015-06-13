using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;

namespace ReusedAbstractions.Tests
{
    [TestFixture]
    public class BookTests {

	    [Test]
	    public void BookSummaryHasTitleAuthorAndYearPublished() {
		    IBook book = new BookImpl("Watership Down", "Richard Adams", 1972);
		    Assert.AreEqual("Watership Down by Richard Adams, published 1972",
				    book.Summary);
	    }
    	
	    [Test]
	    public void BookRatingIsAverageOfUserRatings() {
		    IBook book = new BookImpl(null, null, 0);
		    book.Rate(3);
		    book.Rate(5);
		    Assert.AreEqual(4, book.Rating);
	    }
    }
}
