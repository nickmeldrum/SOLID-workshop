namespace TellDontAsk
{
    public class Room {

	    private readonly double width;
	    private readonly double length;

	    public Room(double width, double length) {
		    this.width = width;
		    this.length = length;
	    }
        public double CalculateAreaOfCarpet() {
            return width * length;
        }
    }
}
