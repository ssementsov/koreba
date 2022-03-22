using FarPrototype.Models;
using FarPrototype.Settings;

namespace FarPrototype.Visualizers.BodyTypes
{
    internal class FullBodyVisualizer : BodyVisualizer
    {
        private const string DATE_FORMAT = "dd.MM.yy";
        private const string TIME_FORMAT = "hh:mm";
        private const int SIZE_COLUMN_WIDTH = 6;

        public FullBodyVisualizer(ViewBody body, float heigthScale, float widthScale, float originScale) 
            : base(body, heigthScale, widthScale, originScale) { }
        public override void PrepareTable()
        {
            FillTable();
            CalculateColumnsWidth();
            AdjustName();
            AbjustSize();


        }
        public override void Draw()
        {
            Console.SetCursorPosition(Origin, 0);
            Console.BackgroundColor = VisualSettings.Background;
            var path = $" {Body.CurrentDirectoryPath} ";

            var pathBackground = Body.IsSelected ? VisualSettings.FocusBackground : VisualSettings.Background;
            var pathForeground = Body.IsSelected ? VisualSettings.TextFocusForeground : VisualSettings.TextForeground;

            var count = Width - path.Length - 2;
            var half = count / 2;

            var firstLine = string.Empty;
            if (path.Length + 2 > Width)
            {
                int index = path.Length + 2 - Width;
                firstLine = $"{Border.TopLeftCorner}{path[0..4]}\u2026{path[(4+index + 1)..]}";

                Write($"{Border.TopLeftCorner}", VisualSettings.BorderForeground);
                Write($"{path[0..4]}\u2026{path[(4+index + 1)..]}", pathForeground, pathBackground);

            }
            else
            {
                firstLine = $"{Border.TopLeftCorner}{new string(Border.HorizontalDoubleLine, half)}" +
                                   $"{path}";
                Write($"{Border.TopLeftCorner}{new string(Border.HorizontalDoubleLine, half)}", VisualSettings.BorderForeground);
                Write($"{path}", pathForeground, pathBackground);
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
                    var s = new string(Border.HorizontalDoubleLine, length - firstLine.Length - 1);
                    Write($"{s}", VisualSettings.BorderForeground, VisualSettings.Background);

                    firstLine += new string(Border.HorizontalDoubleLine, length - firstLine.Length - 1);

                    if (i < TableHeader.Length - 1 && TableHeader[i + 1].Length > 0)
                    {
                        firstLine += Border.DoubleHorizontalSingleVertical;
                        Write($"{Border.DoubleHorizontalSingleVertical}");
                    }
                }
            }
            WriteLine($"{Border.TopRightCorner}");

            Write($"{Border.VerticalDoubleLine}");
            for (int i = 0; i < TableHeader.Length; i++)
            {
                int alignment = (ColumnsWidth[i] - TableHeader[i].Length);
                string s = $"{new string(' ', alignment/2)}{TableHeader[i]}{new string(' ', alignment - alignment/2)}";
                Write(s, VisualSettings.TextForeground);
                if (i is > 0 and < 4)
                {
                    Write($"{Border.VerticalSingleLine}", VisualSettings.BorderForeground);
                }
            }

            WriteLine($"{Border.VerticalDoubleLine}", VisualSettings.BorderForeground);


            for (int i = 0; i < Table.GetLength(0); i++)
            {
                var background = Body.IsSelected && Body.SelectedRaw == i ? VisualSettings.FocusBackground : VisualSettings.Background;

                Write($"{Border.VerticalDoubleLine}", VisualSettings.BorderForeground);

                for (int j = 0; j < Table.GetLength(1); j++)
                {
                    Write($"{Table[i, j]}", VisualSettings.TextForeground, background);
                    if (Table[i, j].Length < ColumnsWidth[j])
                    {
                        Write($"{new string(' ', ColumnsWidth[j] - Table[i, j].Length)}", VisualSettings.TextForeground);
                    } 

                    if (j > 0 && j < Table.GetLength(1) - 1)
                    {
                        Write($"{Border.VerticalSingleLine}", VisualSettings.BorderForeground);
                    }
                }

                WriteLine($"{Border.VerticalDoubleLine}", VisualSettings.BorderForeground, VisualSettings.Background);
            }

