using MarketManagmentSystem.infrastructure.Enums;
using MarketManagmentSystem.infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketManagmentSystem.infrastructure.Interface
{
    public interface IMarketable
    {
        List<Sale> Sales { get; }
        List<SaleItem> SaleItems { get; }
        List<Product> Products { get; }

        void AddSale(int saleNumber, int saleCount);
        void RemoveProductBySaleItem(int saleNumber, string productCode, int quantity);
        void RemoveSale(int saleNumber);
        List<Sale> GetSalesByDateRange(DateTime startDate, DateTime endDate);
        List<Sale> GetSalesByAmountRange(double startAmount, double endAmount);
        List<Sale> GetSaleByDate(DateTime date);
        List<Sale> GetSaleBySaleNumber(double saleNumber);
        void AddProduct(Product product);
        List<Product> EditProduct(string productCode);
        void GetProductsByCategoryName(ProductCategoryType productCategory);
        List<Product> GetProductsByAmountRange(double startAmount, double endAmount);
        List<Product> GetProductsByProductName(string productName);
        void RemoveProduct(string productCode);
        List<SaleItem> ShowSaleItem(int saleNumber);
    }
}
