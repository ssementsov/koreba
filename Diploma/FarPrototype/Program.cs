using FarPrototype.Visualizers;
using FarPrototype.Structs;

namespace FarPrototype
{
    class Program
    {
        static void Main()
        {
            //Directory.SetCurrentDirectory($"C:\\");
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var window = new Window();
            window.UpdateState();

            var vv = new ViewVisualizer(window.Views[0]);
            vv.PrepareBody();
            vv.Draw();
        }
    }
}