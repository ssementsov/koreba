namespace FarPrototype.Visualizers
{
    internal abstract class Visualizer
    {
        private const float MIN_SCALE = 0.15f;
        public int Height => (int)(Console.WindowHeight * HeightScale);
        public int Width => (int)(Console.WindowWidth * WidthScale);
        public int Origin => (int)(Console.WindowWidth * OriginScale);
        protected float HeightScale { get; init; }
        protected float WidthScale { get; init; }
        protected float OriginScale { get; init; }
        public Visualizer(float heigthScale, float widthScale, float originScale)
            : this(widthScale, originScale)
        {
            CheckScale(heigthScale);
            HeightScale = heigthScale;
        }
        public Visualizer(float widthScale, float originScale)
        {
            CheckScale(widthScale);

            WidthScale = widthScale;
            OriginScale = originScale;
        }
        private static void CheckScale(float scale)
        {
            if (scale is <= MIN_SCALE or >1f)
            {
                throw new ArgumentException($"Cannot create Rect with scale size = {scale}");
            }
        }

        protected void Write(string s, ConsoleColor foregroundColor, ConsoleColor backgroundColor)
        {
            SetBackgroundColor(backgroundColor);
            Write(s, foregroundColor);
        }
        protected void Write(string s, ConsoleColor foregroundColor)
        {
            SetForegroundColor(foregroundColor);
            Write(s);
        }
        protected void Write(string s)
        {
            Console.Write(s);
        }
        protected void WriteLine(string s, ConsoleColor foregroundColor, ConsoleColor backgroundColor)
        {
            SetBackgroundColor(backgroundColor);
            WriteLine(s, foregroundColor);
        }
        protected void WriteLine(string s, ConsoleColor foregroundColor)
        {
            SetForegroundColor(foregroundColor);
            WriteLine(s);
        }
        protected void WriteLine(string s)
        {
            Console.WriteLine(s);
        }
        private void SetForegroundColor(ConsoleColor foregroundColor)
        {
            Console.ForegroundColor = foregroundColor;
        } 
        private void SetBackgroundColor(ConsoleColor backgroundColor)
        {
            Console.BackgroundColor = backgroundColor;
        }
    }
}
