using System;

namespace Task_044
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string origin = Console.ReadLine();

            ShiftString(ref origin, 3);
            ReverseString(ref origin);

            Console.WriteLine(origin);
            Console.ReadKey();
        }

        private static void ShiftString(ref string origin, int shiftCount)
        {
            char[] symbols = origin.ToCharArray();

            while (shiftCount > symbols.Length)
            {
                shiftCount -= symbols.Length;
            }

            for (int i = 0; i < shiftCount; i++)
            {
                for (int j = i + 1; j < symbols.Length + i; j++)
                {
                    if (j < symbols.Length)
                    {
                        Swap(symbols, i, j);
                    }
                    else
                    {
                        Swap(symbols, i, j - symbols.Length);
                    }
                }
            }

            origin = string.Empty;
            foreach (char symbol in symbols)
            {
                origin += symbol;
            }
        }

        private static void Swap<T>(T[] array, int i, int j)
        {
            T temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        private static void ReverseString(ref string origin)
        {
            char[] symbols = origin.ToCharArray();

            for (int i = 0; i < symbols.Length / 2; i++)
            {
                Swap(symbols, i, symbols.Length - i - 1);
            }

            origin = string.Empty;
            foreach (char symbol in symbols)
            {
                origin += symbol;
            }
        }
    }
}
