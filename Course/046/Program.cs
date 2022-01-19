using System;

namespace Task_046
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the string: ");
            string origin = Console.ReadLine();

            string resultedString = GetReversedStringWithUniqueSymbols(origin);
            Console.WriteLine(resultedString);

            Console.ReadKey();
        }

        private static string GetReversedStringWithUniqueSymbols(string origin)
        {
            string resultedString = origin[origin.Length - 1].ToString();

            char[] symbols = origin.ToCharArray();

            for (int i = symbols.Length - 2; i >= 0; i--)
            {
                if (IsNotContainChar(resultedString, symbols[i]))
                {
                    resultedString += symbols[i].ToString();
                }
            }

            return resultedString;
        }

        private static bool IsNotContainChar(string original, char symbol)
        {
            bool isNotContain = true;

            for (int i = 0; i < original.Length; i++)
            {
                if (original[i] == symbol)
                {
                    isNotContain = false;
                    break;
                }
            }

            return isNotContain;
        }
    }
}
