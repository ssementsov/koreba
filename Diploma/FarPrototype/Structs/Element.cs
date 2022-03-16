namespace FarPrototype.Structs
{
    internal struct Element
    {
        public FileSystemInfo Info { get; private set; }
        public bool IsHighlighted { get; private set; }

        public Element(FileSystemInfo info)
        {
            Info = info;
            IsHighlighted = false;
        }

        public void SetIsHighlited(bool isHighlited)
        {
            IsHighlighted = isHighlited;
        }
    }
}
