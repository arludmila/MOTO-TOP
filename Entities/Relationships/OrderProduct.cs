﻿using Entities.Core;

namespace Entities.Relationships
{
    public class OrderProduct
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Guid? OrderId { get; set; }
        public int? InvoiceId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        public Order? Order { get; set; }
        public Invoice? Invoice { get; set; }
    }
}
