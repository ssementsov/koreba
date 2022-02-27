using FarPrototype.Visualizers;
using FarPrototype.Structs;

namespace FarPrototype
{
    class Program
    {
        static void Main()
        {
            //string path = Directory.GetCurrentDirectory();

            //if (Directory.GetParent(path) != null)
            //{
            //    Console.WriteLine("..");
            //}

            //foreach (var item in Directory.GetDirectories(path))
            //{
            //    var dirInfo = new DirectoryInfo(item);
            //    Console.WriteLine(dirInfo.Name);

            //}

            //foreach (var item in Directory.GetFiles(path))
            //{
            //    var fileInfo = new FileInfo(item);
            //    Console.WriteLine($"{fileInfo.Name,-50}{fileInfo.Length,-10}\u2551{fileInfo.CreationTime:dd.MM.yy}\u2551{fileInfo.CreationTime:t}");
            //    Console.WriteLine(Path.GetExtension(fileInfo.FullName));             
            //}


            //string s = "\u2554\u2550\u2550\u2557\n" +
            //           "\u2551  \u2551\n" +
            //           "\u255a\u2550\u2550\u255d";
            //Console.WriteLine(s);

            //string b = "\u255f\u2500\u2500\u2568\u2500\u2500\u2562";
            //Console.WriteLine(b);


            var window = new Window();
            View view = new View(1, 0.5f);
            window.Views = new View[] { view };
            window.UpdateState();

            var vv = new ViewVisualizer(window);
            vv.PrepareBody();
            vv.BodyVisualizer.Draw();
        }
    }
}