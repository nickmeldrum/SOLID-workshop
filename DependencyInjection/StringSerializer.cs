using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion
{
    public class StringSerializer
    {

        public string SerializeToString(Customer customer)
        {
            return "Customer: " + customer.Name;
        }

    }
}
