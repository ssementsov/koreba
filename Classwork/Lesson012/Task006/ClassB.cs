using System;

namespace Lesson012.Task006
{
    internal class ClassB : ClassA
    {
        private string _name;

        public ClassB()
        {
            _name = "Default";
        }

        public override void Print()
        {
            base.Print();
            Console.Write($"Name = {_name}");
        }
    }
}
