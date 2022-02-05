class Program
{
    static void Main()
    {
        string s =
            $"class Program\n" +
            $"{{\n" +
            $"    static void Main()\n" +
            $"    {{\n" +
            $"        string s = ;\n" +
            $"        Console.WriteLine(s, s);\n" +
            $"    }}\n" +
            $"}}";
        Console.WriteLine(s);
    }
}
