using System;
using System.Text.RegularExpressions;

namespace Task_041
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string original = "aaabaaddae";
            string substring = "aed";

            string minSubstring = MinSubstring(original, substring);
            Console.WriteLine(minSubstring);

            Console.ReadKey();
        }

        private static string MinSubstring(string origin, string template)
        {
            ConstraintCheck(origin, template);

            char[] symbols = template.ToCharArray();

            string minSubstring_1 = origin;
            TrimRight(ref minSubstring_1, symbols);
            TrimLeft(ref minSubstring_1, symbols);

            string midSubstring_2 = origin;
            TrimLeft(ref midSubstring_2, symbols);
            TrimRight(ref midSubstring_2, symbols);

            return minSubstring_1.Length < midSubstring_2.Length ? minSubstring_1 : midSubstring_2;
        }

        private static void ConstraintCheck(string origin, string template)
        {
            CheckLimits(origin, template);
            CheckEnglishAndLow(origin);
            CheckEnglishAndLow(template);
        }

        private static void CheckLimits(string original, string substring)
        {
            if (original.Length >= 1 && original.Length <= 50 && substring.Length >= 1 && substring.Length <= 50)
            {
                char[] symbols = substring.ToCharArray();
                foreach (char symbol in symbols)
                {
                    if (original.IndexOf(symbol) < 0)
                    {
                        throw new ArgumentException("All substring characters must be somwhere in string origin");
                    }
                }
            }
        }

        private static void CheckEnglishAndLow(string line)
        {
            Regex regex = new Regex("^[a-z]+$");

            if (regex.IsMatch(line) == false)
            {
                throw new ArgumentException("Both strings must contain only lowercase English letters ");
            }
        }

        private static void TrimRight(ref string minSubstring, char[] symbols)
        {
            TrimSide(ref minSubstring, symbols, true);
        }

        private static void TrimLeft(ref string minSubstring, char[] symbols)
        {
            TrimSide(ref minSubstring, symbols, false);
        }

        private static void TrimSide(ref string minSubstring, char[] symbols, bool isRight)
        {
            int side = isRight ? 0 : 1;
            string tempString = minSubstring;

            while (IsContainSubstring(tempString, symbols) && tempString.Length >= symbols.Length)
            {
                minSubstring = tempString;
                tempString = tempString.Substring(side, tempString.Length - 1);
            }
        }

        private static bool IsContainSubstring(string original, char[] substring)
        {
            bool isContain = true;

            foreach (char symbol in substring)
            {
                int index = original.IndexOf(symbol);
                if (index >= 0)
                {
                    original = original.Remove(index, 1);
                }
                else
                {
                    isContain = false;
                    break;
                }
            }

            return isContain;
        }
    }
}
