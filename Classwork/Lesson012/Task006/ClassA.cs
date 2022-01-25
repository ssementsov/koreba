using System;

namespace Lesson012.Task006
{
    internal abstract class ClassA
    {
        protected int field_1;
        protected int field_2;

        public virtual void Print()
        {
            Console.Write($"field_1 = {field_1}; field_2 = {field_2}; ");
        }
    }
}
