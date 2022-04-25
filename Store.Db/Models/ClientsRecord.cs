namespace Store.Db.Models
{
    public class ClientsRecord
    {
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public string Name { get; set; }
    }
}
