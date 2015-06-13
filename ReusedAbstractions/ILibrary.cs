using System;
using System.Collections.Generic;
using System.Text;

namespace ReusedAbstractions
{
    public interface ILibrary
    {
        IList<IBook> Books { get; }

        void AddBook(IBook book);

        string DumpContents();
    }
}
