﻿using Contracts.Utils;
using Entities.Relationships;

namespace Contracts.DTOs.Relationships
{
    public class OrderProductDto
    {
        public int ProductId { get; set; }
        // rubro + nombre!!!
        public string? ProductName { get; set; }
        public Guid? OrderId { get; set; }
        public int? InvoiceId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
