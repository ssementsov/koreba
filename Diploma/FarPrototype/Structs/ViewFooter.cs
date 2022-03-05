using FarPrototype.Events;

namespace FarPrototype.Structs
{
    internal abstract class ViewFooter : Rect, IUpdatable
    {
        private const int HEIGHT = 2;

        private string[,] _data;
        public ViewFooter(int width) 
            : base(width)
        {
            Heigth = HEIGHT;
            _data = new string[Heigth, 1];
        }
        public void UpdateState(DirectoryInfo[] folders, FileInfo[] files)
        {
            UpdateDirectoryInfo(folders, files);
            InitHighlitedInfo();
        }
        protected abstract void InitHighlitedInfo();
        private void UpdateDirectoryInfo(DirectoryInfo[] folders, FileInfo[] files)
        {
            int foldersCount = folders.Length;
            int filesCount = folders.Length;

            long bytes = 0;
            foreach (var file in files)
            {
                bytes += file.Length;
            }
            string formatedBytes = ChangeBytesFormat(bytes);

            _data[Heigth - 1, Width - 1] = $" Bytes: {formatedBytes}, files: {filesCount}, folders: {foldersCount} ";
        }

        private string ChangeBytesFormat(long bytes)
        {
            int count = 0;

            if (bytes / 1000 >= 1)
            {
                bytes /= 1024;
                count++;
            }

            string result = bytes.ToString();

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
