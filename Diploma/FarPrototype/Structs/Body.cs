namespace FarPrototype.Structs
{
    internal class Body
    {
        private List<Element> _directories;

        public Body()
        {
            _directories = new List<Element>();
        }
        public Element this[int i]
        {
            get => _directories[i];
        }
        public int GetLength() => _directories.Count;

        public void UpdateState(DirectoryInfo[] directories, FileInfo[] files)
        {
            _directories.Clear();

            foreach (var dir in directories)
            {
                _directories.Add(new Element(dir));
            }

            foreach (var dir in files)
            {
                _directories.Add(new Element(dir));
            }
        } 

        public int GetHighlitedElementNumber()
        {
            for (int i = 0; i < _directories.Count; i++)
            {
                if (_directories[i].IsHighlighted)
                {
                    return i;
                }
            }

            throw new IndexOutOfRangeException("No one of the body elements are highlighted");
        }
    }
}
