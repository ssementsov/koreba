namespace Lesson013
{
    internal class ArrayClass
    {
        private int[][] _array = new int[3][]
        {
            new int[4],
            new int[5],
            new int[3]
        };

        public int this[int index1, int index2]
        {
            get => _array[index1][index2];
            set => _array[index1][index2] = value;
        }

        public int GetFirstDimension()
        {
            return _array.GetLength(0);
        }

        public int GetSecondDimension(int index)
        {
            return _array[index].GetLength(0);
        }
    }
}
