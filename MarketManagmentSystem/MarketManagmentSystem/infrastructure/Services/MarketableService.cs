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

        private readonly List<SaleItem> _saleItems;
        public List<SaleItem> SaleItems => _saleItems;

        private readonly List<Product> _products;
        public List<Product> Products => _products;

        #region Defaults
        public MarketableService()
        {
            _sales = new List<Sale>();
            _saleItems = new List<SaleItem>();
            _products = new List<Product>();

            #region Default Product
            _products.Add(new Product
            {
                ProductCategory = ProductCategoryType.Refrigerator,
                ProductName = "Indesit TIAA 16 (UA)",
                ProductPrice = 25,
                ProductQuantity = 10,
                ProductCode = "AAA"
            });

            _products.Add(new Product
            {
                ProductCategory = ProductCategoryType.Phone,
                ProductName = "Telefon iPhone 12 Mini 64GB Blue",
                ProductPrice = 40,
                ProductQuantity = 5,
                ProductCode = "BBB"
            });

            _products.Add(new Product
            {
                ProductCategory = ProductCategoryType.Refrigerator,
                ProductName = "Gorenje NRK6192KW",
                ProductPrice = 10,
                ProductQuantity = 7,
                ProductCode = "CCC"
            });
            #endregion

            #region Default SaleItem
            _saleItems.Add(new SaleItem
            {
                SaleItemNumber = 1,
                SaleCount = 1,
                SaleProduct = _products.Find(p => p.ProductCode == "AAA")

            });

            _saleItems.Add(new SaleItem
            {
                SaleItemNumber = 2,
                SaleCount = 2,
                SaleProduct = _products.Find(p => p.ProductCode == "BBB")

            });

            _saleItems.Add(new SaleItem
            {
                SaleItemNumber = 3,
                SaleCount = 3,
                SaleProduct = _products.Find(p => p.ProductCode == "CCC")

            });
            #endregion

            #region Default Sale
            _sales.Add(new Sale
            {
                SaleNumber = 1,
                SaleAmount = 25,
                SaleDate = new DateTime(2020, 5, 16),
                SaleItem = _saleItems.FindAll(si=>si.SaleCount==1)
            });

            _sales.Add(new Sale
            {
                SaleNumber = 2,
                SaleAmount = 80,
                SaleDate = new DateTime(2020, 8, 19),
                SaleItem = _saleItems.FindAll(si => si.SaleCount == 2)
            });

            _sales.Add(new Sale
            {
                SaleNumber = 3,
                SaleAmount = 30,
                SaleDate = new DateTime(2020, 11, 27),
                SaleItem = _saleItems.FindAll(si => si.SaleCount == 3)
            });
            #endregion
        }
        #endregion

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
                Console.WriteLine("{0},{1},{2}", "Məhsulun kodu: "  + item.ProductCode, "\n" + "Məhsulun adı: " + item.ProductName, "\n" + "Məhsulun qiyməyi: " + item.ProductPrice);
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
        public void AddSale(string productCode, int productQuantity)
        {
            List<SaleItem> saleItems = new List<SaleItem>();
            double amount = 0;

            var product = _products.Where(p => p.ProductCode== productCode).FirstOrDefault();
            var saleItem = new SaleItem();
            var Code = productCode;

            bool check = _products.Exists(p => p.ProductCode == productCode);
            if (check == false)
            {
                Console.WriteLine("");
                Console.WriteLine("-------------- Daxil etdiyiniz koda görə məhsul tapılmadı --------------");
            }
            else
            {
                saleItem.SaleCount = productQuantity;
                if (product.ProductQuantity < productQuantity)
                {
                    Console.WriteLine("");
                    Console.WriteLine("-------------- Daxil etdiyiniz miqdarda məhsul yoxdur --------------");
                    Console.WriteLine("");
                }
                else
                {
                    product.ProductQuantity -= productQuantity;
                    saleItem.SaleProduct = product;
                    saleItem.SaleItemNumber = saleItems.Count + 1;
                    saleItems.Add(saleItem);
                    amount += productQuantity * saleItem.SaleProduct.ProductPrice;

                    var saleNumber = _sales.Count + 1;
                    var saleDate = DateTime.Now;
                    var sale = new Sale();

                    sale.SaleNumber = saleNumber;
                    sale.SaleAmount = amount;
                    sale.SaleDate = saleDate;

                    _sales.Add(sale);

                    Console.WriteLine("");
                    Console.WriteLine("-------------- Yeni Satış əlavə edildi --------------");
                    Console.WriteLine("");
                }
            }
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

        public double RemoveProductBySaleItem(int saleNumber, string productCode, int productQuantity)
        {
            double amount = 0;

            var prolist = _products.ToList();
            var salelist = _sales.ToList();

            var sale = salelist.Find(r => r.SaleNumber == saleNumber);

            bool findproduct = prolist.Exists(r => r.ProductCode == productCode);
            if(findproduct == true)
            {
                var list = prolist.Find(r => r.ProductCode == productCode);
                if (sale.SaleAmount > list.ProductPrice * productQuantity)
                {
                    sale.SaleAmount -= list.ProductPrice * productQuantity;
                } 
                else if((sale.SaleAmount == list.ProductPrice* productQuantity))
                {
                    _sales.Remove(sale);
                }
            }

            return amount;
        }

        public List<SaleItem> ShowSaleItem(int saleNumber)
        {
            return _sales.Find(s => s.SaleNumber == saleNumber).SaleItem.ToList();
        }
        #endregion
    }
}
