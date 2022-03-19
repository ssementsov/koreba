namespace FarPrototype.Visualizers
{
    internal abstract class Visualizer
    {
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
