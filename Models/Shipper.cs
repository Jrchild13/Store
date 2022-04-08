using System;
using System.Collections.Generic;

namespace online_store.Models
{
    public partial class Shipper
    {
        public Shipper()
        {
            Orders = new HashSet<Order>();
        }

        public short ShipperId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; }
    }
}
