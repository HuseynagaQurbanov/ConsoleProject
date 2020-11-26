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

            _sales = new List<Sale>();
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
            _products.Add(new Product
            {
                ProductCategory = ProductCategoryType.Refrigerator,
                ProductName = "Gorenje NRK6192KW",
                ProductPrice = 789,
                ProductQuantity = 7,
                ProductCode = "IN000015880"
            });

            _sales.Add(new Sale
            {
                SaleNumber = 121212,
                SaleAmount = 34.70,
                SaleDate = new DateTime(2020, 11, 05),
                SaleItem = new List<SaleItem>()
                {
                    new SaleItem
                    {
                        SaleItemNumber = 1212,
                        SaleCount = 5,
                        SaleProduct = new Product()
                        {
                            ProductCategory = ProductCategoryType.Refrigerator,
                            ProductName = "Gorenje NRK6192KW",
                            ProductPrice = 789,
                            ProductQuantity = 7,
                            ProductCode = "IN000015880"
                        }
                    }
                }


            });
        }

        #region Product Methods
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public List<Product> EditProduct(string productCode)
        {
            return _products.FindAll(p => p.ProductCode == productCode).ToList();
        }

        public List<Product> GetProductsByAmountRange(double startAmount, double endAmount)
        {
            return _products.Where(p => p.ProductPrice >= startAmount && p.ProductPrice <= endAmount).ToList();
        }

        public void GetProductsByCategoryName(ProductCategoryType productCategory)
        {
            List<Product> list = _products.FindAll(p => p.ProductCategory == productCategory).ToList();

            foreach (var item in list)
            {
                Console.WriteLine("{0},{1},{2}",item.ProductCode,item.ProductName,item.ProductPrice);
            }
        }

        public List<Product> GetProductsByProductName(string productName)
        {
            return _products.FindAll(p => p.ProductName == productName);
        }

        public void RemoveProduct(string productCode)
        {
            var resultlist = _products.ToList();
            var itemToRemove = resultlist.Single(r => r.ProductCode == productCode);
            _products.Remove(itemToRemove);
        }
        #endregion

        public void AddSale(Sale sale)
        {
            _sales.Add(sale);
        }

        public void GetSaleByDate(DateTime date)
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

        public void RemoveSale(int saleNumber)
        {
            
        }

       
    }
}
