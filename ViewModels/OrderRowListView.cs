namespace online_store.ViewModels
{
    public class OrderRowListView
    {
        public List<OrderRowView> Orders { get; set; }

        public OrderRowListView()
        {
            Orders = new List<OrderRowView>();
        }
    }
}
