using Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Relationships
{
    public class SupplierProvidesProduct
    {
        public int ProductId { get; set; }
        public int SupplierId { get; set;}
        public Product Product { get; set; }
        public Supplier Supplier { get; set; }
    }
}
