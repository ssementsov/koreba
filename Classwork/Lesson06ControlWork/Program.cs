using System;

namespace Lesson06ControlWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------- TASK 19 ---------------

            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());

            //string quadrant = (x == 0 || y == 0) ? $"x = {x}; y = {y}" : y > 0 ? (x > 0 ? "First" : "Second") : (x > 0 ? "Fourth" : "Third");
            //Console.WriteLine(quadrant);
            //Console.ReadKey();

            //--------------------------------------


            //-------------- TASK 20 ---------------

            //uint a = uint.Parse(Console.ReadLine());
            //uint b = uint.Parse(Console.ReadLine());
            //uint c = uint.Parse(Console.ReadLine());

            //if (a >= b + c || b >= a + c || c >= a + b)
            //{
            //    Console.WriteLine("A triangle with this sides does not exist.");
            //}
            //else
            //{
            //    Console.WriteLine("A triangle with this sides exist.");
            //    if (a == b && a == c)
            //    {
            //        Console.WriteLine("This triangle is equilateral");
            //    }
            //    else if (a == b || a == c || b == c)
            //    {
            //        Console.WriteLine("This triangle is isosceles");
            //    }
            //    else if (a == Math.Sqrt(Math.Pow(b, 2) + Math.Pow(c, 2)) || b == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(c, 2))
            //        || c == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)))
            //    {
            //        Console.WriteLine("This triangle is rectangular");
            //    }
            //    else
            //    {
            //        Console.WriteLine("This is a simple triangle");
            //    }

            //}

            //Console.ReadKey();

            //-----------------------------------------------------


            //-------------------- TASK 21 ------------------------

            //const string SQUARE = "square";
            //const string PERIMETER = "perimeter";

            //uint a = uint.Parse(Console.ReadLine());
            //uint b = uint.Parse(Console.ReadLine());

            //Console.WriteLine($"Enter the operation type ({SQUARE}/{PERIMETER})");
            //string operation = Console.ReadLine();

            //if (operation.Contains(SQUARE))
            //{
            //    uint square = a * b;
            //    Console.WriteLine($"Square is {square}");
            //}
            //else if (operation.Contains(PERIMETER))
            //{
            //    uint perimeter = (a + b) * 2;
            //    Console.WriteLine($"Perimeter is {perimeter}");
            //}   
            //else
            //{
            //    Console.WriteLine("Invalid command!");
            //}

            //if (a == b)
            //{
            //    Console.WriteLine("This retangle is square");
            //}

            //Console.ReadKey();

            //---------------------------------------------------------


            //----------------------- TASK 22 -------------------------

            //string firstString = Console.ReadLine();
            //string secondString = Console.ReadLine();

            //double first = double.Parse(Replace_A_Point(firstString));
            //double second = double.Parse(Replace_A_Point(secondString));

            //string sign = Console.ReadLine();

            //switch (sign)
            //{
            //    case "+":
            //        {
            //            Console.WriteLine($"Operator {sign} is selected");
            //            double sum = first + second;
            //            Console.WriteLine($"Sum is {sum}");
            //            break;
            //        }
            //    case "-":
            //        {
            //            Console.WriteLine($"Operator {sign} is selected");
            //            double difference = first - second;
            //            Console.WriteLine($"Difference is {difference}");
            //            break;
            //        }
            //    case "*":
            //        {
            //            Console.WriteLine($"Operator {sign} is selected");
            //            double mult = first * second;
            //            Console.WriteLine($"Mult is {mult}");
            //            break;
            //        }
            //    case "/":
            //        {
            //            Console.WriteLine($"Operator {sign} is selected");
            //            double division = first / second;
            //            Console.WriteLine($"Division is {division}");
            //            break;
            //        }
            //    default:
            //        {
            //            Console.WriteLine("Invalid operation!");
            //            break;
            //        }
            //}

            //Console.ReadKey();

            //--------------------------------------------------------


            //---------------------- TASK 23 -------------------------

            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());

            //x = x % 2 == 0 ? x : ++x;
            //y = y % 2 == 0 ? y : ++y;

            //string result = (x + y) % 4 == 0 ? $"Сумма значений {x} и {y} делится на 4" : $"Сумма значений {x} и {y} не делится на 4";
            //Console.WriteLine(result);

            //Console.ReadKey();

            //-------------------------------------------------------


            //----------------------- TASK 24 -----------------------

            //Console.Write("s1 - ");
            //string s1 = Console.ReadLine();

            //Console.Write("s2 - ");
            //string s2 = Console.ReadLine();

            //if (s1.Length == s2.Length)
            //{
            //    char[] s1_symbols = s1.ToCharArray();
            //    char[] s2_symbols = s2.ToCharArray();
            //    string t = "";

            //    for (int i = 0; i < s1_symbols.Length; i++)
            //    {
            //        t += s1_symbols[i];
            //        t += s2_symbols[i];
            //    }

            //    Console.WriteLine($"t - {t}");

            //    Console.ReadKey();
            //}
            //else
            //{
            //    Console.WriteLine("Strings s1 and s2 have different lengths");
            //}

            //--------------------------------------------------------


            //----------------------- TASK 25 ------------------------
            //const string MINUS = "-";

            //Console.Write("s - ");
            //string s = Console.ReadLine();

            //char[] symbols = s.ToCharArray();

            //string t = "";
            //for (int i = 0; i < symbols.Length + 1; i++)
            //{
            //    if (i > 0 && i < symbols.Length)
            //    {
            //        t += symbols[i - 1].ToString() + symbols[i].ToString() + MINUS;
            //    }
            //    else if (i == symbols.Length)
            //    {
            //        t += symbols[i - 1].ToString();
            //    }
            //    else
            //    {
            //        t += symbols[i].ToString() + MINUS;
            //    }  
            //}

            //Console.WriteLine(t);

            //Console.ReadKey();

            //--------------------------------------------------------


            //---------------------- TASK 26 -------------------------
            //const string MULT = "*";

            //Console.Write("s - ");
            //string s = Console.ReadLine();

            //char[] symbols = s.ToCharArray();
            //string t = s;
            //for (int i = symbols.Length - 1; i > -1; i--)
            //{
            //    if (i > 0)
            //    {
            //        t += symbols[i].ToString() + MULT;
            //    }
            //    else
            //    {
            //        t += symbols[i].ToString();
            //    }
            //}

            //Console.WriteLine(t);

            //Console.ReadKey();

            //--------------------------------------------------------


            //----------------------- TASK 27 ------------------------

            const string SUM = "+";

            Console.Write("s - ");
            string s = Console.ReadLine();

            char[] symbols = s.ToCharArray();
            string t = "";

            for (int i = 0; i < symbols.Length; i++)
            {
                if (Char.IsNumber(symbols[i]))
                {
                    t += i < symbols.Length - 1 ? symbols[i].ToString() + SUM : symbols[i].ToString();
                }
            }
            Console.WriteLine(t);

            Console.ReadKey();

            //-------------------------------------------------------
        }

        private static string Replace_A_Point(string line)
        {
            char[] chars = line.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == '.')
                {
                    chars[i] = ',';
                }
            }
            string result = "";
            foreach (char symbol in chars)
            {
                result += symbol.ToString();
            }

            return result;
        }
    }
}
