using System;

namespace _034
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 108, 91, 122, 114, 62, 182, 110, 73, 167, 67, 24, 74, 116, 
                120, 42, 171, 52, 46, 23, 31, 146, 169, 161, 178, 90, 44, 142, 133, 184, 115 };

            Reverse(numbers);
            PrintArray(numbers);

            Console.ReadKey();
        }

        private static void Reverse(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                Swap(array, i, array.Length - 1 - i);
            }
        }

        private static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        private static void PrintArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write($"{number}; ");
            }
            Console.Write("\n");
        }
    }
}
