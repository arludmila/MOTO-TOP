using Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Relationships
{
    public class OrderProduct
    {
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int? InvoiceId { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set; }
        public Invoice? Invoice { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

    }
}
