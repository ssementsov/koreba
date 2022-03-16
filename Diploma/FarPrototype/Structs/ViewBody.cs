namespace FarPrototype.Structs
{
    internal class ViewBody
    {
        private List<Element> _directories;
        private int _highlitedNumber;

        public ViewBody()
        {
            _directories = new List<Element>();
            HighliteElement(0);
        }
        public Element this[int i]
        {
            get => _directories[i];
        }
        public int GetLength() => _directories.Count;

        public void UpdateState(string currentDirectoryPath)
        {
            _directories.Clear();

            var directories = DirectoryReader.GetDirectories(currentDirectoryPath);
            var files = DirectoryReader.GetFiles(currentDirectoryPath);
            var parent = Directory.GetParent(currentDirectoryPath);

            if (parent != null)
            {
                _directories.Add(new Element(parent));
            }

            foreach (var dir in directories)
            {
                _directories.Add(new Element(dir));
            }

            foreach (var file in files)
            {
                _directories.Add(new Element(file));
            }
        } 

        public Element GetHighlitedElement()
        {
            return this[_highlitedNumber];
        }

        public void HighliteElement(int number)
        {
            this[number].SetIsHighlited(true);
            _highlitedNumber = number;
        }
    }
}
