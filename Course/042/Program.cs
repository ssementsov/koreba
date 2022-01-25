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

            char[] symbols = sentence.ToCharArray();

            string word = null;

            for (int i = 1; i < symbols.Length; i++)
            {
                if ((symbols[i - 1] == SPACE && word is null) || (symbols[i] != SPACE && word != null))
                {
                    word += symbols[i];
                }
                else if (symbols[i] == SPACE && word != null)
                {
                    break;
                }
            }

            Console.WriteLine(word);
            Console.ReadKey();
        }
    }
}
