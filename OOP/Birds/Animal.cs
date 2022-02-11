namespace Birds
{
    internal abstract class Animal : IMovable, IBreathable
    {
        public Skin Skin { get; private set; }

        public Animal()
        {
            Skin = new Skin();
        }
        public Animal(Skin skin)
        {
            Skin = skin;
        }

        public virtual void Move() => Console.WriteLine("Animal is moving");
        public virtual void Breathe() => Console.WriteLine("Animal is breathing");
    }
}
