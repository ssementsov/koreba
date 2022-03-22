namespace FarPrototype.Models
{
    internal class ViewBody
    {
        private readonly List<FileSystemInfo> _elements;
        private int _selectedRaw;
        public bool IsSelected { get; set; }
        public int SelectedRaw
        {
            get => _selectedRaw;
            set
            {
                if (value >= 0 && value < _elements.Count)
                {
                    _selectedRaw = value;
                }
            }
        }
        public string CurrentDirectoryPath { get; private set; }

        public ViewBody()
        {
            _elements = new List<FileSystemInfo>();
        }
        public FileSystemInfo this[int i]
        {
            get => _elements[i];
            private set => _elements[i] = value;
        }
        public int GetLength() => _elements.Count;
        public void Update(string currentDirectoryPath)
        {
            CurrentDirectoryPath = currentDirectoryPath;
            _elements.Clear();

            var directories = DirectoryReader.GetDirectories(currentDirectoryPath);
            var files = DirectoryReader.GetFiles(currentDirectoryPath);

            var parent = Directory.GetParent(currentDirectoryPath);

            if (parent != null)
            {
                _elements.Add(parent);
            }

            foreach (var dir in directories)
            {
                _elements.Add(dir);
            }

            foreach (var file in files)
            {
                _elements.Add(file);
            }

            SelectedRaw = 0;
        } 
    }
}
