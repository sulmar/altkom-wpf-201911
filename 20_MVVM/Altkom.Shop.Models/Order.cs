using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Altkom.Shop.Models
{
    public class Order : BaseEntity
    {
        public DateTime CreatedOn { get; set; }
        public Customer Customer { get; set; }
        public IEnumerable<OrderDetail> Details { get; set; }
        public decimal TotalAmount => Details.Sum(d => d.DetailAmount);

        public Order()
        {
            Details = Enumerable.Empty<OrderDetail>();
        }

    }

    public class OrderDetail : BaseEntity
    {
        public Product Product { get; set; }
        public short Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DetailAmount => UnitPrice * Quantity;
    }
}
