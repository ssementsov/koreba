using System;

namespace Task_048
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your text:");
            string text = Console.ReadLine();

            string[][] savedText = SaveText(text);
            PrintArray(savedText);

            Console.ReadKey();
        }

        private static string[][] SaveText(string text)
        {
            string[] sentences = text.Trim().Split('.');
            string[][] savedText = new string[sentences.Length][];

            for (int i = 0; i < savedText.Length; i++)
            {
                savedText[i] = sentences[i].Split(' ');
            }

            return savedText;
        }

        private static void PrintArray<T>(T[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write($"{array[i][j]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
