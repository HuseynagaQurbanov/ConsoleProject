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

        void AddSale(string productCode);
        void GetProductBySale(string name, int count);
        void RemoveSale(int saleNumber);
        List<Sale> GetSales();
        void GetSalesByDateRange(DateTime startDate, DateTime endDate);
        void GetSalesByAmountRange(double startAmount, double endAmount);
        void GetSaleByDate(DateTime Date);
        void GetSaleBySaleNumber(double saleNumber);

    }
}
