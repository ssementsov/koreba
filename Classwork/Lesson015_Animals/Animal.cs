namespace Lesson015_Animals
{
    abstract class Animal
    {
        protected abstract string Name { get; }
        public abstract void MakeSound();
        public void Run(Animal animal)
        {
            Console.WriteLine($"The {animal.Name} is running.");
        }
    }
}
