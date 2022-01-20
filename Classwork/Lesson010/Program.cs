using System;

namespace Lesson010
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte[,] array0 = { { 1, 2, 3}, { 4, 5, 6} };

            //byte[,] array1 = { { 1, 2, 3, 4, 5}, { 6, 7, 8, 9, 0} };

            //byte[,] array2 = { { 1, 2}, { 3, 4} };

            //byte[][,] array = new byte[3][,] {array0, array1, array2};

            //for (int i = 0; i < array.Length; i++)
            //{
            //    for (int j = 0; j < array[i].GetLength(0); j++)
            //    {
            //        for (int k = 0; k < array[i].GetLength(1); k++)
            //        {
            //            Console.Write($"{array[i][j, k]}");
            //        }

            //        Console.WriteLine();
            //    }

            //    Console.WriteLine();
            //}


            //byte[,][,] array = new byte[3,2][,];

            //array[0, 0] = new byte[2, 2] { { 10, 20 }, { 30, 40 } };
            //array[0, 1] = new byte[3, 2] { { 50, 60 }, { 70, 80 }, { 90, 99 } };

            //array[1, 0] = new byte[2, 2] { { 11, 12 }, { 13, 14 } };
            //array[1, 1] = new byte[3, 2] { { 15, 16 }, { 17, 18 }, { 19, 91 } };

            //array[2, 0] = new byte[2, 2] { { 21, 22 }, { 23, 24 } };
            //array[2, 1] = new byte[3, 2] { { 25, 26 }, { 27, 28 }, { 29, 92 } };

            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        for (int x = 0; x < array[i,j].GetLength(0); x++)
            //        {
            //            for (int y = 0; y < array[i,j].GetLength(1); y++)
            //            {
            //                Console.Write($"{array[i,j][x,y]} ");
            //            }
            //            Console.WriteLine();
            //        }
            //        Console.WriteLine();
            //    }
            //}

            //Operation(30000);
            //InfinityMethod();

            //uint number = Factorial(5);
            //Console.WriteLine(number);

            //int n = 0;
            //int result = 1;
            //for (int i = n; i > 0; i--)
            //{
            //    result *= i == 0 ? 1 : i;
            //}
            //Console.WriteLine(result);


            //uint b = GetFibonacci(8);
            //Console.WriteLine(b);

            int n = 8;
            int[] results = new int[n + 1];

            for (int i = 0; i <= n; i++)
            {
                if (i == 0 || i == 1)
                {
                    results[i] = i;
                }
                else
                {
                    results[i] = results[i - 1] + results[i - 2];
                }

            }
            Console.WriteLine(results[n]);

            Console.ReadKey();
        }


        //private static void Operation(int counter)
        //{
        //    counter--;
        //    Console.WriteLine("A: {0}", counter);

        //    if (counter != 0)
        //    {
        //        Operation(counter);
        //    }

        //    Console.WriteLine("B: {0}", counter);
        //}

        //private static void InfinityMethod()
        //{
        //    Console.WriteLine(0);
        //    InfinityMethod();
        //}

        //private static uint Factorial(uint n)
        //{
        //    if (n > 1)
        //    {
        //        return n * Factorial(n - 1);
        //    }
        //    else
        //    {
        //        return 1;
        //    }
        //}

        private static uint GetFibonacci(uint n)
        {
            return n == 0 ? 0 : n == 1 ? 1 : GetFibonacci(n - 2) + GetFibonacci(n - 1);
        }
    }
}
