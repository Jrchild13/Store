namespace Store.Db.Models
{
    public class ClientList
    {
        public string Name { get; set; }
        public int CustomerId { get; set; }
        public DateOnly? BirthDate { get; set; }
        public string Address { get; set; }
        public int Points { get; set; }
    }
}
