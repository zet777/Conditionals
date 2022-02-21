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
                decimal discountPersentage;
                {
                    const decimal MIN_TILE_QTY_FOR_DISCOUNT_20_PCT = 500; // м. кв.
                    bool discount20PctAvailable = tileQuontiti >= MIN_TILE_QTY_FOR_DISCOUNT_20_PCT;


                    if (discount20PctAvailable)
                    {
                        discountPersentage = 20; // %
                    }
                    else
                    {
                        discountPersentage = 10; // %

                    }
                }

                discount = tileCost / 100 * discountPersentage;
            }
            
            decimal paymentAmoount = tileCost - discount;




            Console.WriteLine($"Общая стоимость плитки: {tileCost} руб.");
            Console.WriteLine($"Скидка                : {discount} руб.");
            Console.WriteLine($"Сумма к оплате        : {paymentAmoount} руб.");

            Console.ReadLine();
            
        }
    }
}
