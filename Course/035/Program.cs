using System;

namespace _035
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator for multiplying the first matrix by the second.\n");

            Console.Write($"{"Enter rows count of first matrix: ", -40}");
            uint rows_1 = uint.Parse(Console.ReadLine());

            Console.Write($"{"Enter columns count of first matrix: ", -40} ");
            uint columns_1 = uint.Parse(Console.ReadLine());

            Console.Write($"{"Enter rows count of second matrix: ", -40}");
            uint rows_2 = uint.Parse(Console.ReadLine());

            Console.Write($"{"Enter columns count of second matrix: ", -40}");
            uint columns_2 = uint.Parse(Console.ReadLine());


            if (IsMatrixMultAvailable(columns_1, rows_2))
            {
                int[,] first = new int[rows_1, columns_1];
                FillMatrix(first);

                int[,] second = new int[rows_2, columns_2];
                FillMatrix(second);

                int[,] multResult = MatrixMult(first, second);

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

        private static void FillMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"Enter the value of the matrix cell {i};{j} {":",-5}");
                    int value = int.Parse(Console.ReadLine());
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
