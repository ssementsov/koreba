namespace FarPrototype.Settings
{
    internal static class InputSettings
    {
        public static ConsoleKey Exit { get; } = ConsoleKey.Escape;
        public static ConsoleKey Up { get; } = ConsoleKey.UpArrow;
        public static ConsoleKey Down { get; } = ConsoleKey.DownArrow;
        public static ConsoleKey Left { get; } = ConsoleKey.LeftArrow;
        public static ConsoleKey Right { get; } = ConsoleKey.RightArrow;
        public static ConsoleKey Execute { get; } = ConsoleKey.Enter;
        public static ConsoleKey SwitchWindow { get; set; } = ConsoleKey.Tab;
    }
}
