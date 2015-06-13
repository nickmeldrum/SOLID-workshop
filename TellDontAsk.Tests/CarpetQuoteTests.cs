using NUnit.Framework;

namespace TellDontAsk.Tests
{
    [TestFixture]
    public class CarpetQuoteTests {
    	
	    [Test]
	    public void RoomFourBySixMetresRequiresTwentyFourSquareMetersOfCarpet() {
            var room = new Room(4, 6);
            
		    Assert.AreEqual(24, room.CalculateAreaOfCarpet());
	    }

        [Test]
        public void OneSquareMetreOfCarpetCostingNinePerMetreCostsTotalNine()
        {
            var room = new Room(1, 1);
            var carpet = new Carpet(room, 9, true);

            Assert.AreEqual(9, carpet.CalculateTotalPrice());
        }

        [Test]
	    public void RoomSixBySixMetresRequiresTwentyFourSquareMetersOfCarpet() {
            var room = new Room(6, 6);

		    Assert.AreEqual(36, room.CalculateAreaOfCarpet());
	    }

        [Test]
	    public void FourSquareMetresOfCarpetCostingNinePerMetreCostsTotalThirtySix() {
		    Assert.AreEqual(36, CreateCarpetQuoteForRoom(9, true, 2, 2).CalculateTotalPrice());
	    }
    	
	    [Test]
	    public void TwoPointTwoFiveSquareMetresOfCarpetCostingOnePerSquareMetreAndSoldByWholeSquareMetreCostsThree() {
		    Assert.AreEqual(3, CreateCarpetQuoteForRoom(1, true, 1.5, 1.5).CalculateTotalPrice());
	    }
    	
	    [Test]
	    public void twoPointTwoFiveSquareMetresOfCarpetCostingOnePerSquareMetreAndSoldByPartSquareMetreCostsTwoPointTwoFive(){
		    Assert.AreEqual(2.25, CreateCarpetQuoteForRoom(1, false, 1.5, 1.5).CalculateTotalPrice(), 0);
	    }
        
        private Carpet CreateCarpetQuoteForRoom(double pricePerSquareMetre, bool roundUpToSquareMetre, double width, double length)
        {
		    var room = new Room(width, length);
		    var carpet = new Carpet(room, pricePerSquareMetre, roundUpToSquareMetre);
		    return carpet;
	    }
    }
}
