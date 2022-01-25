using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson012
{
    public class Person
    {
        string name;
        int age;

        public Person(string name)
        {
            this.name = name;
            Console.WriteLine("Person(string name)");
        }

        public Person(string name, int age) 
            : this(name)
        {
            this.age = age;
            Console.WriteLine("Person(string name, int age)");
        }
    }
}
