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
        List<Product> Products { get; }

        void AddSale(string productCode);
        void GetProductBySale(string productCode, int count);
        void RemoveSale(int saleNumber);
        List<Sale> GetSales();
        List<Sale> GetSalesByDateRange(DateTime startDate, DateTime endDate);
        List<Sale> GetSalesByAmountRange(double startAmount, double endAmount);
        void GetSaleByDate(DateTime Date);
        void GetSaleBySaleNumber(double saleNumber);
        void AddProduct(Product product);
        void EditProduct(string productCode);
        void RemoveProduct(string productCode);
        List<Product> GetProducts();
        List<Product> GetProductsByCategoryName(ProductCategoryType productCategory);
        List<Product> GetProductsByAmountRange(double startAmount, double endAmount);
        List<Product> GetProductsByProductName(string productName);
    }
}
