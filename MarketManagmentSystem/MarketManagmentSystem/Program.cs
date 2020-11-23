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
                Console.Write("Seçiminizi edin : ");
                string select = Console.ReadLine();

                while (!int.TryParse(select, out selectInt))
                {
                    Console.WriteLine("Rəqəm daxil etməlisiniz!");
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
        static void ShowProductMenu()
        {
            int selectInt1;
            do
            {
                #region Second Menu
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
                Console.Write("Seçiminizi edin : ");
                string select = Console.ReadLine();

                while (!int.TryParse(select, out selectInt1))
                {
                    Console.WriteLine("Rəqəm daxil etməlisiniz!");
                    select = Console.ReadLine();
                }

                #endregion

                #region Second Menu Switch
                switch (selectInt1)
                {
                    case 1:
                        ShowAddProduct();
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
                    default:
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Siz yalnış seçim etdiniz,1-7 aralığında seçim etməlisiniz");
                        Console.WriteLine("--------------------------------");
                        break;
                }

                #endregion

            } while (selectInt1 != 0);
        }

        static void ShowSalesMenu()
        {
            int selectInt2;
            do
            {
                #region Third Menu
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

                while (!int.TryParse(select, out selectInt2))
                {
                    Console.WriteLine("Rəqəm daxil etməlisiniz!");
                    select = Console.ReadLine();
                }
                #endregion

                #region Third Menu Switch
                switch (selectInt2)
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

            } while (selectInt2 != 0) ;
        }

        static void ShowAddProduct()
        {
            Console.WriteLine("-------------- Yeni Məhsul əlavə et --------------");
            Product product = new Product();

            Console.WriteLine("Kateqoriya daxil edin :");
            product.ProductName = Console.ReadLine();

        }
    }
}
