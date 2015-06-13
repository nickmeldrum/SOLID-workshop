using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;

namespace OpenClosed.Tests
{
    [TestFixture]
    public class CustomerTests {
    	
	    [Test]
	    public void CustomerWithThreeVideosBorrowedCannotBorrowMore() {
		    Customer customer = new Customer();
		    for(int i = 0; i < 3; i++){
			    customer.BorrowVideo(new Video(null, 0, null));
		    }
		    Assert.IsFalse(customer.IsAllowedToBorrow);
	    }
    	
	    [Test]
	    public void VideoBorrowedByCustomerIsFlaggedAsOnLoan() {
		    Video video = new Video(null, 0, null);
		    Customer customer = new Customer();
		    customer.BorrowVideo(video);
		    Assert.IsTrue(video.IsOnLoan);
	    }
    	
	    [Test]
	    public void VideoBorrowedByCustomerShowsCustomerAsBorrower() {
		    Video video = new Video(null, 0, null);
		    Customer customer = new Customer();
		    customer.BorrowVideo(video);
		    Assert.AreSame(customer, video.Borrower);
	    }

    }
}
