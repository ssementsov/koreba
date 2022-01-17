using System;

namespace _032
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.Write($"{i}; ");
            }
            Console.WriteLine("\n");


            for (int i = 1001; i < 2500; i+=3)
            {
                Console.Write($"{i}; ");
            }
            Console.WriteLine("\n");


            for (int i = 100; i >= 0; i--)
            {
                Console.Write($"{i}; ");
            }
            Console.WriteLine("\n");


            for (float i = 1f; i < 5f; i+= 0.2f)
            {
                Console.Write($"{i}; ");
            }

            Console.ReadKey();
        }
    }
}
