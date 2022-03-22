using FarPrototype.Models;
using FarPrototype.Visualizers;

namespace FarPrototype
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var path = Directory.GetCurrentDirectory();

            var window = new Window(2);
            window.UpdateAllViews(path);

            var visualizer = new ApplicationVisualizer(window);
            visualizer.UpdateAllViews();
            visualizer.Draw();

            var input = new Input(window, visualizer);

            //Console.SetCursorPosition(Console.WindowWidth/2, 0);
            //Console.WriteLine("hello");
            //Console.CursorLeft = Console.WindowWidth/2;

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                input.Handle(key);
            }
        }
    }
}