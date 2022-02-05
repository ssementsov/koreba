namespace Lesson015_Animals
{
    internal class Dog : Animal
    {
        protected override string Name => nameof(Dog);
        public override void MakeSound() => Console.WriteLine("Woof-Woof");
    }
}
