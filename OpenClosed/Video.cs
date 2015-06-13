using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed
{
    public class Video {

	    private string title;
	    private int year;
	    private string director;
	    private bool onLoan = false;
	    private Customer borrower;

	    public Video(string title, int year, string director) {
		    this.title = title;
		    this.year = year;
		    this.director = director;
	    }

	    public virtual string Summary {
            get { return title + ", " + year.ToString() + ", dir: " + director; }
	    }

	    public virtual bool IsOnLoan {
            get { return onLoan; }
	    }

	    public virtual void Borrow(Customer customer) {
		    borrower = customer;
		    onLoan = true;
	    }

	    public virtual Customer Borrower {
            get { return borrower; }
	    }

    }
}
