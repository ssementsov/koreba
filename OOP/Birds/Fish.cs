namespace Birds
{
    internal abstract class Fish : Animal
    {
        public override void Move() => Console.WriteLine("Fish is swimming");
        public override void Breathe() => Console.WriteLine("Fish is breathing");
    }
}
