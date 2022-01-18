using System;
using System.Text.RegularExpressions;

namespace Task_041
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string origin = "eaaabaaddae";
            string substring = "aed";

            string minSubstring = MinSubstring(origin, substring);
            Console.WriteLine(minSubstring);

            Console.ReadKey();
        }

        private static string MinSubstring(string origin, string template)
        {
            ConstraintCheck(origin, template);

            string minSubstring = origin;
            char[] symbols = template.ToCharArray();

            TrimRight(ref minSubstring, symbols);
            TrimLeft(ref minSubstring, symbols);

            return minSubstring;
        }

        private static void ConstraintCheck(string origin, string template)
        {
            CheckLimits(origin, template);
            CheckEnglishAndLow(origin);
            CheckEnglishAndLow(template);
        }

        private static void CheckLimits(string origin, string template)
        {
            if (origin.Length >= 1 && origin.Length <= 50 && template.Length >= 1 && template.Length <= 50)
            {
                char[] symbols = template.ToCharArray();
                foreach (char symbol in symbols)
                {
                    if (origin.IndexOf(symbol) < 0)
                    {
                        throw new ArgumentException("All substring characters must be somwhere in string origin");
                    }
                }
            }
        }

        private static void CheckEnglishAndLow(string template)
        {
            Regex regex = new Regex("^[a-z]+$");

            if (regex.IsMatch(template) == false)
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

        private static bool IsContainSubstring(string origin, char[] substring)
        {
            bool isContain = true;

            foreach (char symbol in substring)
            {
                int index = origin.IndexOf(symbol);
                if (index >= 0)
                {
                    origin.Remove(index, 1);
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
