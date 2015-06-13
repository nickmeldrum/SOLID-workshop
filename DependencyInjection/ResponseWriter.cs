using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion
{
    public class ResponseWriter
    {

        public string CreateResponse(Customer customer, ResponseKind responseKind)
        {
            if (responseKind == ResponseKind.HTML)
            {
                return new HtmlSerializer().SerializeToHtml(customer);
            }
            else if (responseKind == ResponseKind.XML)
            {
                return new XmlSerializer().SerializeToXml(customer);

            }
            return new StringSerializer().SerializeToString(customer);
        }

    }
}
