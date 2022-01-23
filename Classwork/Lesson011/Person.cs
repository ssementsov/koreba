using System;

namespace Lesson011
{
    public class Person
    {
        private string name;
        private int age;

        public Person()
        {
            name = "Anonim";
            age = -1;
        }

        public void PrintToConsole()
        {
            Console.WriteLine($"Name = {name}, Age = {age}");
        }
    }
}
