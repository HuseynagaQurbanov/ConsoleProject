using ConsoleTables;
using MarketManagmentSystem.infrastructure.Enums;
using MarketManagmentSystem.infrastructure.Models;
using MarketManagmentSystem.infrastructure.Services;
using System;
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
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Siz yalnış seçim etdiniz,0-2 aralığında seçim etməlisiniz");
                        Console.WriteLine("--------------------------------");
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
                        continue;
                    case 3:
                        continue;
                    case 4:
                        ShowProductList();
                        break;
                    case 5:
                        continue;
                    case 6:
                        continue;
                    case 7:
                        continue;
                    default:
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
                        continue;
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
                Console.WriteLine("2. Ayaqqabilar");
                Console.WriteLine("3. Soyuducular");
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
                        product.ProductCategory = ProductCategoryType.Televizorlar;
                        break;
                    case 2:
                        product.ProductCategory = ProductCategoryType.Soyuducular;
                        break;
                    case 3:
                        product.ProductCategory = ProductCategoryType.Ayaqqabilar;
                        break;
                    default:
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Siz yalnış seçim etdiniz,1-3 aralığında seçim etməlisiniz");
                        Console.WriteLine("--------------------------------");
                        break;
                }
                #endregion

            } while (selectInt != 0);

            #endregion

            #region Product Name

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



        #endregion
    }
}
