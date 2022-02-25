namespace FarPrototype
{
    internal static class DirectoryReader
    {
        public static DirectoryInfo[] GetDirectories()
        {
            string path = Directory.GetCurrentDirectory();
            string[] pathes = Directory.GetDirectories(path);
            DirectoryInfo[] info = new DirectoryInfo[pathes.Length];

            for (var i = 0; i < pathes.Length; i++)
            {
                info[i] = new DirectoryInfo(pathes[i]);
            }

            return info;
        }

        public static FileInfo[] GetFiles()
        {
            string path = Directory.GetCurrentDirectory();
            string[] pathes = Directory.GetFiles(path);
            FileInfo[] info = new FileInfo[pathes.Length];

            for (var i = 0; i < pathes.Length; i++)
            {
                info[i] = new FileInfo(pathes[i]);
            }

            return info;
        }
    }
}
