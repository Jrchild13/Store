namespace Store.ViewModels
{
    public class OrderRowListView
    {
        public List<OrderRowView> Name { get; set; }
        public List<OrderRowView> Orders { get; set; }

        public OrderRowListView()
        {
            Orders = new List<OrderRowView>();
            Name = new List<OrderRowView>();
        }
    }
}
