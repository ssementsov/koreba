using System;
using FarPrototype.Models;
using FarPrototype.Visualizers.BodyTypes.Columns;

namespace FarPrototype.Visualizers.BodyTypes
{
    internal class FullTable : Rect
    {
        private const string DATE_FORMAT = "dd.MM.yy";
        private const string TIME_FORMAT = "hh:mm";
        private const int SIZE_COLUMN_WIDTH = 6;

        private string[,] _data;
        private Column[] _columns;

        public FullTable(ViewBody body, float heigthScale, float widthScale, float originScale) 
            : base(heigthScale, widthScale, originScale)
        {
            _columns = new Column[]
            {
                new ExtensionColumn(GetMaxExtencionLength(body)),
                new SizeColumn(SIZE_COLUMN_WIDTH),
                new DateColumn(DATE_FORMAT.Length),
                new TimeColumn(TIME_FORMAT.Length)
            };

            var nameColumnWidth = Width - 1;

            for (var i = 0; i < _columns.Length; i++)
            {
                nameColumnWidth -= _columns[i].Width - 1;
            }

            Array.Resize(ref _columns, _columns.Length + 1);

            for (var i = _columns.Length - 1; i > 0; i--)
            {
                _columns[i] = _columns[i - 1];
            }

            _columns[0] = new NameColumn(nameColumnWidth);
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

                //_data[i, 3] = $"{info.CreationTime.ToString(DATE_FORMAT)}";
                //_data[i, 4] = $"{info.CreationTime.ToString(TIME_FORMAT)}";
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
    }
}
