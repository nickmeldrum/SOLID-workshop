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
            var books = new List<IRateBooks>();
		    AddBookWithRating(books, 5);
		    AddBookWithRating(books, 5);
		    AddBookWithRating(books, 1);
    		
		    Assert.AreEqual(2, new BookStats(books).GetBooksWithRating(5).Count);
	    }

        private void AddBookWithRating(IList<IRateBooks> books, int rating)
        {
		    IRateBooks book1 = new Book(null, null, 0);
		    book1.Rate(rating);		
		    books.Add(book1);
	    }

    }
}
