using System;
using System.Collections.Generic;
using System.Text;

namespace MarketManagmentSystem.infrastructure.Models
{
    public class SaleItem
    {
        public int ItemNumber { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
