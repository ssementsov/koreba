using System;

namespace _039
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        private static void PrintResult(int a, int b, int c)
        {
            int sum = a + b + c;
            Console.WriteLine(sum);
        }

        private static void PrintResult(long a, long b, long c)
        {
            long difference = a - b - c;
            Console.WriteLine(difference);
        }

        private static void PrintResult(int a, int b)
        {
            int result = (int)Math.Pow(a,b);
            Console.WriteLine(result);
        }

        private static void PrintResult(byte a, byte b, byte c)
        {
            Console.WriteLine($"\"{a}\" + \"{b}\" + \"{c}\"");
        }
    }
}
