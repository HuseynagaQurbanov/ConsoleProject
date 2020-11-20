using MarketManagmentSystem.infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketManagmentSystem.infrastructure.Interface
{
    public interface IMarketable
    {
        List<Sale> Sales { get; }
        List<Product> Products { get; }
    }
}
