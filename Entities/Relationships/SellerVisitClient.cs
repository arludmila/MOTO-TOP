using Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Relationships
{
    public class SellerVisitClient
    {
        public int SellerId { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; } = null!;
        public Seller Seller { get; set; } = null!;
        public DateTime Date { get; set; }
    }
}
