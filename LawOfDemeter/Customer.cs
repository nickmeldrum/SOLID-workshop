namespace LawOfDemeter
{
    public class Customer
    {
        private readonly Address address;

        public Customer(Address address)
        {
            this.address = address;
        }

        public bool IsInEurope()
        {
            return address.IsInEurope();
        }
    }
}
