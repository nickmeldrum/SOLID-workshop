using System;
using System.Collections.Generic;
using System.Text;

namespace TellDontAsk
{
    public class Room {

	    private double width;
	    private double length;

	    public Room(double width, double length) {
		    this.width = width;
		    this.length = length;
	    }

	    public double Length {
            get { return length; }
	    }

	    public double Width {
            get { return width; }
	    }

    }
}
