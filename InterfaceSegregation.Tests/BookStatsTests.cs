using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;

namespace InterfaceSegregation.Tests
{
    [TestFixture]
    public class BookStatsTests {
    	
	    [Test]
	    public void TwoBooksRatedFiveFoundInListOfThreeBooks() {
		    IList<Book> books = new List<Book>();
		    AddBookWithRating(books, 5);
		    AddBookWithRating(books, 5);
		    AddBookWithRating(books, 1);
    		
		    Assert.AreEqual(2, new BookStats(books).GetBooksWithRating(5).Count);
	    }

	    private void AddBookWithRating(IList<Book> books, int rating) {
		    Book book1 = new Book(null, null, 0);
		    book1.Rate(rating);		
		    books.Add(book1);
	    }

    }
}
