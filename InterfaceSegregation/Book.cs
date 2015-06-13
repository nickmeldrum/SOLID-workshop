using System;

namespace InterfaceSegregation
{
    public class Book : IBookSummary, IBookRating, IRateBooks
    {
	    private string title;
	    private string author;
	    private int yearPublished;
	    private float totalRating = 0;
	    private int ratingsCount = 0;

	    public Book(string title, string author, int yearPublished) {
		    this.title = title;
		    this.author = author;
		    this.yearPublished = yearPublished;
	    }

	    public string Summary {
            get
            {
                return title + " by " + author + ", published "
                  + yearPublished.ToString();
            }
	    }

	    public void Rate(int scoreOutOfFive) {
		    ratingsCount++;
		    totalRating += scoreOutOfFive;
	    }

	    public int Rating {
            get { return (int)Math.Round(totalRating / ratingsCount, 0); }
	    }

    }
}
