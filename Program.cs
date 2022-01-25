using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal tileQuontiti, tilePrice;
            {
                Console.Write("Количество плитки: ");
                string stringQuontiti = Console.ReadLine();
                tileQuontiti =  Convert.ToDecimal(stringQuontiti);
                
                Console.Write("Цена за 1м. кв. плитки: ");
                string stringPrice = Console.ReadLine();
                tilePrice = Convert.ToDecimal(stringPrice);
            }

            decimal tileCost = tileQuontiti * tilePrice; // руб. 

            decimal discount; // руб. 
            {
                const decimal MIN_TILE_QUANTITY_FOR_DISCOUNT = 100; // м. кв.
                bool discountAvailable = tileQuontiti >= MIN_TILE_QUANTITY_FOR_DISCOUNT;
                
                if (discountAvailable)
                {
                    const decimal DISCOUNT_PERSENTAGE = 10; // %
                    discount = tileCost / 100 * DISCOUNT_PERSENTAGE;
                }
                else
                    discount = 0;
            }
            decimal paymentAmoount = tileCost - discount;




            Console.WriteLine($"Общая стоимость плитки: {tileCost} руб.");
            Console.WriteLine($"Скидка                : {discount} руб.");
            Console.WriteLine($"Сумма к оплате        : {paymentAmoount} руб.");

            Console.ReadLine();
        }
    }
}
