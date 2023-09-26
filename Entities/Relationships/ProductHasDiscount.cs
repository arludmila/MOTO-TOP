using Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Relationships
{
    public class ProductHasDiscount
    {
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set;}
        public int ProductId { get; set; }
        public int ProductDiscountId { get; set; }
        public Product Product { get; set; }
        public ProductDiscount ProductDiscount { get; set; }

    }
}
