using System;

namespace _013
{
    class Program
    {
        static void Main(string[] args)
        {
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
