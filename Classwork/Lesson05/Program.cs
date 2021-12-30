using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------------TASK-------------------------

            //uint minuteCost = 2;
            //float tax = 0.2f;

            //Console.Write($"{"Введите количество минут разговоров за январь", -46} : ");
            //uint firstMonthMinutes = Convert.ToUInt32((Console.ReadLine()));

            //Console.Write($"{"Введите количество минут разговоров за февраль", -46} : ");
            //uint secondMonthMinutes = Convert.ToUInt32((Console.ReadLine()));

            //Console.Write($"{"Введите количество минут разговоров за март", -46} : ");
            //uint thirdMonthMinutes = Convert.ToUInt32((Console.ReadLine()));


            //uint sum = checked(firstMonthMinutes + secondMonthMinutes + thirdMonthMinutes);
            ////checked
            ////{
            ////    sum = firstMonthMinutes + secondMonthMinutes + thirdMonthMinutes;
            ////}

            //uint totalMinutesCost = sum * minuteCost;
            //float totalTax = totalMinutesCost * tax;

            //Console.WriteLine($"{"Всего", -20} : {sum} минут");
            //Console.WriteLine($"{"Стоимость всех минут", -20} : {totalMinutesCost} рублей");
            //Console.WriteLine($"{"Заплатить налог", -20} : {totalTax} рублей");


            // --------------------checked/unchecked------------------

            //int a = int.MaxValue;
            //int b = unchecked(a + 1);
            //Console.WriteLine(b);



            //--------------- TASK 2 ----------

            //uint discount = 10;

            //Console.Write("Количество плитки: ");
            //uint tilesCount = Convert.ToUInt32(Console.ReadLine());

            //Console.Write($"{"Цена за 1 м.кв. плитки", -23} : ");
            //uint tilePrice = Convert.ToUInt32(Console.ReadLine());

            //uint totalTilesCost = tilesCount * tilePrice;
            //uint totalDiscount = totalTilesCost / discount;
            //uint payCost = totalTilesCost - totalDiscount;

            //Console.WriteLine($"{"Общая стоимость плитки", -23} : {totalTilesCost} руб.");
            //Console.WriteLine($"{"Скидка", -23} : {totalDiscount} руб.");
            //Console.WriteLine($"{"Сумма к оплате", -23} : {payCost} руб.");



            //----------------- Task № 16 ----------------

            //uint discount = 10;
            //uint discountLimit = 100;

            //Console.Write("Количество плитки: ");
            //uint tilesCount = Convert.ToUInt32(Console.ReadLine());

            //Console.Write($"{"Цена за 1 м.кв. плитки",-23} : ");
            //uint tilePrice = Convert.ToUInt32(Console.ReadLine());

            //uint totalTilesCost = tilesCount * tilePrice;
            //uint totalDiscount = 0;

            //if (tilesCount > discountLimit)
            //{
            //    totalDiscount = totalTilesCost / discount;
            //}

            //uint payCost = totalTilesCost - totalDiscount;

            //Console.WriteLine($"{"Общая стоимость плитки",-23} : {totalTilesCost} руб.");
            //Console.WriteLine($"{"Скидка",-23} : {totalDiscount} руб.");
            //Console.WriteLine($"{"Сумма к оплате",-23} : {payCost} руб.");



            // ------------------ TASK 17 ------------------------------

            //uint discount = 0;
            //const uint DISCOUNT_FOR_ALL = 10;
            //const uint PORE_AMOUNT_OF_TILES = 500;

            //Console.Write("Количество плитки: ");
            //uint tilesCount = Convert.ToUInt32(Console.ReadLine());

            //Console.Write($"{"Цена за 1 м.кв. плитки",-23} : ");
            //uint tilePrice = Convert.ToUInt32(Console.ReadLine());

            //uint totalTilesCost = tilesCount * tilePrice;         

            //if (tilesCount >= PORE_AMOUNT_OF_TILES)
            //{
            //    const uint DISCOUNT_FOR_PORE_ = 20;
            //    discount = totalTilesCost / DISCOUNT_FOR_PORE_;
            //}
            //else
            //{
            //    discount = totalTilesCost / DISCOUNT_FOR_ALL;
            //}

            //uint payCost = totalTilesCost - discount;

            //Console.WriteLine($"{"Общая стоимость плитки",-23} : {totalTilesCost} руб.");
            //Console.WriteLine($"{"Скидка",-23} : {discount} руб.");
            //Console.WriteLine($"{"Сумма к оплате",-23} : {payCost} руб.");





            //----------------- PALINDROME -----------

            Console.Write("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());

            List<int> figures = new List<int>();
            int cloneNumber = number;
            while (cloneNumber >= 1)
            {
                int x = cloneNumber % 10;
                figures.Add(x);
                cloneNumber /= 10;
            }

            int resultNumber = 0;
            int i = figures.Count() - 1;
            foreach (int figure in figures)
            {
                resultNumber += figure * (int)Math.Pow(10, i);
                i--;
            }

            if (number == resultNumber)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }



            Console.ReadKey();


        }
    }
}
