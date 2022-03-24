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

            //var lastWidth = Console.WindowWidth;

            while (true)
            {
                //if (lastWidth != Console.WindowWidth)
                //{
                //    visualizer.Draw();
                //}

                //lastWidth = Console.WindowWidth;

                var key = Console.ReadKey();
                input.Handle(key);
            }
        }
    }
}