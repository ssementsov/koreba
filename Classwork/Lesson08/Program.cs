using System;

namespace Lesson08
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 1, b = 2, c = 3;

            //Console.WriteLine(Third(a, b, c, true));
            //Console.ReadKey();


            //----------------------- TASK 35 ------------------------

            //Console.Write($"{"Enter y_length of first double demension array: ", -50}");
            //uint y1_length = uint.Parse(Console.ReadLine());

            //Console.Write($"{"Enter x_length of first double demension array: ", -50} ");
            //uint x1_length = uint.Parse(Console.ReadLine());

            //Console.Write($"{"Enter y_length of second double demension array: ", -50}");
            //uint y2_length = uint.Parse(Console.ReadLine());

            //Console.Write($"Enter x_length of second double demension array {": ",-40}");
            //uint x2_length = uint.Parse(Console.ReadLine());


            //if (IsMatrixMultAvailable(x1_length, y2_length))
            //{
            //    int[,] first = new int[y1_length, x1_length];
            //    int[,] second = new int[y2_length, x2_length];

            //    int[,] multResult = MatrixMult(first, second);

            //    PrintMatrix(multResult);
            //    Console.ReadKey();
            //}
            //else
            //{
            //    throw new ArgumentException("Cannot multiply matrices with this entered demension values");
            //}


            /* ОДНОЗНАЧНОСТЬ
            Sum();
            Sum(1);

            Sum(1, 2);
            Sum(1, 2, 3);
            */


        }

        private static bool IsMatrixMultAvailable(uint firstMatrixColumns, uint secondMatrixRows)
        {
            return firstMatrixColumns == secondMatrixRows;
        }


        private static int[,] MatrixMult(int[,] first, int[,] second)
        {
            int[,] result = new int[first.GetLength(1), second.GetLength(0)];

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    for (int a = 0; a < result.GetLength(0); a++)
                    {
                        result[i, j] += first[i, a] * second[a, j];
                    }
                }
            }

            return result;
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.Write("\n");
            }
        }


        // --------------------- TASK 38 --------------------------

        static int First(int a, int b, int c)
        {
            return a + b + c;
        }

        static int Second(ref int a, ref int b, ref int c)
        {
            return ++a + ++b + ++c;
        }

        static int Third(int a, int b, int c, bool d)
        {
            return d ? First(a, b, c) : Second(ref a, ref b, ref c);
        }

        //--------------------------------------------------------


        static void Sum(int a = 0, int b = 0)
        {
            Console.WriteLine(a + b);
        }

        static void Sum(int a = 0, int b = 0, int c = 0)
        {
            Console.WriteLine(a + b + c);
        }


        // -------------- Overloading ref, out, in --------------------
        //static void Method(int a)
        //{
        //    Console.WriteLine($"Простой параметр {a}");
        //}

        //static void Method(ref int a)
        //{
        //    Console.WriteLine($"Ref параметр {a}");
        //}

        //static void Method(out int a)
        //{
        //    a = 3;
        //    Console.WriteLine($"Out параметр {a}");
        //}

        //static void Method(in int a)
        //{
        //    Console.WriteLine($"In параметр {a}");
        //}

        //-------------------------------------------------------------
    }
}
