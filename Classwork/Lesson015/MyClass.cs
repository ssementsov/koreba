namespace Lesson015
{
    internal static class MyClass
    {
        static string variable = null;

        static MyClass() => variable = "HelloWorld";

        public static void DisplayVariable() => Console.WriteLine(variable);
        public static string Property { set => variable = value; }

        const double PI = 3.14;

        public class NestedClass
        {

        }
    }
}