            string lastLine = $"{Border.LeftDoubleVerticalSingleHorizontal}";
            for (int i = 0; i < Table.GetLength(1); i++)
            {
                lastLine += new string(Border.HorizontalSingleLine, ColumnsWidth[i]);
                if (i > 0 && i < Table.GetLength(1) - 1)
                {
                    lastLine += $"{Border.UpAndHorizontal}";
                }
            }
            lastLine += $"{Border.RightDoubleVerticalSingleHorizontal}\n";
            WriteLine(lastLine);
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
                0, 0, SIZE_COLUMN_WIDTH, DATE_FORMAT.Length, TIME_FORMAT.Length
            };
        }

        private void FillTable()
        {
            InitializeTable();

            for (int row = 0; row < Body.GetLength(); row++)
            {
                var info = Body[row];

                Table[row, 0] = Path.GetFileNameWithoutExtension(info.FullName);

                if (info is DirectoryInfo dir)
                {
                    Table[row, 1] = string.Empty;
                    Table[row, 2] = "Folder";
                }
                else
                {
                    var file = info as FileInfo;
                    Table[row, 1] = Path.GetExtension(file.FullName)[1..];
                    Table[row, 2] = file.Length.ToString();
                }

                if (row == 0)
                {
                    var parent = new DirectoryInfo(Body.CurrentDirectoryPath).Parent;
                    if (parent != null && parent.Attributes != FileAttributes.Hidden)
                    {
                        Table[row, 0] = "..";
                        Table[row, 1] = string.Empty;
                        Table[row, 2] = "Up";
                    }
                }

                Table[row, 3] = $"{info.CreationTime.ToString(DATE_FORMAT)}";
                Table[row, 4] = $"{info.CreationTime.ToString(TIME_FORMAT)}";
            }
        }

        private void InitializeTable()
        {
            int rowsCount = Body.GetLength();
            rowsCount = Math.Min(Height - 5, rowsCount);

            Table = new string[rowsCount, TableHeader.Length];
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

            int length = Width - ColumnsWidth.Length;
            for (int i = ColumnsWidth.Length - 1; i > 0; i--)
            {
                length -= ColumnsWidth[i];
            }
            ColumnsWidth[0] = length;
        }

        private void AdjustName()
        {
            for (int i = 0; i < Table.GetLength(0); i++)
            {
                string name = Table[i, 0];
                if (name.Length > ColumnsWidth[0])
                {
                    Table[i, 0] = $"{name[0..(ColumnsWidth[0] - 2)]}\u2026.";
                }
            }
        }

        private void AbjustSize()
        {
            for (int i = 0; i < Table.GetLength(0); i++)
            {
                if (Table[i, 2].Length > ColumnsWidth[2])
                {
                    Table[i, 2] = ChangeSizeFormat(Table[i, 2]);
                }
                Table[i, 2] = $"{new string(' ', ColumnsWidth[2] - Table[i, 2].Length)}{Table[i, 2]}";
            }
        }

        private string ChangeSizeFormat(string size)
        {
            long value = long.Parse(size);
            int count = 0;

            if (value / Math.Pow(10, SIZE_COLUMN_WIDTH) >= 1)
            {
                value /= 1024;
                count++;

                while (value / 10000 >= 1)
                {
                    value /= 1024;
                    count++;
                }
            }
            string result = value.ToString();

            string postfix = string.Empty;
            switch (count)
            {
                case 0:
                    break;
                case 1:
                    postfix = " K";
                    break;
                case 2:
                    postfix = " M";
                    break;
                case 3:
                    postfix = " G";
                    break;
                case 4:
                    postfix = " T";
                    break;
                default:
                    break;
            }
            result += postfix;
            return result;
        }


    }
}
