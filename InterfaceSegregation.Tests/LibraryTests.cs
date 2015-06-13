using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;

namespace InterfaceSegregation.Tests
{
    [TestFixture]
    public class LibraryTests {
    	
	    [Test]
	    public void BookAddedToLibraryIsAvailableToBorrow() {
		    Book book = new Book(null, null, 0);
		    Library library = new Library();
		    library.AddBook(book);
		    Assert.IsTrue(library.Books.Contains(book));
	    }
    	
	    [Test]
	    public void LibraryDumpListsBookSummariesOnNewLines() {
		    Library library = new Library();
		    library.AddBook(new Book("Jaws", "Peter Benchley", 1974));
		    library.AddBook(new Book("Foundation", "Isaac Asimov", 1951));
		    string expectedDump = "Jaws by Peter Benchley, published 1974/n" +
								    "Foundation by Isaac Asimov, published 1951";
		    Assert.AreEqual(expectedDump, library.DumpContents());
	    }

    }
}
