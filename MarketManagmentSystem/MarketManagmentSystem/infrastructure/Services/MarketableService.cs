using MarketManagmentSystem.infrastructure.Enums;
using MarketManagmentSystem.infrastructure.Interface;
using MarketManagmentSystem.infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarketManagmentSystem.infrastructure.Services
{
    public class MarketableService : IMarketable
    {
        private readonly List<Sale> _sales;
        public List<Sale> Sales => _sales;

        private readonly List<Product> _products;
        public List<Product> Products => _products;

        public MarketableService()
        {
            _products = new List<Product>();

            _products.Add(new Product
            {
                ProductCategory = ProductCategoryType.Refrigerator,
                ProductName = "Indesit TIAA 16 (UA)",
                ProductPrice = 509,
                ProductQuantity = 10,
                ProductCode = "IN000012954"
            });
            _products.Add(new Product
            {
                ProductCategory = ProductCategoryType.Phone,
                ProductName = "Telefon iPhone 12 Mini 64GB Blue",
                ProductPrice = 1969,
                ProductQuantity = 5,
                ProductCode = "IN000021939"
            });
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public void AddSale(string productCode)
        {
            throw new NotImplementedException();
        }

        public List<Product> EditProduct(string productCode)
        {
            return _products.FindAll(p => p.ProductCode == productCode).ToList();
        }

        public List<Product> GetProductsByAmountRange(double startAmount, double endAmount)
        {
            return _products.Where(p => p.ProductPrice >= startAmount && p.ProductPrice <= endAmount).ToList();
        }

        public List<Product> GetProductsByCategoryName(ProductCategoryType productCategory)
        {
            return _products.FindAll(p => p.ProductCategory == productCategory).ToList();
        }

        public List<Product> GetProductsByProductName(string productName)
        {
            return _products.FindAll(p => p.ProductName == productName);
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

        public void AddSale(Sale sale)
        {
            throw new NotImplementedException();
        }

        public void RemoveProduct(string productCode)
        {
            var resultlist = _products.ToList();
            var itemToRemove = resultlist.Single(r => r.ProductCode == productCode);
            _products.Remove(itemToRemove);
        }
    }
}
