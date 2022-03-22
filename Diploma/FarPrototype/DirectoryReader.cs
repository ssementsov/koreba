namespace FarPrototype
{
    internal static class DirectoryReader
    {
        public static List<DirectoryInfo> GetDirectories(string currentDirectoryPath)
        {
            var directories = new List<DirectoryInfo>();

            foreach (var path in Directory.GetDirectories(currentDirectoryPath))
            {
                var info = new DirectoryInfo(path);
                if (info.Attributes == FileAttributes.Directory)
                {
                    directories.Add(info);
                }
            }

            return directories;
        }

        public static List<FileInfo> GetFiles(string currentDirectoryPath)
        {
            var files = new List<FileInfo>();

            foreach (var path in Directory.GetFiles(currentDirectoryPath))
            {
                var info = new FileInfo(path);

                if (info.Attributes != FileAttributes.Hidden)
                {
                    files.Add(info);
                }
            }

            return files;
        }
    }
}
