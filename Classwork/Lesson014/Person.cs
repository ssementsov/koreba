using System;

namespace Lesson014
{
    internal class Person
    {
        private string _fullName = "None";
        private int _age = -1;

        public Person()
        {

        }

        public Person(string fullName, int age)
        {
            _fullName = fullName;
            _age = age;
        }

        public void Move()
        {
            Console.WriteLine($"Person {_fullName} is moving");
        }

        public void Talk()
        {
            Console.WriteLine($"Person {_fullName} is talking");
        }
    }
}
