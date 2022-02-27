namespace FarPrototype.Visualizers.BodyTypes
{
    internal abstract class Visualizer
    {
        protected void Write(string s)
        {
            Console.Write(s);
        }
        protected void Write(string s, ConsoleColor foregroundColor)
        {
            SetForegroundColor(foregroundColor);
            Write(s);
        }
        protected void WriteLine(string s)
        {
            Console.WriteLine(s);
        }
        protected void WriteLine(string s, ConsoleColor foregroundColor)
        {
            SetForegroundColor(foregroundColor);
            WriteLine(s);
        }
        private void SetForegroundColor(ConsoleColor foregroundColor)
        {
            Console.ForegroundColor = foregroundColor;
        } 
    }
}
