using System;
using System.Collections.Generic;

namespace online_store.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; } = null!;
        public int QuantityInStock { get; set; }
        public decimal UnitPrice { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
