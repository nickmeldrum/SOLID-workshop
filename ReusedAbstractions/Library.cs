using System;
using System.Collections.Generic;
using System.Text;

namespace ReusedAbstractions
{
    public class LibraryImpl : ILibrary
    {

        private IList<IBook> books = new List<IBook>();

        public IList<IBook> Books
        {
            get { return books; }
        }

        public void AddBook(IBook book)
        {
            books.Add(book);
        }

        public string DumpContents()
        {
            string dump = "";

            foreach (IBook book in books )
            {
                dump += book.Summary;
                if (books.IndexOf(book) < books.Count - 1)
                    dump += "/n";
            }

            return dump;
        }

    }
}
