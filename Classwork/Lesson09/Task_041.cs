using System;
using System.Text.RegularExpressions;

namespace Lesson09
{
    public class Task_041
    {
        public string MinSubstring(string origin, string template)
        {
            ConstraintCheck(origin, template);

            char[] symbols = template.ToCharArray();

            string minSubstring = origin;
            string tempString = minSubstring;

            while (IsContainSubstring(tempString, symbols) && tempString.Length >= template.Length)
            {
                minSubstring = tempString;
                tempString = tempString.Substring(0, tempString.Length - 1);
            }

            while (IsContainSubstring(tempString, symbols) && tempString.Length >= template.Length)
            {
                minSubstring = tempString;
                tempString.Substring(1, tempString.Length - 1);
            }

            return minSubstring;
        }


        private void ConstraintCheck(string origin, string template)
        {
            CheckLimits(origin, template);
            CheckEnglishAndLow(origin);
            CheckEnglishAndLow(template);
        }

        private void CheckLimits(string origin, string template)
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

        private void CheckEnglishAndLow(string template)
        {
            Regex regex = new Regex("^[a-z]+$");

            if (regex.IsMatch(template) == false)
            {
                throw new ArgumentException("Both strings must contain only lowercase English letters ");
            }
        }

        private void 


        private bool IsContainSubstring(string origin, char[] substring)
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
