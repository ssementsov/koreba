using System;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 12, z = 3;

            x += y - x++ * z;
            Console.WriteLine(x);

            z = --x - y * 5;
            Console.WriteLine(z);

            y /= x + 5 % z;
            Console.WriteLine(y);

            z = x++ + y * 5;
            Console.WriteLine(z);

            x = y - x++ * z;
            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
