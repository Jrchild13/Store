namespace online_store.ViewModels
{
    public class OrderRowListView
    {

        public string Name { get; set; }
        public List<OrderRowView> Orders { get; set; }

        public OrderRowListView()
        {
            Orders = new List<OrderRowView>();
        }
    }
}
