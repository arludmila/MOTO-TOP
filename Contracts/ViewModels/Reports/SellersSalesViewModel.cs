using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ViewModels.Reports
{
    public class SellersSalesViewModel
    {
        public int SellerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Zone { get; set; }
        public int TotalSales { get; set; }
    }
}
