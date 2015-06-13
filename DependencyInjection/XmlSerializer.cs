
namespace DependencyInversion
{
    public class XmlSerializer : ISerialize
    {

        public string Serialize(Customer customer)
        {
            return "<customer>" + customer.Name + "</customer>";
        }

    }
}
