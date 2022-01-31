using System;

namespace Control_Task_5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers_1 = new decimal[,]
            {
                {1, 2, 3 },
                {4, 5, 6 }
            };

            var numbers_2 = new decimal[,]
            {
                {7, 8, 9 },
                {0, 11, 12 },
            };

            var numbers_3 = new decimal[,]
            {
                {7, 8, 9 },
                {0, 11, 12 },
                {1, 2, 3 }
            };

            var matrix_1 = new Matrix(numbers_1);
            var matrix_2 = new Matrix(numbers_2);
            var matrix_3 = new Matrix(numbers_3);

            var sum = matrix_1.Sum(matrix_2);
            sum.Print();
            Console.WriteLine();

            var multByNumber = matrix_1.Multiply(5);
            multByNumber.Print();
            Console.WriteLine();

            var multByMatrix = matrix_1.MultiplyBy(matrix_3);
            multByMatrix.Print();
        }
    }
}
