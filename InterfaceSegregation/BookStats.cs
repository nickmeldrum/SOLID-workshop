using System.Collections.Generic;

namespace InterfaceSegregation
{
    public class BookStats {

	    private IList<IBookRating> books;

	    public BookStats(IList<IBookRating> books) {
		    this.books = books;
	    }

	    public IList<IBookRating> GetBooksWithRating(int rating) {
            IList<IBookRating> booksWithRating = new List<IBookRating>();
            foreach (IBookRating book in books)
            {
			    if(book.Rating == rating)
				    booksWithRating.Add(book);
		    }
		    return booksWithRating;
	    }

    }
}
