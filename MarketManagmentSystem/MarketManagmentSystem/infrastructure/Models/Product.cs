using MarketManagmentSystem.infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketManagmentSystem.infrastructure.Models
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public ProductCategoryName Category { get; set; }
        public int Quantity { get; set; }
        public string ProductCode { get; set; }
    }
}
