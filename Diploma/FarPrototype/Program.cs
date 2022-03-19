using FarPrototype.Models;
using FarPrototype.Visualizers;

namespace FarPrototype
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var window = new Window(2);
            window.UpdateState();

            var visualizer = new ApplicationVisualizer(window);
            visualizer.Update();
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