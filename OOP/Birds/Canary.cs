namespace Birds
{
    internal class Canary : Bird, ISingable
    {
        public ConsoleColor Color => Feather.Color;
        public Canary()
            : base(ConsoleColor.Yellow, ConsoleColor.Black, 2)
        {

        }
        public void Sing() => Console.WriteLine("Canary is singing");
        public override void Fly() => Console.WriteLine("Canary is can fly");
    }
}
