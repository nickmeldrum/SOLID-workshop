using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation
{
    public class BookStats {

	    private IList<Book> books;

	    public BookStats(IList<Book> books) {
		    this.books = books;
	    }

	    public IList<Book> GetBooksWithRating(int rating) {
		    IList<Book> booksWithRating = new List<Book>();
		    foreach(Book book in books) {
			    if(book.Rating == rating)
				    booksWithRating.Add(book);
		    }
		    return booksWithRating;
	    }

    }
}
