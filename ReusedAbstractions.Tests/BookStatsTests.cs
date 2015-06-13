using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;

namespace ReusedAbstractions.Tests
{
    [TestFixture]
    public class BookStatsTests {
    	
	    [Test]
	    public void TwoBooksRatedFiveFoundInListOfThreeBooks() {
		    IList<IBook> books = new List<IBook>();
		    AddBookWithRating(books, 5);
		    AddBookWithRating(books, 5);
		    AddBookWithRating(books, 1);
    		
		    Assert.AreEqual(2, new BookStatsImpl(books).GetBooksWithRating(5).Count);
	    }

	    private void AddBookWithRating(IList<IBook> books, int rating) {
		    IBook book1 = new BookImpl(null, null, 0);
		    book1.Rate(rating);		
		    books.Add(book1);
	    }

    }
}
