using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion
{
    public class StringSerializer : ISerialize
    {

        public string Serialize(Customer customer)
        {
            return "Customer: " + customer.Name;
        }

    }
}
