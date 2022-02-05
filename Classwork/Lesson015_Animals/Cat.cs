namespace Lesson015_Animals
{
    internal class Cat : Animal
    {
        protected override string Name => nameof(Cat);
        public override void MakeSound() => Console.WriteLine("Meow-Meow");
    }
}
