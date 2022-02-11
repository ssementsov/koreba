namespace FarPrototype.WindowStructures
{
    internal class Row
    {
        public FileSystemInfo FileSystemInfo { get; private set; }

        public Row(FileSystemInfo fileSystemInfo)
        {
            FileSystemInfo = fileSystemInfo;
        }
    }
}
