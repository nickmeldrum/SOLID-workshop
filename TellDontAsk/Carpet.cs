using System;
using System.Collections.Generic;
using System.Text;

namespace TellDontAsk
{
    public class Carpet {

	    private double pricePerSquareMetre;
	    private bool roundUpToSquareMetre;

	    public Carpet(double pricePerSquareMetre, bool roundUpToSquareMetre) {
		    this.pricePerSquareMetre = pricePerSquareMetre;
		    this.roundUpToSquareMetre = roundUpToSquareMetre;
	    }

	    public double PricePerSquareMetre {
            get { return pricePerSquareMetre; }
	    }

	    public bool IsRoundedUpToWholeSquareMetre {
            get { return roundUpToSquareMetre; }
	    }

    }
}
