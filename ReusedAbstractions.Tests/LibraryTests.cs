using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;

namespace ReusedAbstractions.Tests
{
    [TestFixture]
    public class LibraryTests {
    	
	    [Test]
	    public void BookAddedToLibraryIsAvailableToBorrow() {
		    BookImpl book = new BookImpl(null, null, 0);
		    ILibrary library = new LibraryImpl();
		    library.AddBook(book);
		    Assert.IsTrue(library.Books.Contains(book));
	    }
    	
	    [Test]
	    public void LibraryDumpListsBookSummariesOnNewLines() {
		    ILibrary library = new LibraryImpl();
		    library.AddBook(new BookImpl("Jaws", "Peter Benchley", 1974));
		    library.AddBook(new BookImpl("Foundation", "Isaac Asimov", 1951));
		    string expectedDump = "Jaws by Peter Benchley, published 1974/n" +
								    "Foundation by Isaac Asimov, published 1951";
		    Assert.AreEqual(expectedDump, library.DumpContents());
	    }

    }
}
