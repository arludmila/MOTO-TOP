using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Core
{
    public class Invoice : EntityBase
    {
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
