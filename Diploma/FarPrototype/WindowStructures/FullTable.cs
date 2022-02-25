namespace FarPrototype.WindowStructures
{
    internal sealed class FullTable : TableVisualizer
    {
        protected new int columnsCount = 5;
        public FullTable(DirectoryInfo[] directories, FileInfo[] files)
            : base(directories, files)
        {

        }


        public override void CalculateColumnsWidth()
        {

        }

        protected override void FillData(DirectoryInfo[] directories, FileInfo[] files)
        {
            base.FillData(directories, files);

            DirectoryInfo parent = Directory.GetParent(Directory.GetCurrentDirectory());
            int row = 1;
            if (parent != null)
            {
                data[row, 0] = "..";
                data[row, 2] = "Up";
                data[row, 3] = $"{parent.CreationTime:d}";
                data[row, 4] = $"{parent.CreationTime:t}";
                row++;
            }

            foreach (var directory in directories)
            {
                data[row, 0] = directory.Name;
                data[row, 2] = "Folder";
                data[row, 3] = $"{directory.CreationTime:dd.MM.yy}";
                data[row, 4] = $"{directory.CreationTime:t}";
                row++;
            }

            foreach (var file in files)
            {
                data[row, 0] = file.Name;
                data[row, 1] = Path.GetExtension(file.FullName)[1..];
                data[row, 2] = "Folder";
                data[row, 3] = $"{file.CreationTime:dd.MM.yy}";
                data[row, 4] = $"{file.CreationTime:t}";
                row++;
            }
        }

        protected override void FillTitle()
        {
            data[0, 0] = "Name";
            data[0, 2] = "Size";
            data[0, 3] = "Date";
            data[0, 4] = "Time";
        }
    }
}
