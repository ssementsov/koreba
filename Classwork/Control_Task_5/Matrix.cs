namespace Control_Task_5
{
    internal class Matrix
    {
        private readonly decimal[,] _numbers;
        public int Rows => _numbers.GetLength(0);
        public int Columns => _numbers.GetLength(1);

        public Matrix(int rows, int columns)
        {
            _numbers = new decimal[rows, columns];
        }
        public Matrix(decimal[,] numbers)
        {
            _numbers = numbers;
        } 
        public decimal this[int row, int column]
        {
            get => _numbers[row, column];
            set => _numbers[row, column] = value;
        }

        public Matrix Sum(Matrix other)
        {
            if (Rows == other.Rows && Columns == other.Columns)
            {
                Matrix result = new Matrix(Rows, Columns);

                for (var i = 0; i < Rows; i++)
                {
                    for (var j = 0; j < Columns; j++)
                    {
                        result[i, j] = this[i, j] + other[i, j];
                    }
                }

                return result;
            }
            else
            {
                throw new ArgumentException("Cannot sum matrix with different rows or columns count");
            }
        }

        public Matrix Multiply(decimal number)
        {
            var result = new Matrix(Rows, Columns);

            for (var i = 0; i < Rows; i++)
            {
                for (var j = 0; j < Columns; j++)
                {
                    result[i, j] = this[i, j] * number;
                }
            }

            return result;
        }

        public void Print()
        {
            for (var i = 0; i < Rows; i++)
            {
                for (var j = 0; j < Columns; j++)
                {
                    Console.Write($"{this[i, j]} ");
                }

                Console.WriteLine();
            }
        }

        public Matrix MultiplyBy(Matrix other)
        {
            if (Columns == other.Rows)
            {
                var result = new Matrix(Rows, other.Columns);

                for (var i = 0; i < result.Rows; i++)
                {
                    for (var j = 0; j < result.Columns; j++)
                    {
                        for (var k = 0; k < Columns; k++)
                        {
                            result[i, j] += this[i, k] * other[k, j];
                        }
                    }
                }

                return result;
            }
            else
            {
                throw new ArgumentException($"Cannot multiply this matrix by given argument matrix");
            }
        }
    }
}
