using System;

namespace _036
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator for multiplying the first matrix by the second.\n");

            Console.Write($"{"Enter rows count of first matrix: ",-40}");
            uint rows_1 = uint.Parse(Console.ReadLine());

            Console.Write($"{"Enter columns count of first matrix: ",-40} ");
            uint columns_1 = uint.Parse(Console.ReadLine());

            Console.Write($"{"Enter rows count of second matrix: ",-40}");
            uint rows_2 = uint.Parse(Console.ReadLine());

            Console.Write($"{"Enter columns count of second matrix: ",-40}");
            uint columns_2 = uint.Parse(Console.ReadLine());


            if (IsMatrixMultAvailable(columns_1, rows_2))
            {
                Console.Write($"{"Enter minimal value of matrix cell: ",-40}");
                int min = int.Parse(Console.ReadLine());

                Console.Write($"{"Enter maximum value of matrix cell: ",-40} ");
                int max = int.Parse(Console.ReadLine());

                Random random = new Random();

                int[,] first = new int[rows_1, columns_1];
                RandomizeMatrix(first, random, min, max);

                int[,] second = new int[rows_2, columns_2];
                RandomizeMatrix(second, random, min, max);

                int[,] multResult = MatrixMult(first, second);

                PrintMatrix(first);
                Console.WriteLine("\n");

                PrintMatrix(second);
                Console.WriteLine("\n");

                PrintMatrix(multResult);

                Console.ReadKey();
            }
            else
            {
                throw new ArgumentException("Cannot multiply matrices with this entered demensions values");
            }
        }

        private static bool IsMatrixMultAvailable(uint firstMatrixColumns, uint secondMatrixRows)
        {
            return firstMatrixColumns == secondMatrixRows;
        }

        private static void RandomizeMatrix(int[,] matrix, Random random, int minValue = 0, int maxValue = 1)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int value = random.Next(minValue, maxValue);
                    matrix[i, j] = value;
                }
            }
        }


        private static int[,] MatrixMult(int[,] first, int[,] second)
        {
            int[,] result = new int[first.GetLength(0), second.GetLength(1)];

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    for (int a = 0; a < first.GetLength(1); a++)
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
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.Write("\n");
            }
        }
    }
}
