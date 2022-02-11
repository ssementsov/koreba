namespace Birds
{
    internal class Skin
    {
        public ConsoleColor Color { get; private set; }
        public Skin()
        {
            Color = ConsoleColor.Black;
        }
        public Skin(ConsoleColor color)
        {
            Color = color;
        }
    }
}
