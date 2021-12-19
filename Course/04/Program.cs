using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            string template = "Background color set to ";
            Array colors = Enum.GetValues(typeof(ConsoleColor));

            foreach (ConsoleColor color in colors)
            {
                Console.BackgroundColor = color;
                Console.WriteLine(template + color.ToString());
            }

            Console.ReadKey();
        }
    }
}
