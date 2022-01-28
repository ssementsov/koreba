using System;

namespace Lesson013
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var instance = new ArrayClass();

            for (int i = 0; i < instance.GetFirstDimension(); i++)
            {
                for (int j = 0; j < instance.GetSecondDimension(i); j++)
                {
                    Console.Write($"{instance[i, j]} ");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
