using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion
{
    public class XmlSerializer
    {

        public string SerializeToXml(Customer customer)
        {
            return "<customer>" + customer.Name + "</customer>";
        }

    }
}
