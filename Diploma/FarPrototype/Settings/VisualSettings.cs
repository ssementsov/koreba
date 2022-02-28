namespace FarPrototype.Settings
{
    internal static class VisualSettings
    {
        public static ConsoleColor Background { get; set; } = ConsoleColor.DarkBlue;
        public static ConsoleColor FocusBackground { get; set; } = ConsoleColor.Cyan;
        public static ConsoleColor TextForeground { get; set; } = ConsoleColor.White;
        //public static ConsoleColor DirectoryForeground { get; set; } = ConsoleColor.White;
        //public static ConsoleColor FileForeground { get; set; } = ConsoleColor.Cyan;
        public static ConsoleColor FocusFileForeground { get; set; } = ConsoleColor.DarkBlue;
        public static ConsoleColor BorderForeground { get; set; } = ConsoleColor.Cyan;
        public static ConsoleColor DefaultBackground { get; } = ConsoleColor.Black;
    }
}
