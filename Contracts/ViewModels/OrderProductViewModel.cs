using Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ViewModels
{
    public class OrderProductViewModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Guid? OrderId { get; set; }
        public int? InvoiceId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        // product
        public string ProductCategoryName { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
    }
}
