using System;
using System.Collections.Generic;
using System.Text;

namespace LawOfDemeter
{
    public class Address
    {

        private Country country;

        public Address(Country country)
        {
            this.country = country;
        }

        public Country Country
        {
            get { return country; }
        }

    }
}
