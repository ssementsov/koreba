using System;

namespace Task_053
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write($"{"Enter first number:",-23}");
            uint first = uint.Parse(Console.ReadLine());

            Console.Write($"{"Enter second number:",-23}");
            uint second = uint.Parse(Console.ReadLine());

            uint number = GreatestCommonDivisor(first, second);

            Console.WriteLine(number);
            Console.ReadKey();
        }

        private static uint GreatestCommonDivisor(uint m, uint n)
        {
            uint min = Math.Min(m, n);

            for (uint i = 2; i <= min; i++)
            {
                if (m % i == 0 && n % i == 0)
                {
                    return i * GreatestCommonDivisor(m / i, n / i);
                }
            }

            return 1;
        }

        //private static uint GreatestCommonDivisor(uint m, uint n)
        //{
        //    uint result = 1;
        //    uint min = Math.Min(m, n);

        //    for (uint i = min; i >= 2; i--)
        //    {
        //        if (m % i == 0 && n % i == 0)
        //        {
        //            result = n;
        //        }
        //    }

        //    return result;
        //}
    }
}
