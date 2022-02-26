namespace FarPrototype.Visualizers.BodyTypes
{
    internal class FullBodyVisualizer : BodyVisualizer
    {

        public FullBodyVisualizer(View view) 
            : base(view) 
        {
            InitializeHeader();
        }

        public override void Draw()
        {
            //int pathLength = Directory.GetCurrentDirectory().Length;

        }
        protected override void InitializeHeader()
        {
            TableHeader = new string[]
            {
                "Name", string.Empty, "Size", "Date", "Time"
            };
        }

        public override void Test()
        {
            FillTable();

            for (int i = 0; i < Table.GetLength(0); i++)
            {
                for (int j = 0; j < Table.GetLength(1); j++)
                {
                    Console.Write($"{Table[i,j], -30}");
                }

                Console.WriteLine();
            }
        }

        private void FillTable()
        {
            int rowsCount = View.Body.GetLength();

            string path = Directory.GetCurrentDirectory();
            bool isRoot = Directory.GetParent(path) == null;
            rowsCount = isRoot ? rowsCount : ++rowsCount;

            rowsCount = Math.Min(View.Height - 4, rowsCount);

            Table = new string[rowsCount, TableHeader.Length];

            DirectoryInfo parent = Directory.GetParent(path);
            int row = 0;
            if (parent != null)
            {
                Table[row, 0] = "..";
                Table[row, 2] = "Up";
                Table[row, 3] = $"{parent.CreationTime:dd.MM.yy}";
                Table[row, 4] = $"{parent.CreationTime:t}";
                row++;
            }

            for (int i = 0; i < View.Body.GetLength(); i++, row++)
            {
                FileSystemInfo info = View.Body[i].Info;
                Table[row, 0] = Path.GetFileNameWithoutExtension(info.FullName);

                DirectoryInfo dir = info as DirectoryInfo;
                if (dir != null)
                {
                    Table[row, 2] = "Folder";
                }
                else
                {
                    FileInfo file = info as FileInfo;
                    Table[row, 1] = Path.GetExtension(file.FullName)[1..];
                    Table[row, 2] = file.Length.ToString();
                }

                Table[row, 3] = $"{info.CreationTime:dd.MM.yy}";
                Table[row, 4] = $"{info.CreationTime:t}";
            }
        }
    }
}
