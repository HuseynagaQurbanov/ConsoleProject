﻿using MarketManagmentSystem.infrastructure.Enums;
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
                SaleNumber = 1,
                SaleAmount = 34.70,
                SaleDate = new DateTime(2020, 5, 16),
                SaleItem = new List<SaleItem>()
                {
                    new SaleItem
                    {
                        SaleItemNumber = 1,
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

            _sales.Add(new Sale
            {
                SaleNumber = 2,
                SaleAmount = 38.70,
                SaleDate = new DateTime(2020, 7, 23),
                SaleItem = new List<SaleItem>()
                {
                    new SaleItem
                    {
                        SaleItemNumber = 12,
                        SaleCount = 7,
                        SaleProduct = new Product()
                        {
                            ProductCategory = ProductCategoryType.Refrigerator,
                            ProductName = "Zuleyxa",
                            ProductPrice = 89,
                            ProductQuantity = 2,
                            ProductCode = "IN000015850"
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

        #region Sale Methods
        public void AddSale(Sale sale)
        {
            _sales.Add(sale);
        }

        public List<Sale> GetSaleByDate(DateTime date)
        {
            return _sales.Where(s => s.SaleDate == date).ToList();
        }

        public List<Sale> GetSaleBySaleNumber(double saleNumber)
        {
            return _sales.Where(s => s.SaleNumber == saleNumber).ToList();
        }

        public List<Sale> GetSalesByAmountRange(double startAmount, double endAmount)
        {
            return _sales.Where(s => s.SaleAmount >= startAmount && s.SaleAmount <= endAmount).ToList();
        }

        public List<Sale> GetSalesByDateRange(DateTime startDate, DateTime endDate)
        {
            return _sales.Where(s => s.SaleDate >= startDate && s.SaleDate <= endDate).ToList();
        }

        public void RemoveSale(int saleNumber)
        {
            Sale sale = _sales.Find(s => s.SaleNumber == saleNumber);

            _sales.Remove(sale);
        }

        public void RemoveProductBySaleItem(int saleNumber, string productCode, int quantity)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
