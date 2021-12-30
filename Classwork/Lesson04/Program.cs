using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04
{
    class Program
    {
        static void Main(string[] args)
        {
            //double x = double.NaN, y = double.NaN;
            //char x = 'A', y = 'B';

            //Console.WriteLine(x == y);
            //Console.WriteLine(x != y);
            //Console.WriteLine(x < y);
            //Console.WriteLine(x > y);
            //Console.WriteLine(x <= y);
            //Console.WriteLine(x >= y);


            //bool x = true, y = true, result = x & y;
            //Console.WriteLine($"1. {x, -5} & {y, -5} = {result, -5}");

            //x = y = false;
            //Console.WriteLine($"2. {x,-5} & {y,-5} = {x & y,-5}");

            //result = (x = true) & y;
            //Console.WriteLine($"3. {x,-5} & {y,-5} = {result,-5}");

            //(x, y) = (y, x);
            //Console.WriteLine($"4. {x,-5} & {y,-5} = {x & y,-5}");


            //Console.Write("Введите возраст клиента: ");
            //int clientAge = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Введите зарплату клиента: ");
            //int clientSalary = Convert.ToInt32(Console.ReadLine());

            //int minSalary = 1500, minAge = 21, maxAge = 55;

            //if ((clientAge > minAge && clientAge < maxAge) && clientSalary >= minSalary)
            //{
            //    Console.WriteLine("Кредитование доступно: True");
            //}
            //else
            //{
            //    Console.WriteLine("Кредитование недоступно: False");
            //}


            //Console.Write("Введите возраст клиента: ");
            //int clientAge = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Введите зарплату клиента: ");
            //int clientSalary = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Наличие поручителя (да/нет): ");
            //bool hasGuarantor = Console.ReadLine() == "да";

            //Console.Write("Наличие залогового обеспечения (да/нет): ");
            //bool hasCollateralSecurity = Console.ReadLine().Contains("да");

            //int minSalary = 1500, minAge = 21, maxAge = 55;

            //if ((clientAge > minAge && clientAge < maxAge) && (clientSalary >= minSalary | hasGuarantor | hasCollateralSecurity))
            //{
            //    Console.WriteLine("Кредитование доступно: True");
            //}
            //else
            //{
            //    Console.WriteLine("Кредитование недоступно: False");
            //}


            Console.Write("Фамилия запросившего субсидию: ");
            string name = Console.ReadLine();

            Console.Write($"{name} является пенсионером? : ");
            bool isPensioner = Console.ReadLine().Contains("да");

            Console.Write($"{name} состоит на учёте занятости? : ");
            bool isUnemployed = Console.ReadLine().Contains("да");

            Console.Write($"{name} имеет трудустройство? :");
            bool isEmployment = Console.ReadLine().Contains("да");

            bool subsidyAllowed = !isEmployment && (isPensioner | isUnemployed);

            Console.WriteLine($"Субсидия доступна: {subsidyAllowed}");

            Console.ReadKey();
        }
    }
}
