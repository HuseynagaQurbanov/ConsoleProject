using MarketManagmentSystem.infrastructure.Enums;
using MarketManagmentSystem.infrastructure.Interface;
using MarketManagmentSystem.infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketManagmentSystem.infrastructure.Services
{
    public class MarketableService : IMarketable
    {
        public List<Sale> Sales => throw new NotImplementedException();

        public List<Product> Products => throw new NotImplementedException();

        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void AddSale(string productCode)
        {
            throw new NotImplementedException();
        }

        public void EditProduct(string productCode)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByAmountRange(double startAmount, double endAmount)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByCategoryName(ProductCategoryType productCategory)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByProductName(string productName)
        {
            throw new NotImplementedException();
        }

        public void GetSaleByDate(DateTime Date)
        {
            throw new NotImplementedException();
        }

        public void GetSaleBySaleNumber(double saleNumber)
        {
            throw new NotImplementedException();
        }

        public List<Sale> GetSales()
        {
            throw new NotImplementedException();
        }

        public List<Sale> GetSalesByAmountRange(double startAmount, double endAmount)
        {
            throw new NotImplementedException();
        }

        public List<Sale> GetSalesByDateRange(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public void RemoveProductBySaleItem(int saleNumber, string productCode, int quantity)
        {
            throw new NotImplementedException();
        }

        List<Sale> IMarketable.GetSaleByDate(DateTime Date)
        {
            throw new NotImplementedException();
        }
    }
}
