namespace FarPrototype.Visualizers.BodyTypes.TestVisuzlizers
{
    internal class TestDrawer
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
