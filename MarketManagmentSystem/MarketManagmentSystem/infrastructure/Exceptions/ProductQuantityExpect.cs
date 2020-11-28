using System;
using System.Collections.Generic;
using System.Text;

namespace MarketManagmentSystem.infrastructure.Exceptions
{
    public class ProductQuantityExpect : Exception
    {
        public ProductQuantityExpect(string message) : base(message) { }
    }
}
