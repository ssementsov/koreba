using System;

namespace Task_040
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string origin = "HELLO";
            ToLowerCase(ref origin);

            Console.WriteLine(origin);
            Console.ReadLine();
        }

        private static void ToLowerCase(ref string origin)
        {
            char[] symbols = origin.ToCharArray();

            for (int i = 0; i < symbols.Length; i++)
            {
                int num = symbols[i];

                if (num >= 65 && num <= 90)
                {
                    symbols[i] = (char)(num + 32);
                }
            }

            origin = CollectString(symbols);
        }

        private static string CollectString(char[] symbols)
        {
            string result = string.Empty;

            foreach (char symbol in symbols)
            {
                result += symbol.ToString();
            }

            return result;
        }
    }
}
