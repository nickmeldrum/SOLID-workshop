using System;
using System.Collections.Generic;
using System.Text;

namespace ReusedAbstractions
{
    public interface IBookStats
    {
        IList<IBook> GetBooksWithRating(int rating);
       
    }
}
