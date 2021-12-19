using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = Convert.ToInt32(Console.ReadLine());
            int sum = Convert.ToInt32(Console.ReadLine());
            int second = sum - first;

            Console.WriteLine(sum + "=" + first + "+" + second);
            Console.ReadKey();
        }
    }
}
