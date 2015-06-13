using System;
using System.Collections.Generic;
using System.Text;

namespace LawOfDemeter
{
    public class Customer
    {

        private Address address;

        public Customer(Address address)
        {
            this.address = address;
        }

        public Address Address
        {
            get { return address; }
        }

    }
}
