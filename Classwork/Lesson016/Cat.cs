namespace Lesson016
{
    internal class Cat : Animal
    {
        string Animal.Name => nameof(Cat);
        public void MakeSound() => Console.WriteLine("Meow-Meow");
    }
}
