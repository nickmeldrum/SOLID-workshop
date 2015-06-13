using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation
{
    public class Library
    {

        private readonly IList<IBookSummary> books = new List<IBookSummary>();

        public IList<IBookSummary> Books
        {
            get { return books; }
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public string DumpContents()
        {
            string dump = "";

            foreach (IBookSummary book in books )
            {
                dump += book.Summary;
                if (books.IndexOf(book) < books.Count - 1)
                    dump += "/n";
            }

            return dump;
        }

    }
}
