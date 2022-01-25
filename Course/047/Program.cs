using System;

namespace Task_047
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the string: ");
            string original = Console.ReadLine();

            IncreasingSort(ref original);
            ShiftString(ref original, 2);

            Console.WriteLine(original);
            Console.ReadKey();
        }

        private static void IncreasingSort(ref string original)
        {
            char[] symbols = original.ToCharArray();
            IncreasingSort(ref symbols);

            CollectString(ref original, symbols);
        }

        private static void IncreasingSort(ref char[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (array[j] < array[j - 1])
                    {
                        Swap(array, j - 1, j);
                    }
                }
            }
        }

        private static void Swap<T>(T[] array, int i, int j)
        {
            T temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        private static void CollectString(ref string origin, char[] symbols)
        {
            origin = string.Empty;
            foreach (char symbol in symbols)
            {
                origin += symbol;
            }
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

            CollectString(ref origin, symbols);
        }
    }
}
