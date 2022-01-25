using System;

namespace Lesson012
{
    public abstract class Animal
    {
        protected string Sound { get; set; }

        public void MakeSound() => Console.WriteLine(Sound);
    }
}
