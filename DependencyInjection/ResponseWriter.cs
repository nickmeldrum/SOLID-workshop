using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion
{
    public class ResponseWriter
    {

        public string CreateResponse(Customer customer, ISerialize serializer)
        {
            if (serializer == null)
                throw new ArgumentException("you must include a serializer", "serializer");

            return serializer.Serialize(customer);
        }

    }
}
