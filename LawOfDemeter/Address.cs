namespace LawOfDemeter
{
    public class Address
    {

        private readonly Country country;

        public Address(Country country)
        {
            this.country = country;
        }

        public bool IsInEurope()
        {
            return country.IsInEurope;
        }
    }
}
