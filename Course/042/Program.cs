using System;

namespace Task_042
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const char SPACE = (char)32;

            Console.WriteLine("Enter the sentence: ");
            string sentence = Console.ReadLine();

            char[] separators = { SPACE };
            string[] words = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            PrintArray(words);
            Console.ReadKey();
        }

        private static void PrintArray<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
