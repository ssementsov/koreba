namespace FarPrototype.WindowStructures
{
    internal abstract class Table
    {
        protected string[,] data;
        protected int[] columnsWidth;
        protected int columnsCount = 1;

        public Table(DirectoryInfo[] directories, FileInfo[] files)
        {
            columnsWidth = new int[columnsCount];
            FillData(directories, files);
        }
        public string this[int row, int column]
        {
            get => data[row, column];
            set => data[row, column] = value;
        }
        public abstract void CalculateColumnsWidth();
        protected virtual void FillData(DirectoryInfo[] directories, FileInfo[] files)
        {
            string path = Directory.GetCurrentDirectory();
            bool isRoot = Directory.GetParent(path) == null;

            int length = 1;
            length = isRoot ? length : ++length;

            length = directories is null ? length : length + directories.Length;
            length = files is null ? length : length + files.Length;

            data = new string[length, columnsCount];

            FillTitle();
        }

        protected abstract void FillTitle();
    }
}
