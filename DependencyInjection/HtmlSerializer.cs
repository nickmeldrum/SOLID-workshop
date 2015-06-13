using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion
{
    public class HtmlSerializer : ISerialize
    {

        public string Serialize(Customer customer)
        {
            return "<html><head><title>Customer Details</title></head>" +
            "<body><table><tr><td>Customer</td><td>" + customer.Name +
            "</td></tr></table></html>";
        }

    }

}
