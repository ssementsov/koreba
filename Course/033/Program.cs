using System;

namespace _033
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 146, 110, 66, 139, 7, 86, 71, 97, 96, 160, 138, 67, 145, 133, 
                183, 185, 23, 124, 177, 150, 104, 48, 77, 147, 63, 113, 132, 100, 107, 106 };

            AscendingSort(numbers);
            PrintArray(numbers);

            DescendingSort(numbers);
            PrintArray(numbers);

            Console.ReadKey();
        }


        private static void AscendingSort(int[] array)
        {
            for (int i = array.Length; i >= 0; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    if (array[j - 1] > array[j])
                    {
                        Swap(array, j - 1, j);
                    }
                }
            }
        }

        private static void DescendingSort(int[] array)
        {
            for (int i = array.Length; i >= 0; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    if (array[j - 1] < array[j])
                    {
                        Swap(array, j - 1, j);
                    }
                }
            }
        }

        private static void Swap(int[] array ,int i, int j)
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
