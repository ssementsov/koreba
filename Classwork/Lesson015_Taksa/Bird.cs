namespace Lesson015_Taksa
{
    internal class Bird
    {
        public virtual void Fly(string name) => Console.WriteLine($"{name}: Fly");
    }

    internal class Canary : Bird { }

    internal class Ostrich : Bird
    {
        public override void Fly(string name) => Console.WriteLine($"{name}: Not fly");
    }
}
