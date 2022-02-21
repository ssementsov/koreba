namespace FarPrototype
{
    class Program
    {
        static void Main()
        {
            string path = Directory.GetCurrentDirectory();

            if (Directory.GetParent(path) != null)
            {
                Console.WriteLine("..");
            }

            foreach (var item in Directory.GetDirectories(path))
            {
                var dirInfo = new DirectoryInfo(item);
                Console.WriteLine(dirInfo.Name);

            }

            foreach (var item in Directory.GetFiles(path))
            {
                var fileInfo = new FileInfo(item);
                Console.WriteLine($"{fileInfo.Name,-50}{fileInfo.Length,-10}|{fileInfo.CreationTime:dd.MM.yy}|{fileInfo.CreationTime:t}");
            }

        }
    }
}