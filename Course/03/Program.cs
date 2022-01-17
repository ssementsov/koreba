using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string template = "Foreground color set to ";
            Array colors = Enum.GetValues(typeof(ConsoleColor));

            foreach (ConsoleColor color in colors)
            {
                Console.ForegroundColor = color;
                Console.WriteLine(template + color.ToString());
            }

            Console.ReadKey();
        }
    }
}
