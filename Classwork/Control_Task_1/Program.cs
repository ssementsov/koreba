namespace Control_Task_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Rec(1, 7);
            Console.WriteLine();
            Rec(7, 1);
        }

        private static void Rec(int a, int b)
        {
            Console.Write($"{a} ");

            if (a > b)
            {
                Rec(--a, b);
            }
            else if (a < b)
            {
                Rec(++a, b);
            }
        }
    }
}
