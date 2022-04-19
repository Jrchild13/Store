namespace Store.Models
{
    public class ClientListView
    {
        public List<ClientView> ClientsRecords { get; set; }

        public ClientListView()
        {
            ClientsRecords = new List<ClientView>();
        }


    }
}
