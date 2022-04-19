namespace Store.Models
{
    public class ClientsListView
    {
        public List<ClientsView> Name { get; set; }
        public List<ClientsView> Orders { get; set; }

        public ClientsListView()
        {
            Orders = new List<ClientsView>();
            Name = new List<ClientsView>();
        }
    }
}
