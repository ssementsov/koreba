namespace FarPrototype
{
    internal static class DirectoryReader
    {
        public static DirectoryInfo[] GetDirectories(string currentDirectoryPath)
        {
            string[] pathes = Directory.GetDirectories(currentDirectoryPath);
            DirectoryInfo[] info = new DirectoryInfo[pathes.Length];

            for (var i = 0; i < pathes.Length; i++)
            {
                info[i] = new DirectoryInfo(pathes[i]);
            }

            return info;
        }

        public static FileInfo[] GetFiles(string currentDirectoryPath)
        {
            string[] pathes = Directory.GetFiles(currentDirectoryPath);
            FileInfo[] info = new FileInfo[pathes.Length];

            for (var i = 0; i < pathes.Length; i++)
            {
                info[i] = new FileInfo(pathes[i]);
            }

            return info;
        }
    }
}
