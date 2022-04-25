using Store.Db.Entities;

namespace Store.Models
{
    public class ClientGridView
    {
        public IEnumerable<Customer> Customers { get; set; }

        public ClientGridView()
        {
            Customers = new List<Customer>();
        }


    }
}
