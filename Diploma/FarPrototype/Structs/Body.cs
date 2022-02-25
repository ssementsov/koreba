namespace FarPrototype.Structs
{
    internal class Body
    {
        private List<Element> _elements;

        public Body()
        {
            _elements = new List<Element>();
        }
        public Element this[int i]
        {
            get => _elements[i];
        }

        public void UpdateState(DirectoryInfo[] directories, FileInfo[] files)
        {
            _elements.Clear();

            foreach (var dir in directories)
            {
                _elements.Add(new Element(dir));
            }

            foreach (var dir in files)
            {
                _elements.Add(new Element(dir));
            }
        }
    }
}
