using System;
using System.Collections.Generic;
using System.Text;

namespace TellDontAsk
{
    public class CarpetQuote {
    	
	    private Room room;
	    private Carpet carpet;

	    public CarpetQuote(Room room, Carpet carpet)
	    {
		    this.room = room;
		    this.carpet = carpet;
    		
	    }

	    public double CalculateAreaOfCarpet() {
		    return room.Width * room.Length;
	    }

	    public double CalculateTotalPrice() {
		    double totalCostAsDecimal = CalculateAreaOfCarpet() * carpet.PricePerSquareMetre;
		    if(carpet.IsRoundedUpToWholeSquareMetre)
			    return Math.Ceiling(totalCostAsDecimal);
		    return totalCostAsDecimal;
	    }

    }
}
