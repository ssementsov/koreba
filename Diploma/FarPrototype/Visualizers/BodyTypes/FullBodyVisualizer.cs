using FarPrototype.Settings;

namespace FarPrototype.Visualizers.BodyTypes
{
    internal class FullBodyVisualizer : BodyVisualizer
    {

        public FullBodyVisualizer(View view) 
            : base(view) { }

        public override void Draw()
        {
            Console.BackgroundColor = VisualSettings.Background;

            string path = Directory.GetCurrentDirectory();

            int count = View.Width - path.Length - 4;
            int half = count / 2;

            string firstLine = string.Empty;
            if (path.Length + 4 > View.Width)
            {
                int index = path.Length - View.Width + 4;
                firstLine = $"{Border.TopLeftCorner} {path[0..3]}\u2026{path[(3+index + 1)..]} ";
            }
            else
            {
                firstLine = $"{Border.TopLeftCorner}{new string(Border.HorizontalDoubleLine, half)}" +
                                   $" {path} ";
            }

            int length = 1;
            for (int i = 0; i < TableHeader.Length; i++)
            {
                length += ColumnsWidth[i];
                if (i > 0)
                {
                    length++;
                }

                if (length > firstLine.Length)
                {
                    firstLine += new string(Border.HorizontalDoubleLine, length - firstLine.Length - 1);

                    if (i < TableHeader.Length - 1 && TableHeader[i + 1].Length > 0)
                    {
                        firstLine += Border.DoubleHorizontalDownSingle;
                    }
                }
                

            }
            firstLine += $"{Border.TopRightCorner}\n";
            Write(firstLine, VisualSettings.BorderForeground);


            Write($"{Border.VerticalDoubleLine}");
            for (int i = 0; i < TableHeader.Length; i++)
            {
                int alignment = (ColumnsWidth[i] - TableHeader[i].Length);
                string s = $"{new string(' ', alignment/2)}{TableHeader[i]}{new string(' ', alignment - alignment/2)}";
                Write(s, VisualSettings.TextForeground);
                if (i > 0 && i < 4)
                {
                    Write($"{Border.VerticalSingleLine}", VisualSettings.BorderForeground);
                }
            }
            Write($"{Border.VerticalDoubleLine}\n", VisualSettings.BorderForeground);


            for (int i = 0; i < Table.GetLength(0); i++)
            {
                Write($"{Border.VerticalDoubleLine}");
                for (int j = 0; j < Table.GetLength(1); j++)
                {
                    if (Table[i, j].Length > ColumnsWidth[j])
                    {
                        Write($"{Table[i, j][0..(ColumnsWidth[j] - 2)]}\u2026.", VisualSettings.TextForeground);
                    }
                    else
                    {
                        Write($"{Table[i, j]}{new string(' ', ColumnsWidth[j] - Table[i, j].Length)}", VisualSettings.TextForeground);
                    }
                    if (j > 0 && j < Table.GetLength(1) - 1)
                    {
                        Write($"{Border.VerticalSingleLine}", VisualSettings.BorderForeground);
                    }
                }
                Write($"{Border.VerticalDoubleLine}\n", VisualSettings.BorderForeground);
            }

            string lastLine = $"{Border.LeftVerticalDoubleLineIntersectSingle}";
            for (int i = 0; i < Table.GetLength(1); i++)
            {
                lastLine += new string(Border.HorizontalSingleLine, ColumnsWidth[i]);
                if (i > 0 && i < Table.GetLength(1) - 1)
                {
                    lastLine += $"{Border.UpAndHorizontal}";
                }
            }
            lastLine += $"{Border.RightVerticalDoubleLineIntersectSingle}\n";
            Write(lastLine);
        }
        protected override void InitializeHeader()
        {
            TableHeader = new string[]
            {
                "Name", string.Empty, "Size", "Date", "Time"
            };
        }
        protected override void InitializeColumnsWidth()
        {
            ColumnsWidth = new int[]
            {
                0, 0, 6, 8, 5
            };
        }

        public override void PrepareTable()
        {
            FillTable();
            CalculateColumnsWidth();
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
                Table[row, 1] = string.Empty;
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
                    Table[row, 1] = string.Empty;
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

        private void CalculateColumnsWidth()
        {
            int max = 0;
            for (int i = 0; i < Table.GetLength(0); i++)
            {
                int currentLength = Table[i, 1].Length;
                if (currentLength > max)
                {
                    max = currentLength;
                }
            }
            ColumnsWidth[1] = max;

            int length = View.Width - ColumnsWidth.Length;
            for (int i = ColumnsWidth.Length - 1; i > 0; i--)
            {
                length -= ColumnsWidth[i];
            }
            ColumnsWidth[0] = length;
        }
    }
}
