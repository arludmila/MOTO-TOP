using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ViewModels
{
    public class DiscountedProductViewModel
    {
        public int Id { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string CategoryName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double OriginalPrice { get; set; }
        public double DiscountPercentage { get; set; }
        public double DiscountAmount { get; set; }
        public double DiscountedPrice { get; set; }
        public string ImagePath { get; set; }
    }
}
