using System;

namespace Lesson012
{
    public class Dog : Animal
    {
        public Dog()
        {
            Sound = "Woof-Woof";
        }

        public void BringStick() => Console.WriteLine("Bring a stick");
    }
}
