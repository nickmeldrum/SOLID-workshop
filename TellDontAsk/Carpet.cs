using System;

namespace TellDontAsk
{
    public class Carpet {
        private readonly Room room;

        private readonly double pricePerSquareMetre;
	    private readonly bool roundUpToSquareMetre;

        public Carpet(Room room, double pricePerSquareMetre, bool roundUpToSquareMetre)
        {
            this.room = room;
            this.pricePerSquareMetre = pricePerSquareMetre;
		    this.roundUpToSquareMetre = roundUpToSquareMetre;
	    }
        public double CalculateTotalPrice()
        {
            var totalCostAsDecimal = room.CalculateAreaOfCarpet() * pricePerSquareMetre;
            return this.roundUpToSquareMetre ? Math.Ceiling(totalCostAsDecimal) : totalCostAsDecimal;
        }
    }
}
