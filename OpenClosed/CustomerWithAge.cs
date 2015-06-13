namespace OpenClosed
{
    using System;

    public class CustomerWithAge : Customer
    {
        private readonly Customer customer;

        public CustomerWithAge(int age)
        {
            this.Age = age;
            customer = new Customer();
        }

        public int Age { get; private set; }

        public bool IsAgeAppropriate(VideoWithRating video)
        {
            if (video.Rating > this.Age) return false;

            return customer.IsAllowedToBorrow;
        }
    }
}
