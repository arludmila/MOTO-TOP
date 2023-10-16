﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Name { get; set; }
        public double PurchasePrice { get; set; }
        public double SellingPrice { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        
    }
}
