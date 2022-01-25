using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson012
{
    public class Employee : Person
    {
        string company;

        public Employee(string name, int age, string company)
            : base(name, age)
        {
            this.company = company;
            Console.WriteLine("Employee(string name, int age, string company)");
        }
    }
}
