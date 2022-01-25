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
            uint quontiti, price;
            {
                Console.Write("Количество плитки: ");
                quontiti =  Convert.ToUInt32(Console.ReadLine());
                Console.Write("Цена зф 1м. кв. плитки: ");
                price = Convert.ToUInt32(Console.ReadLine());
            }

            decimal cost = quontiti * price; // руб. 

            decimal discount;
            {
                const decimal DISCOUNT_PERSENTAGE = 10; // %
                discount = cost / 100 * DISCOUNT_PERSENTAGE;
            }
            
             decimal paymentAmoount = cost - discount;

            Console.WriteLine($"Общая стоимость плитки: {cost} руб.");
            Console.WriteLine($"Скидка                : {discount} руб.");
            Console.WriteLine($"Сумма к оплате        : {paymentAmoount} руб.");

            Console.ReadLine();
        }
    }
}
