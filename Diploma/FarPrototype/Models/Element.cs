namespace FarPrototype.Models
{
    internal struct Element
    {
        public FileSystemInfo Info { get; private set; }
        public bool IsSelected { get; set; }

        public Element(FileSystemInfo info)
        {
            Info = info;
            IsSelected = false;
        }
    }
}
