namespace Birds
{
    internal class Ostrich : Bird
    {
        public BirdSize Size { get; private set; }

        public Ostrich()
        {
            Size = BirdSize.TALL;
        }
        public override void Fly() => Console.WriteLine("Ostrich is cannot fly");
    }
}
