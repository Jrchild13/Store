using System;
namespace Store.Db.Models
{
    public class ClientListView
    {
        public List<ClientList> Clients { get; set; }

        public ClientListView()
        {
            Clients = new List<ClientList>();
        }
    }
}
