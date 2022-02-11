namespace Birds
{
    internal class Feather
    {
        public ConsoleColor Color { get; private set; }
        public Feather()
        {
            Color = ConsoleColor.White;
        }
        public Feather(ConsoleColor color)
        {
            Color = color;
        }
    }
}
