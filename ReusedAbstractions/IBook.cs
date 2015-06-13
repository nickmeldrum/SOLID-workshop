using System;
using System.Collections.Generic;
using System.Text;

namespace ReusedAbstractions
{
    public interface IBook
    {
	    string Summary { get; }

	    void Rate(int scoreOutOfFive);

	    int Rating { get; }

    }
}
