using System;
using System.Collections.Generic;
using System.Text;

namespace ReusedAbstractions
{
    public class BookStatsImpl : IBookStats {

	    private IList<IBook> books;

	    public BookStatsImpl(IList<IBook> books) {
		    this.books = books;
	    }

	    public IList<IBook> GetBooksWithRating(int rating) {
		    IList<IBook> booksWithRating = new List<IBook>();
		    foreach(IBook book in books) {
			    if(book.Rating == rating)
				    booksWithRating.Add(book);
		    }
		    return booksWithRating;
	    }

    }
}
