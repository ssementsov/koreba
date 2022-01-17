using System;

namespace _011
{
    class Program
    {
        static void Main(string[] args)
        {
            string myVariable = "myvariable";
            uint length = (uint)myVariable.Length;

            uint count = 0;
            for (uint i = 0; i <= length; i++)
            {
                count += CombinationWithoutRepetitions(length, i);
            }

            Console.WriteLine(count);
            Console.ReadKey();
        }

        private static uint CombinationWithoutRepetitions(uint n, uint m)
        {
            return Factorial(n) / (Factorial(m) * Factorial(n - m));
        }

        private static uint Factorial(uint number)
        {
            uint result = 1;
            for (uint i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
