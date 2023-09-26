using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Core
{
    public class ProductDiscount
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double Percentage { get; set; }
    }
}
