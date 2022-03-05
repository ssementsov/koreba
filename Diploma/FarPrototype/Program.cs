using FarPrototype.Visualizers;
using FarPrototype.Structs;

namespace FarPrototype
{
    class Program
    {
        static void Main()
        {
            Directory.SetCurrentDirectory($"C:\\");
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var window = new Window();
            View view = new View(1, 0.8f);
            window.Views = new View[] { view };
            window.UpdateState();

            var vv = new ViewVisualizer(view);
            vv.PrepareBody();
            vv.Draw();
        }
    }
}