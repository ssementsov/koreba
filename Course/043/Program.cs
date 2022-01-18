using System;

namespace Task_043
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char[] symbols = { '1', '2', 'a', 'b', 'c', ',', '.' };

            Console.WriteLine("Enter the string: ");
            string origin = Console.ReadLine();

            RemoveSymbols(ref origin, symbols);
            ReverseString(ref origin);

            Console.WriteLine(origin);
            Console.ReadKey();
        }

        private static void RemoveSymbols(ref string origin, char[] symbols)
        {
            foreach (char symbol in symbols)
            {
                while (origin.IndexOf(symbol) >= 0)
                {
                    origin = origin.Remove(origin.IndexOf(symbol), 1);
                }
            }
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

        private static void Swap<T>(T[] array, int i, int j)
        {
            T temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
