namespace Store.Db.Models
{
    public class ClientsRecordView
    {
        public List<ClientsRecord> ClientOrders { get; set; }
        public List<ClientsRecord> ClientName { get; set; }

        public ClientsRecordView()
        {
            ClientOrders = new List<ClientsRecord>();
            ClientName = new List<ClientsRecord>();
        }
    }
}
