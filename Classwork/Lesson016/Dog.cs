namespace Lesson016
{
    internal class Dog : Animal
    {
        string Animal.Name => nameof(Dog);
        public void MakeSound() => Console.WriteLine("Woof-Woof");
    }
}
