using System;

namespace _031
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter array length: ");
            int number = int.Parse(Console.ReadLine());
            int[] array = new int[number];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Enter {i}-th element: ");
                int value = int.Parse(Console.ReadLine());
                array[i] = value;
            }

            Array.Sort(array);
            Array.Reverse(array);

            int[] changedArray = new int[array.Length + 1];
            array.CopyTo(changedArray, 0);

            Console.Write("Enter the last element of the new array: ");
            int lastElement = int.Parse(Console.ReadLine());
            changedArray[changedArray.Length - 1] = lastElement;

            foreach (int elem in changedArray)
            {
                Console.Write($"{elem}; ");
            }

            Console.ReadKey();
        }
    }
}
