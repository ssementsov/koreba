namespace Birds
{
    internal abstract class Bird : Animal, IFlyable
    {
        public Wings Wings { get; private set; }
        public Feather Feather { get; private set; }
        public Bird()
        {
            Wings = new Wings();
            Feather = new Feather();
        }
        public Bird(Wings wings, Feather feather)
        {
            Wings = wings;
            Feather = feather;
        }
        public Bird(ConsoleColor featherColor, ConsoleColor wingsColor, uint wingsCount)
        {
            Wings = new Wings(wingsCount, wingsColor);
            Feather = new Feather(featherColor);
        }
        public virtual void Fly() => Console.WriteLine("Bird is can fly");
    }
}
