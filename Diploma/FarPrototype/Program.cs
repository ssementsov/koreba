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

            var lastWidth = Console.WindowWidth;

            //while (true)
            //{
            //    var key = Console.ReadKey();
            //    input.Handle(key);
            //}

            LoadAsync(() =>
            {
                while (true)
                {
                    if (lastWidth != Console.WindowWidth)
                    {
                        lastWidth = Console.WindowWidth;
                        visualizer.Draw();
                    }
                }
            });

            HandleInput(input);
        }

        private static async void LoadAsync(Action action)
        {
            await Task.Run(() => action);
        }

        private static void HandleInput(Input input)
        {
            while (true)
            {
                var key = Console.ReadKey();
                input.Handle(key);
            }
        }
    }
}