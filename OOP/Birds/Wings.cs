namespace Birds
{
    internal class Wings
    {
        public ConsoleColor Color { get; private set; }
        public uint Count { get; private set; }

        public Wings()
        {
            Count = 2;
            Color = ConsoleColor.Black;
        }

        public Wings(uint count, ConsoleColor color)
        {
            Count = count;
            Color = color;
        }
    }
}
