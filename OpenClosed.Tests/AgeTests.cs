namespace OpenClosed.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class AgeTests
    {

        [Test]
        public void CustomerWhoIs17CannotRentAn18Video()
        {
            var customer = new CustomerWithAge(17);
            var video = new VideoWithRating(null, 0, null, 18);

            Assert.IsFalse(customer.IsAgeAppropriate(video));
        }

        [Test]
        public void CustomerWhoIs19CanRentAn18Video()
        {
            var customer = new CustomerWithAge(19);
            var video = new VideoWithRating(null, 0, null, 18);

            Assert.IsTrue(customer.IsAgeAppropriate(video));
        }

        [Test]
        public void CustomerWithAgeCanBorrowVideo()
        {
            var customer = new CustomerWithAge(19);
            var video = new VideoWithRating(null, 0, null, 18);

            customer.BorrowVideo(video);

            Assert.AreEqual(video.Borrower, customer);            
        }
    }
}
