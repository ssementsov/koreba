using System;

namespace Task_045
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the string: ");
            string origin = Console.ReadLine();

            string resultString = DuplicateGroupSymbols(origin);
            Console.WriteLine(resultString);

            Console.ReadKey();
        }

        private static string DuplicateGroupSymbols(string origin)
        {
            string resultedString = string.Empty;

            char[] symbols = origin.ToCharArray();
            int groupLength;

            for (int i = 0; i < symbols.Length; i += groupLength)
            {
                groupLength = GetGroupLength(symbols, i);

                if (groupLength > 1)
                {
                    string group = origin.Substring(i, groupLength);
                    resultedString += group + group;
                }
            }

            return resultedString;
        }

        private static int GetGroupLength(char[] symbols, int startIndex)
        {
            int lastIndex = startIndex;

            while (lastIndex < symbols.Length && symbols[startIndex] == symbols[lastIndex])
            {
                lastIndex++;
            }

            return lastIndex - startIndex;
        }
    }
}
