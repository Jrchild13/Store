using System;
using System.Collections.Generic;

namespace Store.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateOnly OrderDate { get; set; }
        public sbyte Status { get; set; }
        public string? Comments { get; set; }
        public DateOnly? ShippedDate { get; set; }
        public short? ShipperId { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual Shipper? Shipper { get; set; }
        public virtual OrderStatus StatusNavigation { get; set; } = null!;
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
