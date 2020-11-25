using ConsoleTables;
using MarketManagmentSystem.infrastructure.Enums;
using MarketManagmentSystem.infrastructure.Models;
using MarketManagmentSystem.infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketManagmentSystem
{
    class Program
    {
        private static readonly MarketableService _marketableService = new MarketableService();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int selectInt;
            do
            {
                #region First Menu 
                Console.WriteLine("========== Market İdarə Sistemi ==========");
                Console.WriteLine("1. Məhsullar üzərində əməliyyat aparmaq");
                Console.WriteLine("2. Satışlar üzərində əməliyyat aparmaq");
                Console.WriteLine("0. Sistemdən çıxmaq");
                #endregion

                #region First Menu Selection
                Console.WriteLine("");
                Console.Write("Seçiminizi edin : ");
                string select = Console.ReadLine();

                while (!int.TryParse(select, out selectInt))
                {
                    Console.WriteLine("");
                    Console.Write("Rəqəm daxil etməlisiniz!: ");
                    select = Console.ReadLine();
                }
                #endregion

                #region First Menu Switch
                switch (selectInt)
                {
                    case 0:
                        continue;
                    case 1:
                        ShowProductMenu();
                        break;
                    case 2:
                        ShowSalesMenu();
                        break;
                    default:
                        Console.WriteLine("");
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Siz yalnış seçim etdiniz,0-3 aralığında seçim etməlisiniz");
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("");
                        break;
                }
                #endregion

            } while (selectInt != 0);

        }

        #region Show Methods
        static void ShowProductMenu()
        {
            int selectInt;
            do
            {
                #region Second Menu
                Console.WriteLine("");
                Console.WriteLine("================================================");
                Console.WriteLine("1. Yeni məhsul əlavə etmək");
                Console.WriteLine("2. Məhsul üzərində düzəliş etmək");
                Console.WriteLine("3. Məhsulu silmək");
                Console.WriteLine("4. Bütün məhsulları göstərmək");
                Console.WriteLine("5. Kategoriyasına görə məhsulları göstərmək");
                Console.WriteLine("6. Qiymət aralığına görə məhsulları göstərmək");
                Console.WriteLine("7. Məhsullar arasında ada görə axtarış etmək");
                #endregion

                #region Second Menu Selection
                Console.WriteLine("");
                Console.Write("Seçiminizi edin : ");
                string select = Console.ReadLine();

                while (!int.TryParse(select, out selectInt))
                {
                    Console.Write("Rəqəm daxil etməlisiniz!: ");
                    select = Console.ReadLine();
                }

                #endregion

                #region Second Menu Switch
                switch (selectInt)
                {
                    case 1:
                        ShowAddProduct();
                        break;
                    case 2:
                        ShowEditProduct();
                        break;
                    case 3:
                        ShowRemoveProduct();
                        break;
                    case 4:
                        ShowProductList();
                        break;
                    case 5:
                        ShowGetProductsByCategoryName();
                        break;
                    case 6:
                        ShowGetProductsByAmountRange();
                        break;
                    case 7:
                        ShowGetProductsByProductName();
                        break;
                    default:
                        Console.WriteLine("");
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Siz yalnış seçim etdiniz,1-7 aralığında seçim etməlisiniz");
                        Console.WriteLine("--------------------------------");
                        break;
                }

                #endregion

            } while (selectInt != 0);
        }

        static void ShowSalesMenu()
        {
            int selectInt;
            do
            {
                #region Third Menu
                Console.WriteLine("");
                Console.WriteLine("================================================");
                Console.WriteLine("1. Yeni satış əlavə etmək");
                Console.WriteLine("2. Satışdakı məhsulu geri qaytarmaq");
                Console.WriteLine("3. Satışı silmək");
                Console.WriteLine("4. Bütün satışları görmək");
                Console.WriteLine("5. Tarix aralığına görə satışları görmək");
                Console.WriteLine("6. Məbləğ aralığına görə satışları görmək");
                Console.WriteLine("7. Tarixə görə satışları görmək");
                Console.WriteLine("8. Nömrəyə görə satışları görmək");
                #endregion

                #region Third Menu Selection
                Console.Write("Seçiminizi edin : ");
                string select = Console.ReadLine();

                while (!int.TryParse(select, out selectInt))
                {
                    Console.WriteLine("Rəqəm daxil etməlisiniz!");
                    select = Console.ReadLine();
                }
                #endregion

                #region Third Menu Switch
                switch (selectInt)
                {
                    case 1:
                        ShowAddSale();
                        break;
                    case 2:
                        continue;
                    case 3:
                        continue;
                    case 4:
                        continue;
                    case 5:
                        continue;
                    case 6:
                        continue;
                    case 7:
                        continue;
                    case 8:
                        continue;
                    default:
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Siz yalnış seçim etdiniz,1-7 aralığında seçim etməlisiniz");
                        Console.WriteLine("--------------------------------");
                        break;
                }
                #endregion

            } while (selectInt != 0) ;
        }
        #endregion

        #region Product Show Methods
        static void ShowAddProduct()
        {
            Console.WriteLine("");
            Console.WriteLine("-------------- Yeni Məhsul əlavə et --------------");
            Product product = new Product();

            #region Product Catagory Name

            int selectInt;
            do
            {
                #region Product Category Menu 
                Console.WriteLine("Kateqoriya daxil edin:");
                Console.WriteLine("1. Televizorlar");
                Console.WriteLine("2. Telefonlar");
                Console.WriteLine("3. Soyuducular");
                Console.WriteLine("4. Kompyuterlər");
                #endregion

                #region Product Category Selection
                Console.WriteLine("");
                Console.Write("Seçiminizi edin : ");
                string select = Console.ReadLine();

                while (!int.TryParse(select, out selectInt))
                {
                    Console.WriteLine("");
                    Console.Write("Rəqəm daxil etməlisiniz!: ");
                    select = Console.ReadLine();
                }
                #endregion

                #region Product Category Switch
                switch (selectInt)
                {
                    case 1:
                        product.ProductCategory = ProductCategoryType.TV;
                        break;
                    case 2:
                        product.ProductCategory = ProductCategoryType.Phone;
                        break;
                    case 3:
                        product.ProductCategory = ProductCategoryType.Refrigerator;
                        break;
                    case 4:
                        product.ProductCategory = ProductCategoryType.Computer;
                        break;
                    default:
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Siz yalnış seçim etdiniz,1-4 aralığında seçim etməlisiniz");
                        ShowAddProduct();
                        Console.WriteLine("--------------------------------");
                        break;
                }
                #endregion

            } while (selectInt == 0);

            #endregion

            #region Product Name

            Console.WriteLine("");
            Console.Write("Məhsul adı daxil edin :");
            product.ProductName = Console.ReadLine();
            Console.WriteLine("");

            #endregion

            #region Product Price

            Console.Write("Məhsulun qiymətini daxil edin :");
            string productPriceInput = Console.ReadLine();
            double productPrice;

            while (!double.TryParse(productPriceInput, out productPrice))
            {
                Console.WriteLine("");
                Console.WriteLine("Rəqəm daxil etməlisiniz!");
                productPriceInput = Console.ReadLine();
            }

            product.ProductPrice = productPrice;
            Console.WriteLine("");

            #endregion

            #region Product Quantity

            Console.Write("Məhsulun sayını daxil edin :");
            string productQuantityInput = Console.ReadLine();
            int productQuantity;

            while (!int.TryParse(productQuantityInput, out productQuantity))
            {
                Console.WriteLine("Rəqəm daxil etməlisiniz!");
                productQuantityInput = Console.ReadLine();
            }

            product.ProductQuantity = productQuantity;
            Console.WriteLine("");

            #endregion

            #region Product Code
            Console.Write("Məhsulun kodunu daxil edin :");
            product.ProductCode = Console.ReadLine();
            #endregion

            if(product != null)
            {
                _marketableService.AddProduct(product);
            }

            Console.WriteLine("");
            Console.WriteLine("-------------- Yeni satış əlavə edildi --------------");
        }

        static void ShowProductList()
        {
            Console.WriteLine("");
            Console.WriteLine("-------------- Mövcud Məhsullar --------------");

            var table = new ConsoleTable("No", "Kateqoriya", "Məhsul", "Sayı", "Qiyməti"  , "Mehsul Kodu");
            int i = 1;
            foreach (var item in _marketableService.Products)
            {
                table.AddRow(i, item.ProductCategory, item.ProductName, item.ProductQuantity, item.ProductPrice, item.ProductCode);
                i++;
            }

            table.Write();
        }

        static void ShowEditProduct()
        {
            Product product = new Product();
     
            Console.WriteLine("");
            Console.WriteLine("-------------- Məhsul üzərində düzəliş etmək --------------");
            Console.Write("Məhsulun kodunu daxil edin: ");
            string code = Console.ReadLine();

            List<Product> productCode = _marketableService.EditProduct(code);

            #region Product Name Change
            Console.WriteLine("");
            Console.Write("Məhsulun yeni adını daxil edin: ");
            string productName = Console.ReadLine();
            #endregion

            #region Product Quantity Change
            Console.WriteLine("");
            Console.Write("Məhsulun yeni sayını daxil edin: ");
            int productQuantity = Convert.ToInt32(Console.ReadLine());            //Exception vermeliyem
            #endregion

            #region Product Price Change
            Console.WriteLine("");
            Console.Write("Məhsulun yeni məbləğini daxil edin: ");
            double productPrice = Convert.ToDouble(Console.ReadLine());           //Exception vermeliyem
            #endregion

            #region Category Change Menu
            Console.WriteLine("");
            int selectInt;
            do
            {
                #region Product Category Menu 
                Console.WriteLine("Məhsulun yeni kateqoriyasını daxil edin: ");
                Console.WriteLine("0. Televizorlar");
                Console.WriteLine("1. Telefonlar");
                Console.WriteLine("2. Soyuducular");
                Console.WriteLine("3. Kompyuterlər");
                #endregion

                #region Product Category Selection
                Console.WriteLine("");
                Console.Write("Seçiminizi edin : ");
                string select = Console.ReadLine();

                while (!int.TryParse(select, out selectInt))
                {
                    Console.WriteLine("");
                    Console.Write("Rəqəm daxil etməlisiniz!: ");
                    select = Console.ReadLine();
                }
                #endregion

                #region Product Category Switch
                switch (selectInt)
                {
                    case 0:
                        product.ProductCategory = ProductCategoryType.TV;
                        break;
                    case 1:
                        product.ProductCategory = ProductCategoryType.Phone;
                        break;
                    case 2:
                        product.ProductCategory = ProductCategoryType.Refrigerator;
                        break;
                    case 3:
                        product.ProductCategory = ProductCategoryType.Computer;
                        break;
                    default:
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Siz yalnış seçim etdiniz,1-4 aralığında seçim etməlisiniz");
                        Console.WriteLine("--------------------------------");
                        break;
                }
                #endregion

            } while (selectInt ==-1);

            #endregion


            foreach (var item in productCode)
            {
                item.ProductName = productName;
                item.ProductQuantity = productQuantity;
                item.ProductPrice = productPrice;
                item.ProductCategory = (ProductCategoryType)selectInt;
                    
            }
        }

        static void ShowRemoveProduct()
        {
            Console.WriteLine("");
            Console.WriteLine("-------------- Məhsulu silmək --------------");

            Console.WriteLine("");
            Console.Write("Silmək istədiyiniz məhsulun kodunu daxil edin: ");                         //Exception vermeliyem

            string code = Console.ReadLine();
            _marketableService.RemoveProduct(code);
        }

        static void ShowGetProductsByCategoryName()
        {
            Console.WriteLine("");
            Console.WriteLine("-------------- Kateqoriyasına görə məhsulu göstərmək --------------");

            Product product = new Product();

            int selectInt;
            do
            {
                #region Product Category Menu 
                Console.WriteLine("Məhsulun kateqoriyasını daxil edin ");
                Console.WriteLine("0. Televizorlar");
                Console.WriteLine("1. Telefonlar");
                Console.WriteLine("2. Soyuducular");
                Console.WriteLine("3. Kompyuterlər");
                #endregion

                #region Product Category Selection
                Console.WriteLine("");
                Console.Write("Seçiminizi edin : ");
                string select = Console.ReadLine();
                Console.WriteLine("");

                while (!int.TryParse(select, out selectInt))
                {
                    Console.WriteLine("");
                    Console.Write("Rəqəm daxil etməlisiniz!: ");
                    select = Console.ReadLine();
                }
                #endregion

                #region Product Category Switch
                switch (selectInt)
                {
                    case 0:
                        product.ProductCategory = ProductCategoryType.TV;
                        break;
                    case 1:
                        product.ProductCategory = ProductCategoryType.Phone;
                        break;
                    case 2:
                        product.ProductCategory = ProductCategoryType.Refrigerator;
                        break;
                    case 3:
                        product.ProductCategory = ProductCategoryType.Computer;
                        break;
                    default:
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Siz yalnış seçim etdiniz,0-3 aralığında seçim etməlisiniz");
                        Console.WriteLine("--------------------------------");
                        break;
                }
                #endregion

            } while (selectInt == -1);

            

            _marketableService.GetProductsByCategoryName((ProductCategoryType)selectInt);

        }

        static void ShowGetProductsByAmountRange()
        {
            Console.WriteLine("-------------- Qiymət aralığında satışların Gostərilməsi --------------");

            #region Start Amount
            Console.Write("Başlanğıc Qiyməti daxil edin:");
            string startAmountInput = Console.ReadLine();
            double startAmount;

            while (!double.TryParse(startAmountInput, out startAmount))
            {
                Console.WriteLine("Rəqəm daxil etməlisiniz!");
                startAmountInput = Console.ReadLine();
            }
            #endregion

            #region End Amount
            Console.Write("Bitiş qiyməti daxil edin:");
            string endAmountInput = Console.ReadLine();
            double endAmount;

            while (!double.TryParse(endAmountInput, out endAmount))
            {
                Console.WriteLine("Rəqəm daxil etməlisiniz!");
                endAmountInput = Console.ReadLine();
            }
            #endregion

            List<Product> result = _marketableService.GetProductsByAmountRange(startAmount, endAmount);

            foreach (var item in result)
            {
                if(result != null)
                {
                    Console.WriteLine("");
                    Console.WriteLine(item.ProductCategory + " " + item.ProductName + " " + item.ProductQuantity + " " + item.ProductPrice + " " + item.ProductCode);         //exception
                }
            }
        }

        static void ShowGetProductsByProductName()
        {
            Console.WriteLine("-------------- Adına görə məhsulun göstərilməsi --------------");

            Console.WriteLine("");
            Console.Write("Məhsulun adını daxil edin: ");
            string productName = Console.ReadLine();

            List<Product> products = _marketableService.GetProductsByProductName(productName);
            foreach (var item in products)
            {
                if (products != null)
                {
                    Console.WriteLine("");
                    Console.WriteLine(item.ProductCategory + " " + item.ProductName + " " + item.ProductQuantity + " " + item.ProductPrice + " " + item.ProductCode);         //exception
                }
            }
        }
        #endregion

        #region Sale Methods
        static void ShowAddSale()
        {
            Sale sale = new Sale();

            #region Sale Number
            Console.WriteLine("");
            Console.Write("Məhsulun nömrəsini daxil edin :");
            string saleNumberInput = Console.ReadLine();
            int saleNumber;

            while (!int.TryParse(saleNumberInput, out saleNumber))
            {
                Console.WriteLine("");
                Console.WriteLine("Rəqəm daxil etməlisiniz!");
                saleNumberInput = Console.ReadLine();
            }

            sale.SaleNumber = saleNumber;
            #endregion

            #region Sale Amount
            Console.WriteLine("");
            Console.Write("Məhsulun qiymətini daxil edin :");
            string saleAmountInput = Console.ReadLine();
            int saleAmount;

            while (!int.TryParse(saleAmountInput, out saleAmount))
            {
                Console.WriteLine("");
                Console.WriteLine("Rəqəm daxil etməlisiniz!");
                saleAmountInput = Console.ReadLine();
            }

            sale.SaleAmount = saleAmount;
            #endregion

            #region Sale Date
            Console.WriteLine("");
            Console.Write("Tarixi daxil edin (gun.ay.il):");
            string saleDateInput = Console.ReadLine();
            DateTime saleDate;

            while (!DateTime.TryParse(saleDateInput, out saleDate))
            {
                Console.WriteLine("");
                Console.WriteLine("Tarixi daxil etməlisiniz!");
                saleDateInput = Console.ReadLine();
            }

            sale.SaleDate = saleDate;
            #endregion

            #region Sale Item

            List<SaleItem> saleItems = new List<SaleItem>();


            #endregion
        }
        #endregion
    }
}
