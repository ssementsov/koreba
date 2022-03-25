using FarPrototype.Models;
using FarPrototype.Visualizers.BodyTypes.Columns;
using FarPrototype.Visualizers.BodyTypes.TestVisuzlizers;

namespace FarPrototype.Visualizers.BodyTypes
{
    internal class FullTable : Table
    {
        private const string DATE_FORMAT = "dd.MM.yy";
        private const string TIME_FORMAT = "hh:mm";
        private const int SIZE_COLUMN_WIDTH = 6;

        private string[,] _data;
        private readonly Column[] _columns;

        public FullTable(ViewBody body, float heigthScale, float widthScale, float originScale) 
            : base(heigthScale, widthScale, originScale)
        {
            var c1 = new ExtensionColumn(GetMaxExtencionLength(body));
            var c2 = new SizeColumn(SIZE_COLUMN_WIDTH);
            var c3 = new DateColumn(DATE_FORMAT.Length);
            var c4 = new TimeColumn(TIME_FORMAT.Length);
            var c0 = new NameColumn(CalculateNameColumnWidth());

            _columns = new Column[]
            {
                c0, c1, c2, c3, c4
            };
        }

        private int CalculateNameColumnWidth()
        {
            var nameColumnWidth = Width - 1;

            for (var i = 0; i < _columns.Length; i++)
            {
                nameColumnWidth -= _columns[i].Width - 1;
            }

            return nameColumnWidth;
        }

        public void FillData(ViewBody body)
        {
            _data = new string[body.GetLength(), _columns.Length];

            for (var i = 0; i < _data.GetLength(0); i++)
            {
                var info = body[i];

                _data[i, 0] = Path.GetFileNameWithoutExtension(info.FullName);

                if (info is DirectoryInfo dir)
                {
                    _data[i, 1] = string.Empty;
                    _data[i, 2] = "Folder";
                }
                else
                {
                    var file = info as FileInfo;
                    _data[i, 1] = Path.GetExtension(file.FullName)[1..];
                    _data[i, 2] = file.Length.ToString();
                }

                if (i == 0)
                {
                    var parent = new DirectoryInfo(body.CurrentDirectoryPath).Parent;
                    if (parent != null && parent.Attributes != FileAttributes.Hidden)
                    {
                        _data[i, 0] = "..";
                        _data[i, 1] = string.Empty;
                        _data[i, 2] = "Up";
                    }
                }

                _data[i, 3] = $"{info.CreationTime.ToString(DATE_FORMAT)}";
                _data[i, 4] = $"{info.CreationTime.ToString(TIME_FORMAT)}";
            }
        }

        private int GetMaxExtencionLength(ViewBody body)
        {
            var maxLength = -1;
            for (var i = 0; i < body.GetLength(); i++)
            {
                var itemLength = Path.GetExtension(body[i].FullName).Length;
                maxLength = itemLength > maxLength ? itemLength : maxLength;
            }

            return maxLength;
        }

        //public string[,] GetFormatted()
        //{
        //    var data = new string[_data.GetLength(0), _data.GetLength(1)];


        //}
    }
}
