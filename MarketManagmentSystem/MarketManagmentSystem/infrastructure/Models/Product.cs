using MarketManagmentSystem.infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketManagmentSystem.infrastructure.Models
{
    public class Product
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public ProductCategoryName ProductCategory { get; set; }
        public int ProductQuantity { get; set; }
        public string ProductCode { get; set; }
    }
}
