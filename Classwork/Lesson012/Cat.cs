using System;

namespace Lesson012
{
    public class Cat : Animal
    {
        public Cat()
        {
            Sound = "Meow-Meow";
        }

        public void CatchMouse() => Console.WriteLine("Catch the mouse");
    }
}
