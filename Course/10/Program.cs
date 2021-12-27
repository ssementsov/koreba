using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Double.NaN / 2);
            Console.WriteLine(0f / 0f);
            Console.WriteLine(Double.PositiveInfinity / Double.PositiveInfinity);
            Console.WriteLine(Double.PositiveInfinity * 0);
            Console.WriteLine(Double.PositiveInfinity + Double.NegativeInfinity);
            Console.WriteLine(Math.Sqrt(-25));
            Console.WriteLine(Math.Log10(-25));

            Console.ReadKey();
        }
    }
}
